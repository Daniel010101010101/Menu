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
    public partial class bodymass : Form
    {
        public bodymass()
        {
            InitializeComponent();
        }

        private void btnbmi_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(txtheight.Text);
            double w = Convert.ToDouble(txtweight.Text);
            double BMI;

            BMI = w / (h * h);

            txtbmi.Text = Convert.ToString(BMI);
            if (BMI < 18)
            {
                this.lblr.Text = "You are skinny";
            }
            else if (BMI >= 18 && BMI < 25)
            {
                this.lblr.Text = "Your weight is normal";
            }
            else if (BMI >= 25 && BMI < 27)
            {
                this.lblr.Text = "You are overweight";
            }
            else if (BMI >= 27)
            {
                this.lblr.Text = "you have obesity";
            }
        }

        private void btnbackBmi_Click(object sender, EventArgs e)
        {
            Form backform1 = new Menu();
            backform1.Show();
            Close();
        }
    }
}
