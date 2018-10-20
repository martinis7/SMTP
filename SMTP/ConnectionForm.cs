using System;
using System.Drawing;
using System.Windows.Forms;

namespace SMTP
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string hostname;
            int port;
            string username;
            string password;
            bool parseCondition = true;

            if (string.IsNullOrEmpty(txt_hostname.Text))
            {
                txt_hostname.BackColor = Color.Red;
                parseCondition = false;
            }

            if (!int.TryParse(txt_port.Text, out port))
            {
                txt_port.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(txt_SenderMail.Text))
            {
                txt_SenderMail.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(txt_SenderPassword.Text))
            {
                txt_SenderPassword.BackColor = Color.Red;
                parseCondition = false;
            }

            hostname = txt_hostname.Text;
            username = txt_SenderMail.Text;
            password = txt_SenderPassword.Text;

            if (parseCondition)
            {
                try
                {
                    SmtpProtocol.ConnectClientAndAuthorize(hostname, port, username, password);
                    MailForm mailForm = new MailForm();
                    mailForm.Show();
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
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
			SmtpProtocol.Close();
            Close();
        }
    }
}
