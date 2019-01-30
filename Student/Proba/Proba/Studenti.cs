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
    public partial class Studenti : Form
    {
        public string  PrikazStudentata
        {
            get
            {
                return tbPrikaziStudente.Text;
            }
            set
            {
                tbPrikaziStudente.Text = value;
            }
        }
        public Studenti()
        {
            InitializeComponent();
        }
    }
}
