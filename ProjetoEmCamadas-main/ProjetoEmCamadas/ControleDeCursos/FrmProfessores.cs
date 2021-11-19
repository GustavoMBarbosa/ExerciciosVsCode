using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        professor objProfessor = new professor();
        public FrmProfessores()
        {
            InitializeComponent();
            txtid.Enabled = true;
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objProfessor.nomeProfessor = txtUsuario.Text;
            objProfessor.telefone = txtSenha.Text;
            objProfessor.valorHouraAula = double.Parse(txtEmail.Text);
            

            objProfessor.CadastraProfessor();
            MessageBox.Show("Cadastro com sucesso");

            txtUsuario.Clear();
            txtSenha.Clear();
            txtEmail.Clear();

        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtid.Text);
            objProfessor.ExcluirProfessor();
            MessageBox.Show("Excluido com sucesso");
        }

        private void dtgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtid.Text);
            objProfessor.nomeProfessor = txtUsuario.Text;
            objProfessor.telefone = txtSenha.Text;
            objProfessor.valorHouraAula = int.Parse(txtEmail.Text);
            objProfessor.AlterarProfessor();
            MessageBox.Show("Alterado com sucesso");
        }

        private void dtgProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dtgProfessor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dtgProfessor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dtgProfessor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgProfessor.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objProfessor.ListarProfessor();
        }
    }
}
