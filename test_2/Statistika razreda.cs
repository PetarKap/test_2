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
    public partial class Statistika_razreda : Form
    {
        public Statistika_razreda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstStats.Items.Clear();
            List<Student> students = Admin.GetCountByRazred();
            foreach (Student s in students)
            {
                lstStats.Items.Add(s);

            }
        }
    }
}
