namespace SmtpClientTest
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
		///
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNeedAccount = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cboSmtpServer = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkEnableSsl = new System.Windows.Forms.CheckBox();
            this.grpAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Body:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(53, 76);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(182, 22);
            this.txtTo.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(53, 107);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(182, 22);
            this.txtSubject.TabIndex = 7;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(53, 148);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(182, 68);
            this.txtBody.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Smtp Server:";
            // 
            // chkNeedAccount
            // 
            this.chkNeedAccount.AutoSize = true;
            this.chkNeedAccount.Location = new System.Drawing.Point(14, 59);
            this.chkNeedAccount.Name = "chkNeedAccount";
            this.chkNeedAccount.Size = new System.Drawing.Size(84, 16);
            this.chkNeedAccount.TabIndex = 4;
            this.chkNeedAccount.Text = "要帳號密碼";
            this.chkNeedAccount.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "帳號:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "密碼:";
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.label6);
            this.grpAccount.Controls.Add(this.label7);
            this.grpAccount.Controls.Add(this.txtPassword);
            this.grpAccount.Controls.Add(this.txtAccount);
            this.grpAccount.Location = new System.Drawing.Point(14, 73);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(197, 82);
            this.grpAccount.TabIndex = 6;
            this.grpAccount.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(55, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(55, 15);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(135, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Controls.Add(this.btnOpenFile);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.lstAttachments);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBody);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.txtSubject);
            this.groupBox2.Location = new System.Drawing.Point(217, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 333);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sender:";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(97, 45);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(138, 22);
            this.txtSender.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::SmtpClientTest.Properties.Resources.openHS;
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(178, 292);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(57, 23);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "開檔";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::SmtpClientTest.Properties.Resources.DeleteHS;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(53, 292);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(54, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "刪除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.HorizontalScrollbar = true;
            this.lstAttachments.ItemHeight = 12;
            this.lstAttachments.Location = new System.Drawing.Point(53, 222);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(182, 64);
            this.lstAttachments.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "附件:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(53, 17);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(182, 22);
            this.txtFrom.TabIndex = 1;
            // 
            // cboSmtpServer
            // 
            this.cboSmtpServer.FormattingEnabled = true;
            this.cboSmtpServer.Items.AddRange(new object[] {
            "localhost"});
            this.cboSmtpServer.Location = new System.Drawing.Point(83, 6);
            this.cboSmtpServer.Name = "cboSmtpServer";
            this.cboSmtpServer.Size = new System.Drawing.Size(121, 20);
            this.cboSmtpServer.TabIndex = 1;
            this.cboSmtpServer.Text = "localhost";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(14, 160);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(197, 185);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "寄送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(83, 29);
            this.nudPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(121, 22);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkEnableSsl
            // 
            this.chkEnableSsl.AutoSize = true;
            this.chkEnableSsl.Location = new System.Drawing.Point(104, 59);
            this.chkEnableSsl.Name = "chkEnableSsl";
            this.chkEnableSsl.Size = new System.Drawing.Size(70, 16);
            this.chkEnableSsl.TabIndex = 5;
            this.chkEnableSsl.Text = "啟用 SSL";
            this.chkEnableSsl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 357);
            this.Controls.Add(this.chkEnableSsl);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cboSmtpServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.chkNeedAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmtpClientTest";
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkNeedAccount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox grpAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFrom;
		private System.Windows.Forms.ComboBox cboSmtpServer;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.NumericUpDown nudPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstAttachments;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.CheckBox chkEnableSsl;
	}
}

