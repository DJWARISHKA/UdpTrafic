using System;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;

namespace Server.Sender
{
    internal class UdpSender
    {
        private int min;
        private int max;
        private uint sendUdp;
        private static IPAddress remoteAddress;
        private static int port;

        public UdpSender()
        {
            //get settings from xml
            XDocument xdoc = XDocument.Load("ServerSettings.xml");
            sendUdp = 1;
            min = int.Parse(xdoc.Element("server").Element("min").Value.ToString());
            max = int.Parse(xdoc.Element("server").Element("max").Value.ToString());
            remoteAddress = IPAddress.Parse(xdoc.Element("server").Element("ip").Value.ToString()); ;
            port = int.Parse(xdoc.Element("server").Element("port").Value.ToString());
            //write current settings
            Console.Write("IP " + remoteAddress.ToString());
            Console.WriteLine(":{0}", port);
            Console.WriteLine("Min = {0}\nMax = {1}", min, max);
        }

        public void Start()
        {
            //creating UdpClient for sendimg
            UdpClient sender = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(remoteAddress, port);
            //create random
            Random rand = new Random();
            byte[] data = new byte[13];
            data[12] = 42;
            try
            {
                while (true)
                {
                    //insert random number from min to max
                    BitConverter.GetBytes(rand.Next(min, max)).CopyTo(data, 0);
                    //insert index of package
                    BitConverter.GetBytes(sendUdp).CopyTo(data, 4);
                    //send message
                    sender.Send(data, data.Length, endPoint);
                    sendUdp++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close UdpClient
                sender.Close();
            }
        }
    }
}