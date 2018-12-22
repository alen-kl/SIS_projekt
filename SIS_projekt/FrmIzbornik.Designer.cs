namespace SIS_projekt
{
    partial class FrmIzbornik
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
            this.panelIzbornik = new System.Windows.Forms.Panel();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnGeneriranjeKljucaRSA = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrikaz = new System.Windows.Forms.Panel();
            this.panelIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzbornik
            // 
            this.panelIzbornik.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelIzbornik.Controls.Add(this.btnPosalji);
            this.panelIzbornik.Controls.Add(this.btnKriptiraj);
            this.panelIzbornik.Controls.Add(this.btnGeneriranjeKljucaRSA);
            this.panelIzbornik.Controls.Add(this.btnPrijava);
            this.panelIzbornik.Controls.Add(this.label1);
            this.panelIzbornik.Location = new System.Drawing.Point(0, 0);
            this.panelIzbornik.Name = "panelIzbornik";
            this.panelIzbornik.Size = new System.Drawing.Size(200, 722);
            this.panelIzbornik.TabIndex = 0;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPosalji.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(22, 451);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(160, 50);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKriptiraj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKriptiraj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKriptiraj.Location = new System.Drawing.Point(22, 373);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(160, 50);
            this.btnKriptiraj.TabIndex = 3;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = false;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // btnGeneriranjeKljucaRSA
            // 
            this.btnGeneriranjeKljucaRSA.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGeneriranjeKljucaRSA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGeneriranjeKljucaRSA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneriranjeKljucaRSA.Location = new System.Drawing.Point(22, 123);
            this.btnGeneriranjeKljucaRSA.Name = "btnGeneriranjeKljucaRSA";
            this.btnGeneriranjeKljucaRSA.Size = new System.Drawing.Size(160, 59);
            this.btnGeneriranjeKljucaRSA.TabIndex = 2;
            this.btnGeneriranjeKljucaRSA.Text = "Generiranje ključa (RSA)";
            this.btnGeneriranjeKljucaRSA.UseVisualStyleBackColor = false;
            this.btnGeneriranjeKljucaRSA.Click += new System.EventHandler(this.btnGeneriranjeKljucaRSA_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrijava.Location = new System.Drawing.Point(22, 50);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(160, 50);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - - - - - - - - - - -";
            // 
            // panelPrikaz
            // 
            this.panelPrikaz.Location = new System.Drawing.Point(200, 0);
            this.panelPrikaz.Name = "panelPrikaz";
            this.panelPrikaz.Size = new System.Drawing.Size(987, 722);
            this.panelPrikaz.TabIndex = 1;
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1191, 721);
            this.Controls.Add(this.panelPrikaz);
            this.Controls.Add(this.panelIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.panelIzbornik.ResumeLayout(false);
            this.panelIzbornik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Panel panelPrikaz;
        private System.Windows.Forms.Button btnGeneriranjeKljucaRSA;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnKriptiraj;
    }
}

