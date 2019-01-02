namespace SIS_projekt
{
    partial class FrmPreuzimanje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOsvjeziPoruke = new System.Windows.Forms.Button();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.txtDekriptirano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOsvjeziPoruke
            // 
            this.btnOsvjeziPoruke.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOsvjeziPoruke.BackgroundImage = global::SIS_projekt.Properties.Resources.Refresh_icon;
            this.btnOsvjeziPoruke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOsvjeziPoruke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjeziPoruke.Location = new System.Drawing.Point(905, 12);
            this.btnOsvjeziPoruke.Name = "btnOsvjeziPoruke";
            this.btnOsvjeziPoruke.Size = new System.Drawing.Size(52, 48);
            this.btnOsvjeziPoruke.TabIndex = 1;
            this.btnOsvjeziPoruke.UseVisualStyleBackColor = false;
            this.btnOsvjeziPoruke.Click += new System.EventHandler(this.btnOsvjeziPoruke_Click);
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPreuzmi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPreuzmi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreuzmi.Location = new System.Drawing.Point(12, 441);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(212, 44);
            this.btnPreuzmi.TabIndex = 5;
            this.btnPreuzmi.Text = "Preuzmi i dekriptiraj";
            this.btnPreuzmi.UseVisualStyleBackColor = false;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AllowUserToDeleteRows = false;
            this.dgvPoruke.AllowUserToResizeColumns = false;
            this.dgvPoruke.AllowUserToResizeRows = false;
            this.dgvPoruke.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvPoruke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPoruke.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPoruke.Location = new System.Drawing.Point(7, 66);
            this.dgvPoruke.MultiSelect = false;
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.ReadOnly = true;
            this.dgvPoruke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPoruke.RowTemplate.Height = 24;
            this.dgvPoruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoruke.Size = new System.Drawing.Size(950, 369);
            this.dgvPoruke.TabIndex = 6;
            // 
            // txtDekriptirano
            // 
            this.txtDekriptirano.Location = new System.Drawing.Point(12, 507);
            this.txtDekriptirano.Multiline = true;
            this.txtDekriptirano.Name = "txtDekriptirano";
            this.txtDekriptirano.ReadOnly = true;
            this.txtDekriptirano.Size = new System.Drawing.Size(945, 156);
            this.txtDekriptirano.TabIndex = 7;
            // 
            // FrmPreuzimanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(969, 675);
            this.Controls.Add(this.txtDekriptirano);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.btnOsvjeziPoruke);
            this.Name = "FrmPreuzimanje";
            this.Text = "FrmPreuzimanje";
            this.Load += new System.EventHandler(this.FrmPreuzimanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOsvjeziPoruke;
        private System.Windows.Forms.Button btnPreuzmi;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.TextBox txtDekriptirano;
    }
}