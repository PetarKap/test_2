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
    public partial class Unos_učenika : Form
    {
        public Unos_učenika()
        {
            InitializeComponent();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zapis = $"{txtIme.Text}|{txtPrezime.Text}|{dateTimePicker1.Text}|{Razred.Text}|{checkBox1.Text}|{numericUpDown1.Text}";
            Admin.SaveStudents(zapis);
             MessageBox.Show("Učenik uspješno unesen!");
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
