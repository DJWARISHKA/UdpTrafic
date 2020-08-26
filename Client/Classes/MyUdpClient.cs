using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Client
{
    internal class MyUdpClient
    {
        private static IPAddress remoteAddress;
        private static int port;
        private static int delay;
        private SqlData sqlData = new SqlData();
        private ulong sendUdp;
        private ulong getUdp;
        private bool work = true;
        private bool getData = false;
        private byte[] data;
        private Thread thWriteData;

        public string RemoteAddress { get => remoteAddress.ToString(); }
        public int Port { get => port; }
        public ulong LostUdp { get => sendUdp - getUdp; }
        public int Delay { get => delay; }

        public MyUdpClient()
        {
            //get settings from xml
            XDocument xdoc = XDocument.Load("ClientSettings.xml");
            remoteAddress = IPAddress.Parse(xdoc.Element("client").Element("ip").Value.ToString());
            port = int.Parse(xdoc.Element("client").Element("port").Value.ToString());
            delay = int.Parse(xdoc.Element("client").Element("delay").Value.ToString());
            sqlData.DeleteData();
            sendUdp = 0;
            getUdp = 0;
            //create Thread to receive messages
            thWriteData = new Thread(new ThreadStart(WriteData));
            thWriteData.Start();
        }

        //receive udp messages
        public void ReceiveMessage()
        {
            //creating UdpClient for receiving
            UdpClient receiver = new UdpClient(port);
            receiver.JoinMulticastGroup(remoteAddress, 10);
            IPEndPoint remoteIp = null;
            try
            {
                while (work)
                {
                    Thread.Sleep(delay);
                    //get data
                    data = receiver.Receive(ref remoteIp);
                    if (data[12] == 42)
                    {
                        getData = true;
                        getUdp++;
                        sendUdp = BitConverter.ToUInt64(data, 4);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close UdpClient
                receiver.Close();
            }
        }

        private void WriteData()
        {
            int num;
            while (work)
            {
                if (getData)
                {
                    //splitting data
                    num = BitConverter.ToInt32(data, 0);
                    //write number to data base
                    sqlData.WriteData(num);
                    getData = false;
                }
            }
        }
        //stop receiving
        public void Stop()
        {
            work = false;
            thWriteData.Join();
        }
    }
}