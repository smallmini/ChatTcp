namespace ChatTcp
{
    partial class Chat
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMyMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtGoalIP = new System.Windows.Forms.TextBox();
            this.lblGoalIP = new System.Windows.Forms.Label();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.lblMyName = new System.Windows.Forms.Label();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMyMessage
            // 
            this.txtMyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMyMessage.Location = new System.Drawing.Point(10, 260);
            this.txtMyMessage.MaxLength = 900;
            this.txtMyMessage.Multiline = true;
            this.txtMyMessage.Name = "txtMyMessage";
            this.txtMyMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMyMessage.Size = new System.Drawing.Size(328, 38);
            this.txtMyMessage.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(344, 260);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(69, 37);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "发送";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtGoalIP
            // 
            this.txtGoalIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoalIP.Location = new System.Drawing.Point(202, 309);
            this.txtGoalIP.MaxLength = 20;
            this.txtGoalIP.Name = "txtGoalIP";
            this.txtGoalIP.Size = new System.Drawing.Size(211, 21);
            this.txtGoalIP.TabIndex = 3;
            this.txtGoalIP.TextChanged += new System.EventHandler(this.txtGoalIP_TextChanged);
            // 
            // lblGoalIP
            // 
            this.lblGoalIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoalIP.AutoSize = true;
            this.lblGoalIP.Location = new System.Drawing.Point(143, 312);
            this.lblGoalIP.Name = "lblGoalIP";
            this.lblGoalIP.Size = new System.Drawing.Size(53, 12);
            this.lblGoalIP.TabIndex = 4;
            this.lblGoalIP.Text = "目标ip：";
            // 
            // txtMyName
            // 
            this.txtMyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMyName.Location = new System.Drawing.Point(65, 309);
            this.txtMyName.MaxLength = 20;
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.Size = new System.Drawing.Size(126, 21);
            this.txtMyName.TabIndex = 5;
            // 
            // lblMyName
            // 
            this.lblMyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMyName.AutoSize = true;
            this.lblMyName.Location = new System.Drawing.Point(12, 312);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(41, 12);
            this.lblMyName.TabIndex = 6;
            this.lblMyName.Text = "名字：";
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageBox.Location = new System.Drawing.Point(14, 17);
            this.txtMessageBox.Multiline = true;
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.ReadOnly = true;
            this.txtMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageBox.Size = new System.Drawing.Size(355, 237);
            this.txtMessageBox.TabIndex = 7;
            this.txtMessageBox.Text = "HELLO,EYERYONE!\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "语音";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.lblMyName);
            this.Controls.Add(this.txtMyName);
            this.Controls.Add(this.lblGoalIP);
            this.Controls.Add(this.txtGoalIP);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMyMessage);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmChat";
            this.Text = "ChatTcp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChat_FormClosed);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMyMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtGoalIP;
        private System.Windows.Forms.Label lblGoalIP;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Button button1;
    }
}

