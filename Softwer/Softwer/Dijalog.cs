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
    public partial class Dijalog : Form
    {
        public Dijalog()
        {
            InitializeComponent();
            this.ShowDialog();
        }
        public string Igre
        {
            get
            {
                return this.tbIgre.Text;
            }
            set
            {
                this.tbIgre.Text = value;
            }
        }
        public string Softver
        {
            get
            {
                return this.tbSoftwer.Text;
            }
            set
            {
                this.tbSoftwer.Text = value;
            }
        }
    }
}
