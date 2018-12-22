using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS_projekt
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }

        private void radioMail_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMail.Checked == true)
            {
                txtMail.Enabled = true;
                txtKorIme.Enabled = false;

            }
        }

        private void radioKorIme_CheckedChanged(object sender, EventArgs e)
        {
            txtMail.Enabled = false;
            txtKorIme.Enabled = true;
        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {
            txtKorIme.Enabled = false;
        }

        private void tnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija frmRegistracija = new FrmRegistracija();
            frmRegistracija.ShowDialog();
        }
    }
}
