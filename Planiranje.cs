using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Planiranje : Form
    {
        public Planiranje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void izlaz(object sender, EventArgs e)
        {
            this.Hide();
            Ulaz otvori = new Ulaz();
            otvori.Show();
        }
    }
}
