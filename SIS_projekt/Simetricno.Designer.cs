namespace SIS_projekt
{
    partial class Simetricno
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
            this.btnGenerirajKljuc = new System.Windows.Forms.Button();
            this.generiraniKljuctxt = new System.Windows.Forms.TextBox();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.ucitaniTeksttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdabirDatoteke
            // 
            this.btnOdabirDatoteke.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOdabirDatoteke.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdabirDatoteke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdabirDatoteke.Location = new System.Drawing.Point(29, 55);
            this.btnOdabirDatoteke.Name = "btnOdabirDatoteke";
            this.btnOdabirDatoteke.Size = new System.Drawing.Size(225, 44);
            this.btnOdabirDatoteke.TabIndex = 3;
            this.btnOdabirDatoteke.Text = "Odabir datoteke";
            this.btnOdabirDatoteke.UseVisualStyleBackColor = false;
            this.btnOdabirDatoteke.Click += new System.EventHandler(this.btnOdabirDatoteke_Click);
            // 
            // nazivDatoteketxt
            // 
            this.nazivDatoteketxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivDatoteketxt.Location = new System.Drawing.Point(276, 62);
            this.nazivDatoteketxt.Name = "nazivDatoteketxt";
            this.nazivDatoteketxt.ReadOnly = true;
            this.nazivDatoteketxt.Size = new System.Drawing.Size(662, 31);
            this.nazivDatoteketxt.TabIndex = 4;
            // 
            // btnGenerirajKljuc
            // 
            this.btnGenerirajKljuc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerirajKljuc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajKljuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerirajKljuc.Location = new System.Drawing.Point(29, 126);
            this.btnGenerirajKljuc.Name = "btnGenerirajKljuc";
            this.btnGenerirajKljuc.Size = new System.Drawing.Size(225, 44);
            this.btnGenerirajKljuc.TabIndex = 5;
            this.btnGenerirajKljuc.Text = "Generiraj tajni ključ";
            this.btnGenerirajKljuc.UseVisualStyleBackColor = false;
            this.btnGenerirajKljuc.Click += new System.EventHandler(this.btnGenerirajKljuc_Click);
            // 
            // generiraniKljuctxt
            // 
            this.generiraniKljuctxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generiraniKljuctxt.Location = new System.Drawing.Point(276, 133);
            this.generiraniKljuctxt.Name = "generiraniKljuctxt";
            this.generiraniKljuctxt.ReadOnly = true;
            this.generiraniKljuctxt.Size = new System.Drawing.Size(662, 31);
            this.generiraniKljuctxt.TabIndex = 6;
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnKriptiraj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKriptiraj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKriptiraj.Location = new System.Drawing.Point(339, 228);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(272, 44);
            this.btnKriptiraj.TabIndex = 7;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = false;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // ucitaniTeksttxt
            // 
            this.ucitaniTeksttxt.Location = new System.Drawing.Point(43, 382);
            this.ucitaniTeksttxt.Multiline = true;
            this.ucitaniTeksttxt.Name = "ucitaniTeksttxt";
            this.ucitaniTeksttxt.ReadOnly = true;
            this.ucitaniTeksttxt.Size = new System.Drawing.Size(874, 267);
            this.ucitaniTeksttxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Učitani tekst";
            // 
            // Simetricno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(969, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucitaniTeksttxt);
            this.Controls.Add(this.btnKriptiraj);
            this.Controls.Add(this.generiraniKljuctxt);
            this.Controls.Add(this.btnGenerirajKljuc);
            this.Controls.Add(this.nazivDatoteketxt);
            this.Controls.Add(this.btnOdabirDatoteke);
            this.Name = "Simetricno";
            this.Text = "Simetricno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdabirDatoteke;
        private System.Windows.Forms.TextBox nazivDatoteketxt;
        private System.Windows.Forms.Button btnGenerirajKljuc;
        private System.Windows.Forms.TextBox generiraniKljuctxt;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.TextBox ucitaniTeksttxt;
        private System.Windows.Forms.Label label1;
    }
}