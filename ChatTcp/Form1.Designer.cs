namespace ChatTcp
{
    partial class frmChat
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
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.txtMyMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtGoalIP = new System.Windows.Forms.TextBox();
            this.lblGoalIP = new System.Windows.Forms.Label();
            this.txtMyName = new System.Windows.Forms.TextBox();
            this.lblMyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessageBox.Location = new System.Drawing.Point(8, 7);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(288, 250);
            this.lblMessageBox.TabIndex = 0;
            this.lblMessageBox.Text = "HELLO,EYERYONE!\r\n";
            // 
            // txtMyMessage
            // 
            this.txtMyMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMyMessage.Location = new System.Drawing.Point(10, 260);
            this.txtMyMessage.Multiline = true;
            this.txtMyMessage.Name = "txtMyMessage";
            this.txtMyMessage.Size = new System.Drawing.Size(248, 38);
            this.txtMyMessage.TabIndex = 1;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(263, 260);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(70, 37);
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
            this.txtGoalIP.Location = new System.Drawing.Point(189, 309);
            this.txtGoalIP.Name = "txtGoalIP";
            this.txtGoalIP.Size = new System.Drawing.Size(144, 21);
            this.txtGoalIP.TabIndex = 3;
            this.txtGoalIP.TextChanged += new System.EventHandler(this.txtGoalIP_TextChanged);
            // 
            // lblGoalIP
            // 
            this.lblGoalIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGoalIP.AutoSize = true;
            this.lblGoalIP.Location = new System.Drawing.Point(130, 312);
            this.lblGoalIP.Name = "lblGoalIP";
            this.lblGoalIP.Size = new System.Drawing.Size(53, 12);
            this.lblGoalIP.TabIndex = 4;
            this.lblGoalIP.Text = "目标ip：";
            // 
            // txtMyName
            // 
            this.txtMyName.Location = new System.Drawing.Point(65, 309);
            this.txtMyName.Name = "txtMyName";
            this.txtMyName.Size = new System.Drawing.Size(59, 21);
            this.txtMyName.TabIndex = 5;
            // 
            // lblMyName
            // 
            this.lblMyName.AutoSize = true;
            this.lblMyName.Location = new System.Drawing.Point(12, 312);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(41, 12);
            this.lblMyName.TabIndex = 6;
            this.lblMyName.Text = "名字：";
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 342);
            this.Controls.Add(this.lblMyName);
            this.Controls.Add(this.txtMyName);
            this.Controls.Add(this.lblGoalIP);
            this.Controls.Add(this.txtGoalIP);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMyMessage);
            this.Controls.Add(this.lblMessageBox);
            this.Name = "frmChat";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChat_FormClosed);
            this.Load += new System.EventHandler(this.frmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageBox;
        private System.Windows.Forms.TextBox txtMyMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtGoalIP;
        private System.Windows.Forms.Label lblGoalIP;
        private System.Windows.Forms.TextBox txtMyName;
        private System.Windows.Forms.Label lblMyName;
    }
}

