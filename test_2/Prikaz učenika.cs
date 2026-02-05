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
    public partial class Prikaz_učenika : Form
    {
        public Prikaz_učenika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstUcenici.Items.Clear();
            string name = textBox1.Text;
            List <string> names = Admin.SearhByName(name);
            foreach (string s in names)
            {
                lstUcenici.Items.Add(s);
            }
        }
    }
}
