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
    public partial class UnosStudentaDijalog : Form
    {
        public UnosStudentaDijalog()
        {
            InitializeComponent();
            this.ddlStudiskiProgram.SelectedIndex = 0;
        }

        public string Ime
        {
            get
            {
                return this.tbIme.Text;
            }
            //set
            //{
            //    this.tbIme.Text = value;
            //}
        }
        public string Prezime
        {
            get
            {
                return this.tbPrezime.Text;
            }
            //set
            //{
            //    this.tbPrezime.Text = value;
            //}
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return this.dtpDatumRodjenja.Value;
            }
            //set
            //{
            //    this.dtpDatumRodjenja.Value = value;
            //}
        }
        public string  StudentskiProgram
        {
            get
            {
                return this.ddlStudiskiProgram.SelectedItem as string;
            }
            //set
            //{
            //    this.ddlStudiskiProgram.SelectedItem = ddlStudiskiProgram.SelectedItem;
            //}
        }
        public int StatusFinansiranja
        {
            get
            {
                return this.rbBudzet.Checked ? 0 : 1;
            }
        }
        public decimal priznatiESPB
        {
            get
            {
                return this.nudEspb.Value;
            }
        }
        public int IndexRbr
        {
            get
            {
                string[] komponente = this.mtbIndex.Text.Split('/');
                return int.Parse(komponente[0]);
            }
        }
        public int IndexGodinaUpisa
        {
            get
            {
                string[] komponente = this.mtbIndex.Text.Split('/');
                return int.Parse(komponente[1]);
            }
        }
    }
}
