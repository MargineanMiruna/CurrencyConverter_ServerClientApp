using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Web;
using System.IO;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string amount = amountBox.Text.ToString();
            string baseCurrency = baseBox.Text.ToString();
            string targetCurrency = targetBox.Text.ToString();
            Convert(baseCurrency, targetCurrency, amount);
        }

        private void Convert(string baseCurrency, string targetCurrency, string amount)
        {
            TcpClient tcpClient = new TcpClient("192.168.1.136", 7890);
            NetworkStream netStream = tcpClient.GetStream();

            string msg = baseCurrency + " " + targetCurrency + " " + amount;
            byte[] buf = Encoding.UTF8.GetBytes(msg);
            netStream.Write(buf, 0, buf.Length);

            StreamReader reader = new StreamReader(netStream, Encoding.UTF8);
            string response = reader.ReadToEnd();
            label3.Text = response + " " + targetCurrency;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amountBox_Click(object sender, EventArgs e)
        {
            amountBox.Clear();
        }
    }
}
