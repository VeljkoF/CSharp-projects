using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form1 : Form
    {
        KonekcijaOsoba ko = new KonekcijaOsoba();

        public Form1()
        {
            InitializeComponent();
            try
            {
                this.ko.CitajBazu();
            }
            catch (Exception)
            {
                MessageBox.Show("Gresak u citanju baze!!!", "Greska");
            }
        }

        private void btnCitajBazu_Click(object sender, EventArgs e)
        {
            this.ko.ListaOsoba.Clear();
            try
            {
                this.ko.CitajBazu();
            }
            catch (Exception)
            {
                MessageBox.Show("Gresak u citanju baze!!!", "Greska");
            }
        }

        private void btnObrisiOsobe_Click(object sender, EventArgs e)
        {   

            if (MessageBox.Show("Da li ste sigurni da zelite da obrisete podatke o studentima?", "Obavestenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.ko.ObrisiOsobe();
                }
                catch (Exception)
                {
                    MessageBox.Show("Gresak u citanju baze!!!", "Greska");
                }
            }
        }

        private void btnPrikaziStudente_Click(object sender, EventArgs e)
        {
            Student[] nizStudenata = this.ko.PrikaziStudente();

            StringBuilder s = new StringBuilder();

            int duzina = nizStudenata.Length;

            for (int i = 0; i < duzina; i++)
            {
                if (i != duzina - 1)
                {
                    s.AppendLine(i + 1 + ". " + nizStudenata[i].ToString());
                }
                else
                {
                    s.Append(i + 1 + ". " + nizStudenata[i].ToString());
                }
            }
            Studenti prozor = new Studenti();
            prozor.PrikazStudentata = s.ToString();
            prozor.ShowDialog();



        }
    }
}
