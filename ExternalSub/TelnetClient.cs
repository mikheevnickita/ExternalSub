using System;
using System.Net.Sockets;
using System.IO;

namespace ExternalSub
{
    public class TelnetClient
    {
        TcpClient clnt;
        String Host;
        Int32 Port;

        private NetworkStream networkStream;
        private StreamWriter Writer;
        private StreamReader Reader;

        public TelnetClient(String host, String port)
        {
            Host = host;
            Port = Convert.ToInt32(port);
        }

        public void Open()
        {
            if (clnt == null)
                clnt = new TcpClient();
            if (!clnt.Connected)
            {
                try
                {

                    clnt = new TcpClient();
                    clnt.Connect(Host, Port);
                    clnt.Client.Blocking = true;
                    networkStream = new NetworkStream(clnt.Client);
                    Writer = new StreamWriter(networkStream);
                    Reader = new StreamReader(networkStream);
                }
                catch
                {
                    throw new Exception(String.Format("TelnetClient: Can't connect to '{0}:{1}'", Host, Port));
                }
            }
        }

        public void Send(String msg)
        {
            Writer.WriteLine(msg);
            Writer.Flush();
        }

        public String Recv()
        {
            return Reader.ReadLine();
        }

        public void Close()
        {
            networkStream.Close();
            clnt.Client.Close();
            clnt.Close();
            clnt = null;
            networkStream = null;
            Reader = null;
            Writer = null;
        }

    }
}
