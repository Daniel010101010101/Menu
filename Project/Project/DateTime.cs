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
    public partial class DateTime : Form
    {
        public static object Now { get; private set; }

        public DateTime()
        {
            InitializeComponent();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
           

        }

        private void btnbackdate_Click(object sender, EventArgs e)
        {
            Form backform1 = new Menu();
            backform1.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hour_Click(object sender, EventArgs e)
        {
            string tiempo = DateTime.Now.ToString();
            label4hou.Text = tiempo;
        }
    }
}
