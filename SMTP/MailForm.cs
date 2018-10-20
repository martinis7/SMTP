using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMTP
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // uzdare forma atjungiam ir klienta
            SmtpProtocol.Close();
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string recipient;
            string subject;
            string message;
            bool parseCondition = true;

            if (string.IsNullOrEmpty(txt_Rcpt.Text))
            {
                txt_Rcpt.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(txt_Subject.Text))
            {
                txt_Subject.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(txt_Message.Text))
            {
                txt_Message.BackColor = Color.Red;
                parseCondition = false;
            }

            recipient = txt_Rcpt.Text;
            subject = txt_Subject.Text;
            message = txt_Message.Text;

            if (parseCondition)
            {
                try
                {
                    SmtpProtocol.SendMail(recipient, subject, message);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show(@"Apgailestaujame, tačiau įvyko klaida: " + ex.GetMessage(), @"Klaida", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Apgailestaujame, tačiau įvyko neatpažinta klaida ", @"Nežinoma klaida", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                MessageBox.Show(@"Jūsų laiškas išsiųstas sėkmingai", @"Pranešimas", MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
        }
    }
}
