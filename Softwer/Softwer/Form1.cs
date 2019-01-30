using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softwer
{
    public partial class Form1 : Form
    {
        KonekcijaSoftwer ks = new KonekcijaSoftwer();
        public Form1()
        {
            InitializeComponent();
            try
            {
                this.ks.CitajBazu();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska u povezivanju sa bazom!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnCitajBazu_Click(object sender, EventArgs e)
        {
            this.ks.listaSoftwer.Clear();
            try
            {
                this.ks.CitajBazu();
            }
            catch (Exception)
            {
                MessageBox.Show("Greska u povezivanju sa bazom!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbNaziv.Text) && string.IsNullOrEmpty(tbGodinaIzdanja.Text)){
                MessageBox.Show("Polja za naziv i godinu izdanja novog softvera mora biti uneti!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(Convert.ToInt32(tbGodinaIzdanja.Text) < 1900 || Convert.ToInt32(tbGodinaIzdanja.Text) > DateTime.Now.Year){
                MessageBox.Show("Polje za godinu izdanja mora biti unet u periodu od 1900 do tekuce godine!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Softwer s = new Softwer();
            s.Naziv = tbNaziv.Text;
            s.GodinaIzdanja = Convert.ToInt32(tbGodinaIzdanja.Text);
            this.ks.listaSoftwer.Add(s);

            try{
                this.ks.Dodaj(s);
            }
            catch(Exception){
                MessageBox.Show("Greska u komunikaciji sa bazom!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            Dijalog d = new Dijalog();
          
            Softwer[] nizSoftwer = this.ks.listaSoftwer.ToArray();
            StringBuilder s = new StringBuilder();
            StringBuilder i = new StringBuilder();

            foreach(Softwer softwer in nizSoftwer.Where(x => x is Softwer)){
                s.AppendFormat("{0}, {1}, {2}, {3}", softwer.Id, softwer.Naziv, softwer.GodinaIzdanja, softwer.Cena);
                s.AppendLine();
            }
            foreach (Igra igre in nizSoftwer.Where(x => x is Igra))
            {
                s.AppendFormat("{0}, {1}, {2}, {3}, {4}", igre.Id, igre.Naziv, igre.GodinaIzdanja, igre.Cena, igre.Zanr);
                s.AppendLine();
            }
            d.Igre = i.ToString();
            d.Softver = s.ToString();
        }

    }
}
