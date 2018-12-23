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
    public partial class FrmGeneriranjeRSA : Form
    {
        private FrmIzbornik parent;
        public FrmGeneriranjeRSA(FrmIzbornik izbornik)
        {
            InitializeComponent();
            parent = izbornik;
            labelSmile.Visible = false;
            labelUspjesnoGeneriran.Visible = false;
        }

        private void btnGenerirajNoviKljucRSA_Click(object sender, EventArgs e)
        {
            RSA r = new RSA();
            r.spremiNoviKljuc(parent.korisnik.Mail);
            /**/
            labelSmile.Visible = true;
            labelUspjesnoGeneriran.Visible = true;
          
        }
    }
}
