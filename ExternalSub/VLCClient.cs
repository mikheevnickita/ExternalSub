using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExternalSub
{
    public class VLCClient
    {
        readonly TelnetClient _telnet;

        public VLCClient(String server)
            : this(server, "4212")
        {
        }

        public VLCClient(String server, String port)
        {
            _telnet = new TelnetClient(server, port);
        }

        private void SendCmd(String command)
        {
            _telnet.Send(command);
        }

        private String ReadLine()
        {
            return _telnet.Recv();
        }

        private void WaitFor()
        {
            WaitFor("");
        }

        private void WaitFor(String expect)
        {
            String line = _telnet.Recv();

            if (expect != "")
                if (line != expect)
                { 
                    throw new Exception("Protocol error");
                }

        }

        public void Connect()
        {
            _telnet.Open();
        }

        public void Login(String password)
        {
            try
            {
                WaitFor();
                SendCmd(password);
                WaitFor();
                WaitFor("Welcome, Master");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Time get_Time()
        {
            SendCmd("get_time");
            try 
            {
                Int32 ans = Convert.ToInt32(ReadLine().Substring(2));
                return new Time(ans * 1000);
            } catch {
                return null;
            }
        }

        public Boolean IsPlaying()
        {
            SendCmd("is_playing");
            return Convert.ToInt32(ReadLine().Substring(2)) > 0;
        }

        public String get_Path()
        {
            SendCmd("status");
            String a = ReadLine();
            if (a.Substring(2, 12) == "( new input:")
            {
                String b = ReadLine();
                String c = ReadLine();
            }
            else
            {
                throw new Exception("input path not found");
            }

            var uri = new Uri(a.Substring(15, a.Length - 17));
            return uri.LocalPath;

        }

        public void Disconnect()
        {
            _telnet.Send("Logout");
            _telnet.Close();
        }

    }
}
