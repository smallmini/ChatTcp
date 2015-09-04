using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTcp
{
    public partial class frmChat : Form
    {
        /// <summary>
        /// 目标ip
        /// </summary>
        string goalIP= "192.168.1.130";
        /// <summary>
        /// 本地ip
        /// </summary>
        IPAddress myIP;
        /// <summary>
        /// 服务器监听线程
        /// </summary>
        Thread listenerThread;
        

        public frmChat()
        {
            InitializeComponent();
        }

        private void frmChat_Load(object sender, EventArgs e)
        {
            //获取ip地址
            this.GetAddressIP();
            this.txtGoalIP.Text = this.myIP.ToString();

            //从新线程开始服务器监听
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.listenerThread = new Thread(new ThreadStart(this.ListenerRead));
            listenerThread.Start();
        }
        

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            
                this.ClientWrite();
        }
        
        /// <summary>
        /// 服务器端接收客户端消息
        /// </summary>
        private void ListenerRead()
        {
            while(true)
            {
                try
                {
                    TcpListener tcpListener = new TcpListener(this.myIP,2015);
                    tcpListener.Start();
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    NetworkStream netStream = tcpClient.GetStream();

                    byte[] buf = new byte[1000];

                    netStream.Read(buf, 0, 1000);

                    this.lblMessageBox.Text += Encoding.Default.GetString(buf);

                    netStream.Close();
                    tcpClient.Close();
                    tcpListener.Stop();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            
            }
                
        }

        /// <summary>
        /// 客户端向服务器端发送消息
        /// </summary>
        private void ClientWrite()
        {
            
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(this.goalIP, 2015);
                NetworkStream netStream = tcpClient.GetStream();

                byte[] buf = Encoding.Default.GetBytes("\x000A"+DateTime.Now.ToString()+"  "+this.txtMyName.Text+":\x000A"+this.txtMyMessage.Text);

                netStream.Write(buf, 0, buf.Length);

                netStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        /// <summary>
        /// 获取本地IP地址信息
        /// </summary>
        void GetAddressIP()
        {
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    this.myIP = _IPAddress;
                    break;
                }
            }
            this.Text += this.myIP.ToString();
        }

        private void txtGoalIP_TextChanged(object sender, EventArgs e)
        {
            //获取目标ip
            this.goalIP = this.txtGoalIP.Text;
        }

        private void frmChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            //强制退出所有线程
            System.Environment.Exit(0);
        }
    }
}
