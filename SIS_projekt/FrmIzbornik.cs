using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            FrmPrijava frmPrijava = new FrmPrijava(this);
            frmPrijava.TopLevel = false;
            frmPrijava.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmPrijava);
            frmPrijava.Show();
        }

        private void btnGeneriranjeKljucaRSA_Click(object sender, EventArgs e)
        {
            panelPrikaz.Controls.Clear();
            FrmGeneriranjeRSA frmGeneriranjeRsa = new FrmGeneriranjeRSA(this);
            frmGeneriranjeRsa.TopLevel = false;
            frmGeneriranjeRsa.FormBorderStyle = FormBorderStyle.None;
            panelPrikaz.Controls.Add(frmGeneriranjeRsa);
            frmGeneriranjeRsa.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            gumbiOdjavljeni();
            File.WriteAllText("../../zadnjiPrijavljeni.txt", "0");
        }

        public void gumbiPrijavljeni()
        {
            btnGeneriranjeKljucaRSA.Visible = true;
            btnKriptiraj.Visible = true;
            btnPosalji.Visible = true;
            btnOdjava.Visible = true;
            btnPrijava.Visible = false;

            labelPrijavljeni.Text = CurrentUser.User.Mail;
            labelPrijavljeni.Visible = true;
        }

        public void gumbiOdjavljeni()
        {
            btnGeneriranjeKljucaRSA.Visible = false;
            btnKriptiraj.Visible = false;
            btnPosalji.Visible = false;
            btnOdjava.Visible = false;
            btnPrijava.Visible = true;

            labelPrijavljeni.Text = "";
            labelPrijavljeni.Visible = false;
        }

        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            string prijavljeni = File.ReadAllText("../../zadnjiPrijavljeni.txt");
            if (prijavljeni == "0")
            {
                gumbiOdjavljeni();
            }
            else
            {
                CurrentUser.User = new CurrentUser(File.ReadAllText("../../zadnjiPrijavljeni.txt"));
                
                gumbiPrijavljeni();
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
