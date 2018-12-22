namespace SIS_projekt
{
    partial class FrmSend
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
            this.btnOdabirDatoteke = new System.Windows.Forms.Button();
            this.nazivDatoteketxt = new System.Windows.Forms.TextBox();
            this.cmbPrimatelji = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoviMail = new System.Windows.Forms.TextBox();
            this.btnDodajNoviMail = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdabirDatoteke
            // 
            this.btnOdabirDatoteke.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOdabirDatoteke.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdabirDatoteke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdabirDatoteke.Location = new System.Drawing.Point(32, 55);
            this.btnOdabirDatoteke.Name = "btnOdabirDatoteke";
            this.btnOdabirDatoteke.Size = new System.Drawing.Size(225, 60);
            this.btnOdabirDatoteke.TabIndex = 4;
            this.btnOdabirDatoteke.Text = "Odabir kriptirane datoteke";
            this.btnOdabirDatoteke.UseVisualStyleBackColor = false;
            this.btnOdabirDatoteke.Click += new System.EventHandler(this.btnOdabirDatoteke_Click);
            // 
            // nazivDatoteketxt
            // 
            this.nazivDatoteketxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivDatoteketxt.Location = new System.Drawing.Point(279, 70);
            this.nazivDatoteketxt.Name = "nazivDatoteketxt";
            this.nazivDatoteketxt.ReadOnly = true;
            this.nazivDatoteketxt.Size = new System.Drawing.Size(662, 31);
            this.nazivDatoteketxt.TabIndex = 5;
            // 
            // cmbPrimatelji
            // 
            this.cmbPrimatelji.FormattingEnabled = true;
            this.cmbPrimatelji.Location = new System.Drawing.Point(162, 196);
            this.cmbPrimatelji.Name = "cmbPrimatelji";
            this.cmbPrimatelji.Size = new System.Drawing.Size(377, 24);
            this.cmbPrimatelji.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail primatelja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Upiši novi mail";
            // 
            // txtNoviMail
            // 
            this.txtNoviMail.Location = new System.Drawing.Point(162, 248);
            this.txtNoviMail.Name = "txtNoviMail";
            this.txtNoviMail.Size = new System.Drawing.Size(377, 22);
            this.txtNoviMail.TabIndex = 9;
            // 
            // btnDodajNoviMail
            // 
            this.btnDodajNoviMail.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDodajNoviMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNoviMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajNoviMail.Location = new System.Drawing.Point(603, 233);
            this.btnDodajNoviMail.Name = "btnDodajNoviMail";
            this.btnDodajNoviMail.Size = new System.Drawing.Size(225, 46);
            this.btnDodajNoviMail.TabIndex = 10;
            this.btnDodajNoviMail.Text = "Dodaj novi mail";
            this.btnDodajNoviMail.UseVisualStyleBackColor = false;
            this.btnDodajNoviMail.Click += new System.EventHandler(this.btnDodajNoviMail_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.IndianRed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(359, 409);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(225, 46);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FrmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(966, 598);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDodajNoviMail);
            this.Controls.Add(this.txtNoviMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrimatelji);
            this.Controls.Add(this.nazivDatoteketxt);
            this.Controls.Add(this.btnOdabirDatoteke);
            this.Name = "FrmSend";
            this.Text = "FrmSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdabirDatoteke;
        private System.Windows.Forms.TextBox nazivDatoteketxt;
        private System.Windows.Forms.ComboBox cmbPrimatelji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoviMail;
        private System.Windows.Forms.Button btnDodajNoviMail;
        private System.Windows.Forms.Button btnSend;
    }
}