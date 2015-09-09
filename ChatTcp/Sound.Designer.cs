namespace ChatTcp
{
    partial class Sound
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sound));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOpenSave = new System.Windows.Forms.Button();
            this.btnOpenSend = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始录制";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(88, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(67, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止录制";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(205, 63);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(67, 28);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnOpenSave
            // 
            this.btnOpenSave.Location = new System.Drawing.Point(175, 6);
            this.btnOpenSave.Name = "btnOpenSave";
            this.btnOpenSave.Size = new System.Drawing.Size(97, 23);
            this.btnOpenSave.TabIndex = 3;
            this.btnOpenSave.Text = "播放接收语音";
            this.btnOpenSave.UseVisualStyleBackColor = true;
            this.btnOpenSave.Click += new System.EventHandler(this.btnOpenSave_Click);
            // 
            // btnOpenSend
            // 
            this.btnOpenSend.Location = new System.Drawing.Point(175, 35);
            this.btnOpenSend.Name = "btnOpenSend";
            this.btnOpenSend.Size = new System.Drawing.Size(97, 23);
            this.btnOpenSend.TabIndex = 5;
            this.btnOpenSend.Text = "播放发送语音";
            this.btnOpenSend.UseVisualStyleBackColor = true;
            this.btnOpenSend.Click += new System.EventHandler(this.btnOpenSend_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(15, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(140, 33);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // Sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnOpenSend);
            this.Controls.Add(this.btnOpenSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Sound";
            this.Text = "frmSound";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sound_FormClosing);
            this.Load += new System.EventHandler(this.frmSound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOpenSave;
        private System.Windows.Forms.Button btnOpenSend;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}