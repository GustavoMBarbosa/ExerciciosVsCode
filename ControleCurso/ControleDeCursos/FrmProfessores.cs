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
            txtcodigo.Enabled = true;
            dtgProfessor.DataSource = objProfessor.ListarProfessor();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objProfessor.nomeProfessor = txtnomeProfessor.Text;
            objProfessor.telefone = txtTelefone.Text;
            objProfessor.valorHouraAula = double.Parse(txtValorAula.Text);
            

            objProfessor.CadastraProfessor();
            MessageBox.Show("Cadastro com sucesso");

            txtnomeProfessor.Clear();
            txtTelefone.Clear();
            txtValorAula.Clear();

        }

        private void FrmProfessores_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtcodigo.Text);
            objProfessor.ExcluirProfessor();
            MessageBox.Show("Excluido com sucesso");
        }

        private void dtgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txtcodigo.Text);
            objProfessor.nomeProfessor = txtnomeProfessor.Text;
            objProfessor.telefone = txtTelefone.Text;
            objProfessor.valorHouraAula = int.Parse(txtValorAula.Text);
            objProfessor.AlterarProfessor();
            MessageBox.Show("Alterado com sucesso");
        }

        private void dtgProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgProfessor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnomeProfessor.Text = dtgProfessor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dtgProfessor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorAula.Text = dtgProfessor.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objProfessor.ListarProfessor();
        }
    }
}
