using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Server01
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_listen_Click(object sender, EventArgs e)
        {
            try
            {   
               Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress ip = IPAddress.Any;
                IPAddress ip = Dns.Resolve(Dns.GetHostName()).AddressList[0];
                IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(txt_port.Text));

                txt_ip.Text = ip.ToString();

                socketWatch.Bind(point);
                showMsg("开始监听。。。");
                socketWatch.Listen(10);


                Thread th = new Thread(AcceptMessage);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch { }

        }
        Socket socketSend;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        void AcceptMessage(object o)
        {
            
           Socket socketWatch = o as Socket;
            while (true)
            {
                try
                {
                     socketSend = socketWatch.Accept();
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    cbb_user.Items.Add(socketSend.RemoteEndPoint.ToString());
                    showMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");

                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                {
                    MessageBox.Show("无法与客户机通讯");
                }
            }
        }

        public void showMsg(string str)
        {
            txt_show.AppendText(str + "\r\n");
        }
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while(true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    showMsg(socketSend.RemoteEndPoint + ":" + str);

                }
                catch { }
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txt_Msg.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newbuffer = list.ToArray();

            string ip = cbb_user.SelectedItem.ToString();
            dicSocket[ip].Send(newbuffer);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
            ofd.Title = "选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            txt_path.Text = ofd.FileName;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
            using (FileStream fsRead  = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                dicSocket[cbb_user.SelectedItem.ToString()].Send(newbuffer, 0, r + 1, SocketFlags.None);

            }
        }

        private void btnShock_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[cbb_user.SelectedItem.ToString()].Send(buffer);
        }
    }
}
