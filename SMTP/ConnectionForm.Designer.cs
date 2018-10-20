namespace SMTP
{
    partial class ConnectionForm
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
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_SenderPassword = new System.Windows.Forms.TextBox();
            this.txt_SenderMail = new System.Windows.Forms.TextBox();
            this.lbl_SenderName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.Location = new System.Drawing.Point(12, 15);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(89, 13);
            this.lbl_hostname.TabIndex = 10;
            this.lbl_hostname.Text = "Serverio adresas:";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(12, 63);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(40, 13);
            this.lbl_port.TabIndex = 9;
            this.lbl_port.Text = "Portas:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(169, 63);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(120, 20);
            this.txt_port.TabIndex = 2;
            // 
            // txt_hostname
            // 
            this.txt_hostname.Location = new System.Drawing.Point(169, 12);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(120, 20);
            this.txt_hostname.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(214, 225);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 5;
            this.btn_OK.Text = "Prisijungti";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Atšaukti";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_SenderPassword
            // 
            this.txt_SenderPassword.Location = new System.Drawing.Point(169, 155);
            this.txt_SenderPassword.Name = "txt_SenderPassword";
            this.txt_SenderPassword.PasswordChar = '*';
            this.txt_SenderPassword.Size = new System.Drawing.Size(120, 20);
            this.txt_SenderPassword.TabIndex = 4;
            // 
            // txt_SenderMail
            // 
            this.txt_SenderMail.Location = new System.Drawing.Point(169, 110);
            this.txt_SenderMail.Name = "txt_SenderMail";
            this.txt_SenderMail.Size = new System.Drawing.Size(120, 20);
            this.txt_SenderMail.TabIndex = 3;
            // 
            // lbl_SenderName
            // 
            this.lbl_SenderName.AutoSize = true;
            this.lbl_SenderName.Location = new System.Drawing.Point(12, 110);
            this.lbl_SenderName.Name = "lbl_SenderName";
            this.lbl_SenderName.Size = new System.Drawing.Size(121, 13);
            this.lbl_SenderName.TabIndex = 8;
            this.lbl_SenderName.Text = "Pilnas el. pašto adresas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Slaptažodis:";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_SenderName);
            this.Controls.Add(this.txt_SenderMail);
            this.Controls.Add(this.txt_SenderPassword);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_hostname);
            this.Name = "ConnectionForm";
            this.Text = "Prisijungimo Duomenys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_hostname;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_SenderPassword;
        private System.Windows.Forms.TextBox txt_SenderMail;
        private System.Windows.Forms.Label lbl_SenderName;
        private System.Windows.Forms.Label label2;
    }
}

