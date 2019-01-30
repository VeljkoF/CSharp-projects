using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakti
{
    public partial class FKontakti : Form
    {
        KolekcijaKontakata kolekcija = new KolekcijaKontakata();
        public FKontakti()
        {
            InitializeComponent();
            try
            {
                this.kolekcija.CitajBazu();
            }
            catch (Exception)
            {

                MessageBox.Show("Nije ucitana baza", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            this.PopuniZaposlene();

        }

        private void PopuniZaposlene()
        {
            int broj = kolekcija.listaKontakat.Count;
            this.BrKontakta.Text = broj.ToString("0");
        }

        private void FKontakti_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da izađete?", "Preduzeće",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true; 
            

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
