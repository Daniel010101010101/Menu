using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bodyMassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form  form1 = new bodymass();
            form1.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new calculator();
            form2.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dateAndTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new DateTime();
            form3.Show();
        }
    }
}
