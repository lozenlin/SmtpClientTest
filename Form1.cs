using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace SmtpClientTest
{
    /// <summary>
    /// SmtpClientTest
    /// </summary>
    /// <history>
    /// 2007/04/02, lozen_lin, Create
    /// 2012/12/03, lozen_lin, Modify, add sender
    /// 2013/01/30, lozen_lin, Modify, show detail error message; show version number; 讓 EnableSsl 可以手動設定;
    /// </history>
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

            Text += " - v" + Application.ProductVersion;
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			MailMessage MailMsg = null;
			try
			{
				SmtpClient MailSender = new SmtpClient(cboSmtpServer.Text, Convert.ToInt32(nudPort.Value));
                MailSender.EnableSsl = chkEnableSsl.Checked;
				MailSender.Timeout = 60000;
				if (chkNeedAccount.Checked)
				{
					//要帳號
					MailSender.UseDefaultCredentials = false;
					MailSender.Credentials =
						new System.Net.NetworkCredential(txtAccount.Text, txtPassword.Text);
				}
				else
				{
					//用預設
					MailSender.UseDefaultCredentials = true;
				}

				MailMsg = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text);
                MailMsg.IsBodyHtml = chkIsBodyHtml.Checked; // 2020/01/22, lozenlin, add

                //註記真正的寄件人
                if (!string.IsNullOrEmpty(txtSender.Text.Trim()))
                {
                    MailMsg.Sender = new MailAddress(txtSender.Text);
                }

				//附件
				if (lstAttachments.Items.Count > 0)
				{
					foreach (string FileName in lstAttachments.Items)
						MailMsg.Attachments.Add(new Attachment(FileName));
				}

				MailSender.Send(MailMsg);
				MessageBox.Show("寄送成功！", "提示");
			}
			catch (SmtpException smtpex)
			{
                string errMsg = smtpex.Message;
                if (smtpex.InnerException != null)
                {
                    errMsg += "-" + smtpex.InnerException.Message;
                }

                MessageBox.Show(errMsg + "\nStatusCode: " + smtpex.StatusCode.ToString(), "Smtp例外錯誤");
			}
			catch (Exception ex)
			{
                string errMsg = ex.Message;
                if (ex.InnerException != null)
                {
                    errMsg += "-" + ex.InnerException.Message;
                }

                MessageBox.Show(ex.Message, "例外錯誤");
			}
			finally
			{
				if (MailMsg != null)
					MailMsg.Dispose();

				//清除附件清單
				lstAttachments.Items.Clear();
			}
		}

		private void btnOpenFile_Click(object sender, EventArgs e)
		{
			//開檔
			DialogResult dlgResult = openFileDialog1.ShowDialog();
			if (dlgResult == DialogResult.OK)
			{
				//加入附件清單
				lstAttachments.Items.Add(openFileDialog1.FileName);
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			//刪除附件清單項目
			if (lstAttachments.SelectedIndex != -1)
				lstAttachments.Items.RemoveAt(lstAttachments.SelectedIndex);
		}
	}
}