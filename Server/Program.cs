namespace Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sender.UdpSender sender = new Sender.UdpSender();
            sender.Start();
        }
    }
}