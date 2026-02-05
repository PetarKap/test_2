using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unos_učenika unos = new Unos_učenika();
            unos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prikaz_učenika prikaz = new Prikaz_učenika();
            prikaz.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistika_razreda statistika = new Statistika_razreda();
            statistika.ShowDialog();
        }
    }
}
