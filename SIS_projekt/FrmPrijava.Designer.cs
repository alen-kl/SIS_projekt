namespace SIS_projekt
{
    partial class FrmPrijava
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.radioMail = new System.Windows.Forms.RadioButton();
            this.radioKorIme = new System.Windows.Forms.RadioButton();
            this.tnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lozinka";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(378, 135);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(212, 34);
            this.txtMail.TabIndex = 1;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Enabled = false;
            this.txtKorIme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorIme.Location = new System.Drawing.Point(378, 211);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(212, 34);
            this.txtKorIme.TabIndex = 2;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.Location = new System.Drawing.Point(378, 339);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '¤';
            this.txtLozinka.Size = new System.Drawing.Size(212, 34);
            this.txtLozinka.TabIndex = 3;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviSe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrijaviSe.Location = new System.Drawing.Point(378, 484);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(212, 44);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // radioMail
            // 
            this.radioMail.AutoSize = true;
            this.radioMail.Checked = true;
            this.radioMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMail.Location = new System.Drawing.Point(116, 145);
            this.radioMail.Name = "radioMail";
            this.radioMail.Size = new System.Drawing.Size(17, 16);
            this.radioMail.TabIndex = 6;
            this.radioMail.TabStop = true;
            this.radioMail.UseVisualStyleBackColor = true;
            this.radioMail.CheckedChanged += new System.EventHandler(this.radioMail_CheckedChanged);
            // 
            // radioKorIme
            // 
            this.radioKorIme.AutoSize = true;
            this.radioKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioKorIme.Location = new System.Drawing.Point(116, 220);
            this.radioKorIme.Name = "radioKorIme";
            this.radioKorIme.Size = new System.Drawing.Size(17, 16);
            this.radioKorIme.TabIndex = 7;
            this.radioKorIme.UseVisualStyleBackColor = true;
            this.radioKorIme.CheckedChanged += new System.EventHandler(this.radioKorIme_CheckedChanged);
            // 
            // tnRegistracija
            // 
            this.tnRegistracija.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tnRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tnRegistracija.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnRegistracija.Location = new System.Drawing.Point(677, 616);
            this.tnRegistracija.Name = "tnRegistracija";
            this.tnRegistracija.Size = new System.Drawing.Size(243, 35);
            this.tnRegistracija.TabIndex = 5;
            this.tnRegistracija.Text = "Registracija";
            this.tnRegistracija.UseVisualStyleBackColor = false;
            this.tnRegistracija.Click += new System.EventHandler(this.tnRegistracija_Click);
            // 
            // FrmPrijava
            // 
            this.AcceptButton = this.btnPrijaviSe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(969, 675);
            this.Controls.Add(this.tnRegistracija);
            this.Controls.Add(this.radioKorIme);
            this.Controls.Add(this.radioMail);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrijava";
            this.Text = "FrmPrijava";
            this.Load += new System.EventHandler(this.FrmPrijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.RadioButton radioMail;
        private System.Windows.Forms.RadioButton radioKorIme;
        private System.Windows.Forms.Button tnRegistracija;
    }
}