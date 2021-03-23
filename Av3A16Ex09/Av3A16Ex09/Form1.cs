using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3A16Ex09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTotal.Enabled = false;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int reservas = int.Parse(txtDias.Text);
            string nome = txtNome.Text;
            int total = 0;

            if (reservas < 1)
            {
                MessageBox.Show("Preencha com numeros validos");
            }
            else if (reservas > 0 && reservas < 15)
            {
                total = reservas * 180 + reservas * 15;
                
            }
            else if (reservas > 15)
            {
                total = reservas * 180 + reservas * 10;
            }
            else
            {
                total = reservas * 180 + reservas * 12;
            }
            lblNome.Text = nome;
            txtTotal.Text = total.ToString("C");
        }
    }
}
