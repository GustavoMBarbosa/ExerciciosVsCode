using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3A16Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtresultado.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ano, mes, dia, resultado;
            ano = int.Parse(txtano.Text);
            mes = int.Parse(txtmes.Text);
            dia = int.Parse(txtdia.Text);
            resultado = int.Parse(txtresultado.Text);
            
            while (ano > 0)
            {
                
                resultado = resultado + 350;
                ano = ano - 1;
            }
             while (mes > 0)
            {
                
                resultado = resultado + 30;
                mes = mes - 1;
            }
            while (dia > 0)
            {
                
                resultado = resultado + 1;
                dia = dia - 1;
            }
            txtresultado.Text = resultado.ToString();
            
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtano.Text = "0";
            txtmes.Text = "0";
            txtdia.Text = "0";
            txtresultado.Text = "0";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
