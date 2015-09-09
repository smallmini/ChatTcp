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
    public partial class Chat : Form
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
        Thread listenerTextThread;
        Thread listenerVoiceThread;
        /// <summary>
        /// 语言窗口
        /// </summary>
        Sound frmSound;

        byte[] buf = Encoding.Default.GetBytes("");

        public Chat()
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
            this.listenerTextThread = new Thread(new ParameterizedThreadStart(this.ListenerRead));
            listenerTextThread.Start(MessageType.Text);
            this.listenerVoiceThread = new Thread(new ParameterizedThreadStart(this.ListenerRead));
            listenerVoiceThread.Start(MessageType.Voice);
        }
        

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            
                this.ClientWrite(MessageType.Text);
        }
        
        /// <summary>
        /// 服务器端接收客户端消息
        /// </summary>
        private void ListenerRead(object mt)
        {
            this.ListenerRead((MessageType)mt);     
        }
        private void ListenerRead(MessageType mt)
        {
            while (true)
            {
                try
                {
                    TcpListener tcpListener = new TcpListener(this.myIP, ((int)mt));
                    tcpListener.Start();
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    NetworkStream netStream = tcpClient.GetStream();

                    byte[] bufl = new byte[1000000];
                    
                    netStream.Read(bufl, 0, 1000000);

                    if (mt == MessageType.Text)
                    {
                        this.txtMessageBox.Text += Environment.NewLine + Encoding.Default.GetString(bufl);
                    }
                    else if (mt == MessageType.Voice)
                    {
                        System.IO.File.WriteAllBytes(@"Chat_Saving.wav", this.buf);
                        MessageBox.Show("有新语音消息！");
                    }
                    else
                    {
                        throw new Exception();
                    }
                    

                    netStream.Close();
                    tcpClient.Close();
                    tcpListener.Stop();
                }
                catch (Exception ex)
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
        private void ClientWrite(MessageType mt)
        {

            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect(this.goalIP, ((int)mt));
                NetworkStream netStream = tcpClient.GetStream();

                

                if (mt==MessageType.Text)
                {
                    this.buf = Encoding.Default.GetBytes(Environment.NewLine + DateTime.Now.ToString() + "  " + this.txtMyName.Text + ":" + Environment.NewLine + this.txtMyMessage.Text);
                }
                else if(mt==MessageType.Voice)
                {
                    System.IO.File.WriteAllBytes(@"Chat_Saving.wav", this.buf);
                    MessageBox.Show("有新语音消息！");
                }
                else
                {
                    throw new Exception();
                }
                

                netStream.Write(this.buf, 0, buf.Length);

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
            this.Text += "  本机ip："+this.myIP.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Sound frmSound = new Sound();

            frmSound.Show();
            this.Hide();

            frmSound.DShow +=delegate (){
                this.Show();
            };

            frmSound.DVoice+=delegate (byte[] bt){
                this.buf = bt;
                this.ClientWrite(MessageType.Voice);
            };
            
        }
    }
    /// <summary>
    /// 信息类别
    /// </summary>
    enum MessageType
    {
        /// <summary>
        /// 文字信息
        /// </summary>
        Text=2015,
        /// <summary>
        /// 语言信息
        /// </summary>
        Voice=2016,
    }
}
