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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            panelPrikaz.Controls.Clear();
            Simetricno frmSimetricno = new Simetricno();
            frmSimetricno.TopLevel = false;
            frmSimetricno.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmSimetricno);
            frmSimetricno.Show();

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            panelPrikaz.Controls.Clear();
            FrmSend frmSend = new FrmSend();
            frmSend.TopLevel = false;
            frmSend.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmSend);
            frmSend.Show();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            panelPrikaz.Controls.Clear();
            FrmPrijava frmPrijava = new FrmPrijava();
            frmPrijava.TopLevel = false;
            frmPrijava.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmPrijava);
            frmPrijava.Show();
        }

        private void btnGeneriranjeKljucaRSA_Click(object sender, EventArgs e)
        {
            panelPrikaz.Controls.Clear();
            FrmGeneriranjeRSA frmGeneriranjeRsa = new FrmGeneriranjeRSA();
            frmGeneriranjeRsa.TopLevel = false;
            frmGeneriranjeRsa.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmGeneriranjeRsa);
            frmGeneriranjeRsa.Show();
        }
    }
}
