using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace dryingtest
{
    public partial class Form1 : Form
    {
        private object comboBoxCOM;
        private SerialPort serialPort;
        private int tc = 0;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Hiển thị các cổng COM có sẵn
            comboBox1.DataSource = SerialPort.GetPortNames();// trả về các cổng COM
        }
        private void connect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                connect.Text = "Connected";
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
            }
            else
            {
                connect.Text = "Disconnected";
                serialPort1.Close();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tudong_Click(object sender, EventArgs e)
        {
            tc = 0;
            serialPort1.Write("9");
        }
        private void thucong_Click(object sender, EventArgs e)
        {
            tc = 1;
            serialPort1.Write("8");
        }
        private void nut0_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("5");
            }
        }
        private void nut45_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && tc==1)
            {
                serialPort1.Write("1");
            }
        }
        private void nut90_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && tc == 1)
            {
                serialPort1.Write("2");
            }
        }

        private void nut135_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && tc == 1)
            {
                serialPort1.Write("3");
            }
        }
        private void nut180_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && tc == 1)
            {
                serialPort1.Write("4");
            }
        }
        private string receivedData = "";
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string newData = serialPort1.ReadLine();
            receivedData = newData.Trim();
    
            // Gọi phương thức xử lý dữ liệu
            xulydata();
        }
        private void xulydata()
        {
            // Xử lý dữ liệu nhận được từ biến receivedData trên luồng chính mainthread
            if (receivedData == "1")
            {
                this.Invoke((Action)(() =>//thực thi một phần mã trên luồng giao diện người dùng UIthread, phần mã này không nhận tham số và không trả về giá trị.
                {
                    trangthai.Text = "Đang phơi";
                    trangthai.ForeColor = Color.Black;
                }));
            }
            if (receivedData == "0")
            {
                this.Invoke((Action)(() =>
                {
                    trangthai.Text = "Đã thu";
                    trangthai.ForeColor = Color.Black;
                }));
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trangthai_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
