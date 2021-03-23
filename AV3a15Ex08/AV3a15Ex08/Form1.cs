using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV3a15Ex08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtmaior.Enabled = false;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);
            int maior = 0;

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                MessageBox.Show("Os numeros deve ser destindos!");
            }
            else if (num2 < num1 && num3 < num1)
            {
                txtmaior.Text = num1.ToString();
            }
            else if (num1 < num2 && num3 < num2)
            {
                txtmaior.Text = num2.ToString();
            }
            else if (num1 < num3 && num2 < num3)
            {
                txtmaior.Text = num3.ToString();
            }
            else
                MessageBox.Show("Error");
            {

            }
        }
    }
}
