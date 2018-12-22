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
    }
}
