namespace SMTP
{
    partial class MailForm
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
            this.lbl_Rcpt = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.txt_Rcpt = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Rcpt
            // 
            this.lbl_Rcpt.AutoSize = true;
            this.lbl_Rcpt.Location = new System.Drawing.Point(12, 12);
            this.lbl_Rcpt.Name = "lbl_Rcpt";
            this.lbl_Rcpt.Size = new System.Drawing.Size(92, 13);
            this.lbl_Rcpt.TabIndex = 0;
            this.lbl_Rcpt.Text = "Gavėjo el. paštas:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(12, 46);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(37, 13);
            this.lbl_Subject.TabIndex = 1;
            this.lbl_Subject.Text = "Tema:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(197, 226);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "Siųsti";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 226);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Atšaukti";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(15, 87);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(257, 133);
            this.txt_Message.TabIndex = 4;
            // 
            // txt_Rcpt
            // 
            this.txt_Rcpt.Location = new System.Drawing.Point(110, 9);
            this.txt_Rcpt.Name = "txt_Rcpt";
            this.txt_Rcpt.Size = new System.Drawing.Size(162, 20);
            this.txt_Rcpt.TabIndex = 5;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(110, 43);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(162, 20);
            this.txt_Subject.TabIndex = 6;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_Rcpt);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_Subject);
            this.Controls.Add(this.lbl_Rcpt);
            this.Name = "MailForm";
            this.Text = "Elektroninis laiškas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Rcpt;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.TextBox txt_Rcpt;
        private System.Windows.Forms.TextBox txt_Subject;
    }
}