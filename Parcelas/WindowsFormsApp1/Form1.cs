using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double vCompra, vEntrada, vParcela;
            int numParcela;

            vCompra = double.Parse(txtcompra.Text);
            vEntrada = double.Parse(txtentrada.Text);
            numParcela = int.Parse(txtparcela.Text);

            if (numParcela <= 5)
            {
                vParcela = (vCompra - vEntrada) / numParcela;
                txtvalorparcela.Text = vParcela.ToString("C");
            }
            else
            {
                MessageBox.Show("O número de parcelas é valido!");
            }
        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            txtcompra.Text = "0";
            txtentrada.Text = "0";
            txtparcela.Text = "0";
            txtvalorparcela.Text = "0";
            
        }

        private void txtcompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnum3_Click(object sender, EventArgs e)
        {

        }
    }
}
