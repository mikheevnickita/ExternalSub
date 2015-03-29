using System;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace ExternalSub
{
    class LingvoTranslate
    {
        static public String HTMLParse(String html)
        {
            Int32 pos = html.IndexOf("<div class=\"js-section-data\">", StringComparison.Ordinal);
            //("<div class=\"l-article  js-article-lingvo\">");

            if (pos < 0)
                return "Transliteration not found";
            {
                Int32 end = pos + 1;
                Int32 openDiv = 1;
                while (openDiv > 0)
                {
                    Int32 openDivIndx = html.IndexOf("<div", end, StringComparison.Ordinal);
                    Int32 closeDivIndx = html.IndexOf("</div", end, StringComparison.Ordinal);
                    if (openDivIndx < closeDivIndx)
                    {
                        openDiv++;
                        end = openDivIndx + 1;
                    }
                    else
                    {
                        openDiv--;
                        end = closeDivIndx + 1;
                    }
                }
                html = html.Substring(pos, end - pos);
            }

            String translateOnly = html.Replace("\t", "").Replace(">", ">\r\n");
            String result = "";
            Int32 indx = 0;

            while (indx < translateOnly.Length)
            {
                Int32 start, end, p;

                p = translateOnly.IndexOf("</p>", indx, StringComparison.Ordinal);
                start = translateOnly.IndexOf("<span class=\"translation\">", indx, StringComparison.Ordinal);

                if ((p >= 0) && (p < start) && (result != ""))
                    result += "\r\n * ";

                if (start >= 0)
                {

                    end = translateOnly.IndexOf("</span>", start, StringComparison.Ordinal);
                    if (end >= 0)
                    {
                        result += translateOnly.Substring(start + 28, end - start - 28);
                        indx = end + 7;
                    }
                    else
                    {
                        indx = translateOnly.Length;
                    }
                }
                else
                {
                    indx = translateOnly.Length;
                }

            }

            return result;
        }

        static private void SaveToFile(String text, String path)
        {
            File.AppendAllText(path, text);
        }

        static public async Task<String> Translate(String word)
        {
            if (word != "")
            {
                SaveToFile(word + "\n", "Trans.log");

                var http     = WebRequest.CreateHttp("http://www.lingvo-online.ru/ru/Translate/en-ru/" + word);
                var response = (HttpWebResponse)(await http.GetResponseAsync());

                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    return String.Format("{0}\r\n______________________\r\n * {1}", word, HTMLParse(sr.ReadToEnd()));
                }
            }
            else
            {
                return "";
            }
        }

    }
}
