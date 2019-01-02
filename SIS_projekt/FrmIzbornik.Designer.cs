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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzbornik));
            this.panelIzbornik = new System.Windows.Forms.Panel();
            this.btnPreuzimanje = new System.Windows.Forms.Button();
            this.labelPrijavljeni = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnGeneriranjeKljucaRSA = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.panelPrikaz = new System.Windows.Forms.Panel();
            this.panelIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzbornik
            // 
            this.panelIzbornik.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelIzbornik.Controls.Add(this.btnPreuzimanje);
            this.panelIzbornik.Controls.Add(this.labelPrijavljeni);
            this.panelIzbornik.Controls.Add(this.btnIzlaz);
            this.panelIzbornik.Controls.Add(this.btnOdjava);
            this.panelIzbornik.Controls.Add(this.btnPosalji);
            this.panelIzbornik.Controls.Add(this.btnKriptiraj);
            this.panelIzbornik.Controls.Add(this.btnGeneriranjeKljucaRSA);
            this.panelIzbornik.Controls.Add(this.btnPrijava);
            this.panelIzbornik.Location = new System.Drawing.Point(0, 0);
            this.panelIzbornik.Name = "panelIzbornik";
            this.panelIzbornik.Size = new System.Drawing.Size(200, 722);
            this.panelIzbornik.TabIndex = 0;
            // 
            // btnPreuzimanje
            // 
            this.btnPreuzimanje.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPreuzimanje.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreuzimanje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreuzimanje.Location = new System.Drawing.Point(22, 434);
            this.btnPreuzimanje.Name = "btnPreuzimanje";
            this.btnPreuzimanje.Size = new System.Drawing.Size(160, 50);
            this.btnPreuzimanje.TabIndex = 8;
            this.btnPreuzimanje.Text = "Preuzmi";
            this.btnPreuzimanje.UseVisualStyleBackColor = false;
            this.btnPreuzimanje.Click += new System.EventHandler(this.btnPreuzimanje_Click);
            // 
            // labelPrijavljeni
            // 
            this.labelPrijavljeni.AutoSize = true;
            this.labelPrijavljeni.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrijavljeni.Location = new System.Drawing.Point(3, 9);
            this.labelPrijavljeni.Name = "labelPrijavljeni";
            this.labelPrijavljeni.Size = new System.Drawing.Size(69, 23);
            this.labelPrijavljeni.TabIndex = 7;
            this.labelPrijavljeni.Text = "korisnik";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzlaz.Location = new System.Drawing.Point(22, 659);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(160, 50);
            this.btnIzlaz.TabIndex = 6;
            this.btnIzlaz.Text = "IZLAZ";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOdjava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.Location = new System.Drawing.Point(22, 603);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(160, 50);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPosalji.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPosalji.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(22, 351);
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
            this.btnKriptiraj.Location = new System.Drawing.Point(22, 271);
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
            this.btnGeneriranjeKljucaRSA.Location = new System.Drawing.Point(22, 180);
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
            this.btnPrijava.Location = new System.Drawing.Point(22, 603);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(160, 50);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIzbornik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbornik";
            this.Load += new System.EventHandler(this.FrmIzbornik_Load);
            this.panelIzbornik.ResumeLayout(false);
            this.panelIzbornik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Panel panelPrikaz;
        private System.Windows.Forms.Button btnGeneriranjeKljucaRSA;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label labelPrijavljeni;
        private System.Windows.Forms.Button btnPreuzimanje;
    }
}

