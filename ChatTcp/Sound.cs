using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatTcp
{
    public partial class Sound : Form
    {
        public delegate void DelegateShow();
        public DelegateShow DShow;
        public delegate void DelegateVoice(byte[] bt);
        public DelegateVoice DVoice;

        public Sound()
        {
            InitializeComponent();
        }

        private void frmSound_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 用来播放多媒体文件的API指令，可以播放MPEG,AVI,WAV,MP3,等等
        /// </summary>
        /// <param name="lpstrCommand">要发送的命令字符串。字符串结构是:[命令][设备别名][命令参数]</param>
        /// <param name="lpstrReturnString">返回信息的缓冲区,为一指定了大小的字符串变量</param>
        /// <param name="uReturnLength">缓冲区的大小,就是字符变量的长度</param>
        /// <param name="hwndCallback">回调方式，一般设为零</param>
        /// <returns></returns>
        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        private void btnStart_Click(object sender, EventArgs e)
        {
            mciSendString("close movie", "", 0, 0);
            mciSendString("open new type WAVEAudio alias movie", "", 0, 0);
            mciSendString("record movie", "", 0, 0);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mciSendString("stop movie", "", 0, 0);
            mciSendString("save movie Chat_Sending.wav", "", 0, 0);
            mciSendString("close movie", "", 0, 0);
        }

        private void Sound_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DShow();
        }

        

        private void btnOpenSave_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = "Chat_Saving.wav";
        }

        private void btnOpenSend_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = "Chat_Sending.wav";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            byte[] buf = this.FileContent("Chat_Sending.wav");
            this.DVoice(buf);
        }

        /// <summary>
        /// Files the content.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        private byte[] FileContent(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (fs != null)
                {

                    //关闭资源
                    fs.Close();
                }
            }
        }

    }
}
