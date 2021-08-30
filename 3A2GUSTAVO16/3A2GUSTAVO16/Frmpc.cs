using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3A2GUSTAVO16
{
    public partial class Frmpc : Form
    {
        computador objPC = new computador();
        public Frmpc()
        {
            InitializeComponent();
            txtid.Enabled = false;
            dtgcomputador.DataSource = objPC.ListarPC();
        }

        private void Frmpc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            objPC.nomePC = txtnome.Text;
            objPC.memoriaPC = txtmemoria.Text;
            objPC.discoPC = txtdisco.Text;
            objPC.processadorPC = txtprocessador.Text;
            objPC.marcaPC = txtmarca.Text;
            objPC.placaPC = txtplaca.Text;
            objPC.anoPC = int.Parse(txtano.Text);
            objPC.statusPC = cbbstatus.Text;
            objPC.tipoPC = txtdefeito.Text;
            objPC.CadastroPC();
            MessageBox.Show("Computador Cadastrado");

            txtnome.Clear();
            txtmemoria.Clear();
            txtdisco.Clear();
            txtprocessador.Clear();
            txtmarca.Clear();
            txtplaca.Clear();
            txtano.Text = "0";
            txtdefeito.Clear();
        }
    }
}
