using System;
using System.IO;
using System.Collections;

namespace ExternalSub
{
    public class SubTitleItem
    {
        public Int32 ID;
        public Time From;
        public Time To;
        public String Text;
    }

    public class SubTiltleArr
    {
        readonly ArrayList arr;

        public SubTiltleArr()
        {
            arr = new ArrayList();
        }

        public void Add(SubTitleItem item)
        {
            arr.Add(item);
        }

        public SubTitleItem this[int index] { get { return (SubTitleItem)arr[index]; } }
        public int Count { get { return arr.Count; } }

        public void Clear()
        {
            arr.Clear();
        }

    }
    
    public class Subtitles
    {
        private readonly SubTiltleArr SubItems = new SubTiltleArr();

        public SubTiltleArr Items { get { return SubItems; } }
        public Int32 IndexOfSubBySeconds(Int64 seconds)
        {
            Int32 res = -1;
            
            var time = new Time(seconds * 1000);
            for (int i = 0; i < SubItems.Count; i++)
            {
                if (SubItems[i].From > time)
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public void ReadFromFile(String path)
        {
            if (File.Exists(path))
            {
                String line ="", text;

                try
                {
                    using (var sr = new StreamReader(path))
                    {

                        SubItems.Clear();
                        while (!sr.EndOfStream)
                        {
                            var itm = new SubTitleItem();

                            line = "";
                            while ((line == "") && (!sr.EndOfStream))
                                line = sr.ReadLine();
                            if (sr.EndOfStream)
                                break;
                            itm.ID = Convert.ToInt32(line);

                            line = "";
                            while ((line == "") && (!sr.EndOfStream))
                                line = sr.ReadLine();
                            if (sr.EndOfStream)
                                break;

                            Int32 moveindx = line.IndexOf("-->", StringComparison.Ordinal);
                            if (moveindx >= 0)
                            {
                                String from = line.Substring(0, moveindx - 1);
                                String to = line.Substring(moveindx + 4, line.Length - moveindx - 4);
                                itm.From = new Time(from);
                                itm.To = new Time(to);
                            }
                            else
                            {
                                throw new Exception("Error parsing sub: no '-->' in timeline");
                            }

                            text = "";
                            while (!sr.EndOfStream)
                            {
                                line = sr.ReadLine();
                                if (line != "")
                                {
                                    if (text.Length > 0)
                                        text += "\r\n";
                                    text += line;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            itm.Text = text;

                            SubItems.Add(itm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(String.Format("Error parsing sub '{0}'\nLine: '{1}'\n{2}", path, line, ex.Message));
                }

            }
            else
            {
                throw new Exception("File not found");
            }

        }
    }
}
