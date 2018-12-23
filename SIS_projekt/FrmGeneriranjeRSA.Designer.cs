namespace SIS_projekt
{
    partial class FrmGeneriranjeRSA
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
            this.btnGenerirajNoviKljucRSA = new System.Windows.Forms.Button();
            this.labelUspjesnoGeneriran = new System.Windows.Forms.Label();
            this.labelSmile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generiranje RSA tajnog i javnog ključa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "*NAPOMENA: generiranjem novih RSA ključeva, Vaši trenutni ključevi bit će izbrisa" +
    "ni, ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "stoga neće više biti moguće dekriptirati eventualno poslane datoteke";
            // 
            // btnGenerirajNoviKljucRSA
            // 
            this.btnGenerirajNoviKljucRSA.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGenerirajNoviKljucRSA.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerirajNoviKljucRSA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerirajNoviKljucRSA.Location = new System.Drawing.Point(367, 137);
            this.btnGenerirajNoviKljucRSA.Name = "btnGenerirajNoviKljucRSA";
            this.btnGenerirajNoviKljucRSA.Size = new System.Drawing.Size(212, 81);
            this.btnGenerirajNoviKljucRSA.TabIndex = 5;
            this.btnGenerirajNoviKljucRSA.Text = "Generiraj";
            this.btnGenerirajNoviKljucRSA.UseVisualStyleBackColor = false;
            this.btnGenerirajNoviKljucRSA.Click += new System.EventHandler(this.btnGenerirajNoviKljucRSA_Click);
            // 
            // labelUspjesnoGeneriran
            // 
            this.labelUspjesnoGeneriran.AutoSize = true;
            this.labelUspjesnoGeneriran.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUspjesnoGeneriran.Location = new System.Drawing.Point(400, 307);
            this.labelUspjesnoGeneriran.Name = "labelUspjesnoGeneriran";
            this.labelUspjesnoGeneriran.Size = new System.Drawing.Size(377, 32);
            this.labelUspjesnoGeneriran.TabIndex = 6;
            this.labelUspjesnoGeneriran.Text = "ključevi su generirani i spremljeni";
            // 
            // labelSmile
            // 
            this.labelSmile.AutoSize = true;
            this.labelSmile.Font = new System.Drawing.Font("Segoe UI Semibold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmile.ForeColor = System.Drawing.Color.LightGreen;
            this.labelSmile.Location = new System.Drawing.Point(295, 282);
            this.labelSmile.Name = "labelSmile";
            this.labelSmile.Size = new System.Drawing.Size(56, 65);
            this.labelSmile.TabIndex = 7;
            this.labelSmile.Text = ":)";
            // 
            // FrmGeneriranjeRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(969, 675);
            this.Controls.Add(this.labelSmile);
            this.Controls.Add(this.labelUspjesnoGeneriran);
            this.Controls.Add(this.btnGenerirajNoviKljucRSA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGeneriranjeRSA";
            this.Text = "FrmGeneriranjeRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerirajNoviKljucRSA;
        private System.Windows.Forms.Label labelUspjesnoGeneriran;
        private System.Windows.Forms.Label labelSmile;
    }
}