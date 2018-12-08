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
            this.panelPrikaz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelIzbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzbornik
            // 
            this.panelIzbornik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelIzbornik.Controls.Add(this.button1);
            this.panelIzbornik.Controls.Add(this.btnPrijava);
            this.panelIzbornik.Controls.Add(this.label1);
            this.panelIzbornik.Location = new System.Drawing.Point(0, 0);
            this.panelIzbornik.Name = "panelIzbornik";
            this.panelIzbornik.Size = new System.Drawing.Size(200, 722);
            this.panelIzbornik.TabIndex = 0;
            // 
            // panelPrikaz
            // 
            this.panelPrikaz.Location = new System.Drawing.Point(200, 0);
            this.panelPrikaz.Name = "panelPrikaz";
            this.panelPrikaz.Size = new System.Drawing.Size(806, 722);
            this.panelPrikaz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "- - - - - - - - - - - -";
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(34, 66);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(99, 41);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generiranje knjuča (RSA)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelPrikaz);
            this.Controls.Add(this.panelIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIzbornik";
            this.Text = "Form1";
            this.panelIzbornik.ResumeLayout(false);
            this.panelIzbornik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Panel panelPrikaz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label label1;
    }
}

