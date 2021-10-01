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

namespace Client01
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        Socket socketSend;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txt_ip.Text);
                IPEndPoint point = new IPEndPoint(ip, int.Parse(txt_port.Text));

                socketSend.Connect(point);

                showMsg("连接成功");
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();

               /* if (socketSend.Connected)
                {
                    showMsg("与服务器连接成功");
                }*/
            }
            catch { 
                MessageBox.Show("与服务器连接失败");
            }

        }
        void Recive()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        showMsg(socketSend.RemoteEndPoint + ":"+s);

                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
                        sfd.Title = "选择要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else if(buffer[0]==2)
                    {
                        ZD();
                    }
                }
                catch { }
            }
        }
        public void showMsg(string str)
        {
            txt_show.AppendText(str + "\r\n");
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string str = txt_Msg.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(280, 280);
            }
        }
    }
}
