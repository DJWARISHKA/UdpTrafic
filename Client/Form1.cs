using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MyUdpClient udpClient = new MyUdpClient();
        private Thread receiveThread;

        private void Form1_Load(object sender, EventArgs e)
        {
            //create Thread to receive messages
            receiveThread = new Thread(new ThreadStart(udpClient.ReceiveMessage));
            receiveThread.Start();
            lip.Text += udpClient.RemoteAddress + ":" + udpClient.Port;
            lDelay.Text += udpClient.Delay.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stop receiving
            udpClient.Stop();
            receiveThread.Join();
        }

        //outputs
        private void button1_Click(object sender, EventArgs e)
        {
            SqlData sqlData = new SqlData();
            DataSet dataSet = new DataSet("Table");
            //get table from data base
            sqlData.GetData(ref dataSet);
            Calculate calc = new Calculate();
            //handle the table
            calc.CalculateTable(ref dataSet);
            //output the results
            tAverageValue.Text = calc.AverageValue().ToString();
            tStandardDeviation.Text = calc.StandardDeviation().ToString();
            dataSet.Tables[0].Clear();
            tLost.Text = udpClient.LostUdp.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(null, null);
            }
        }
    }
}