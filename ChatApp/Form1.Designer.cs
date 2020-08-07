namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.meChat = new System.Windows.Forms.GroupBox();
            this.inputMyPort = new System.Windows.Forms.TextBox();
            this.inputMyIP = new System.Windows.Forms.TextBox();
            this.terwt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.friendChat = new System.Windows.Forms.GroupBox();
            this.inputFriendPort = new System.Windows.Forms.TextBox();
            this.inputFriendIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startCommunication = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.newMessage = new System.Windows.Forms.TextBox();
            this.sendMessage = new System.Windows.Forms.Button();
            this.meChat.SuspendLayout();
            this.friendChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // meChat
            // 
            this.meChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meChat.Controls.Add(this.inputMyPort);
            this.meChat.Controls.Add(this.inputMyIP);
            this.meChat.Controls.Add(this.terwt);
            this.meChat.Controls.Add(this.label1);
            this.meChat.Location = new System.Drawing.Point(0, 0);
            this.meChat.Name = "meChat";
            this.meChat.Size = new System.Drawing.Size(200, 100);
            this.meChat.TabIndex = 0;
            this.meChat.TabStop = false;
            this.meChat.Text = "Me";
            // 
            // inputMyPort
            // 
            this.inputMyPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMyPort.Location = new System.Drawing.Point(85, 57);
            this.inputMyPort.Name = "inputMyPort";
            this.inputMyPort.Size = new System.Drawing.Size(100, 23);
            this.inputMyPort.TabIndex = 2;
            // 
            // inputMyIP
            // 
            this.inputMyIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputMyIP.Location = new System.Drawing.Point(85, 28);
            this.inputMyIP.Name = "inputMyIP";
            this.inputMyIP.Size = new System.Drawing.Size(100, 23);
            this.inputMyIP.TabIndex = 2;
            // 
            // terwt
            // 
            this.terwt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terwt.AutoSize = true;
            this.terwt.Location = new System.Drawing.Point(6, 57);
            this.terwt.Name = "terwt";
            this.terwt.Size = new System.Drawing.Size(29, 15);
            this.terwt.TabIndex = 2;
            this.terwt.Text = "Port";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // friendChat
            // 
            this.friendChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendChat.Controls.Add(this.inputFriendPort);
            this.friendChat.Controls.Add(this.inputFriendIP);
            this.friendChat.Controls.Add(this.label4);
            this.friendChat.Controls.Add(this.label3);
            this.friendChat.Location = new System.Drawing.Point(384, 0);
            this.friendChat.Name = "friendChat";
            this.friendChat.Size = new System.Drawing.Size(200, 100);
            this.friendChat.TabIndex = 0;
            this.friendChat.TabStop = false;
            this.friendChat.Text = "Friend";
            // 
            // inputFriendPort
            // 
            this.inputFriendPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFriendPort.Location = new System.Drawing.Point(55, 57);
            this.inputFriendPort.Name = "inputFriendPort";
            this.inputFriendPort.Size = new System.Drawing.Size(100, 23);
            this.inputFriendPort.TabIndex = 2;
            // 
            // inputFriendIP
            // 
            this.inputFriendIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFriendIP.Location = new System.Drawing.Point(55, 28);
            this.inputFriendIP.Name = "inputFriendIP";
            this.inputFriendIP.Size = new System.Drawing.Size(100, 23);
            this.inputFriendIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // startCommunication
            // 
            this.startCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startCommunication.Location = new System.Drawing.Point(652, 42);
            this.startCommunication.Name = "startCommunication";
            this.startCommunication.Size = new System.Drawing.Size(75, 23);
            this.startCommunication.TabIndex = 1;
            this.startCommunication.Text = "Start Communication";
            this.startCommunication.UseVisualStyleBackColor = true;
            this.startCommunication.Click += new System.EventHandler(this.startCommunication_Click);
            // 
            // listMessage
            // 
            this.listMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 15;
            this.listMessage.Location = new System.Drawing.Point(12, 106);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(581, 274);
            this.listMessage.TabIndex = 2;
            // 
            // newMessage
            // 
            this.newMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newMessage.Location = new System.Drawing.Point(12, 397);
            this.newMessage.Name = "newMessage";
            this.newMessage.Size = new System.Drawing.Size(581, 23);
            this.newMessage.TabIndex = 3;
            // 
            // sendMessage
            // 
            this.sendMessage.Location = new System.Drawing.Point(652, 396);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(75, 23);
            this.sendMessage.TabIndex = 4;
            this.sendMessage.Text = "Send";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.newMessage);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.startCommunication);
            this.Controls.Add(this.friendChat);
            this.Controls.Add(this.meChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.meChat.ResumeLayout(false);
            this.meChat.PerformLayout();
            this.friendChat.ResumeLayout(false);
            this.friendChat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox meChat;
        private System.Windows.Forms.GroupBox friendChat;
        private System.Windows.Forms.Button startCommunication;
        private System.Windows.Forms.Label terwt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputMyPort;
        private System.Windows.Forms.TextBox inputMyIP;
        private System.Windows.Forms.TextBox inputFriendPort;
        private System.Windows.Forms.TextBox inputFriendIP;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox newMessage;
        private System.Windows.Forms.Button sendMessage;
    }
}

