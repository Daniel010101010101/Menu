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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numero1.Text);
            double b = Convert.ToDouble(numero2.Text);
            double resultado = 0.0;
            if (rdbsumar.Checked == true)
            {
                resultado = a + b;

            }
            if (rdbrestar.Checked == true)
            {
                resultado = a - b;

            }
            if (rdbmultiplicacion.Checked == true)
            {
                resultado = a * b;

            }
            if (rdbdivision.Checked == true)
            {
                resultado = a / b;

            }
            numero3.Text = resultado.ToString();
        }

        private void btnbackcalculator_Click(object sender, EventArgs e)
        {
            Form backform1 = new Menu();
            backform1.Show();
            Close();
        }
    }
}
