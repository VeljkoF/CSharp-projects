using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpisStudenata
{
    public partial class GlavniProzor : Form
    {
        public GlavniProzor()
        {
            InitializeComponent();
        }

        private List<Student> studenti = new List<Student>(); 

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Dugme je kliknuto", "Upis studenata");
            UnosStudentaDijalog form = new UnosStudentaDijalog();
            if (form.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                Student student = new Student();
                student.Index = new Index(form.IndexRbr, form.IndexGodinaUpisa);
                student.Ime = form.Ime;
                student.Prezime = form.Prezime;
                student.PriznatiESPB = Convert.ToInt32(form.priznatiESPB);
                switch (form.StudentskiProgram)
                {
                    case "Internet tehnologije":
                        student.StudijskiProgram = StudijskiProgram.IT;
                        break;
                    case "Telekomunikacije":
                        student.StudijskiProgram = StudijskiProgram.TK;
                        break;
                    case "Poštansko bankarske usluge":
                        student.StudijskiProgram = StudijskiProgram.PBT;
                        break;
                }
                switch (form.StatusFinansiranja)
                {
                    case 0:
                        student.StatusFInansiranja = StudentStatusFinansiranja.Budzet;
                        break;
                    case 1:
                        student.StatusFInansiranja = StudentStatusFinansiranja.Samofinansiranje;
                        break;
                }
                student.DatumRodjenje = form.DatumRodjenja;
                studenti.Add(student);

                IspisiStudente(this.studenti);
                //string ime = form.Ime;
            }
            //MessageBox.Show("Dugme je kliknuto", "Upis studenata");
        }

        private void IspisiStudente(List<Student> studentiLista)
        {
            tbStudenti.Text = "";
            string textIspisa = "";
            foreach (Student student in studentiLista)
            {
                textIspisa += student.Ime + student.Prezime + Environment.NewLine;
                
            }
            tbStudenti.Text += textIspisa;
        }
    }
}
//Izaberi...
//Internet tehnologije
//Telekomunikacije
//Poštansko bankarske usluge