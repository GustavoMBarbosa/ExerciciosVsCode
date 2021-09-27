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
    public partial class FrmTurmas : Form
    {
        turma objTurma = new turma();
        public FrmTurmas()
        {
            InitializeComponent();
            txtcodigo.Enabled = false;
            dtgTurma.DataSource = objTurma.ListarTurma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objTurma.idCurso = int.Parse(cbcurso.Text);
            objTurma.dataInicio = dtpdatainicio.Text;
            objTurma.dataTermino = dtpdatatermino.Text;
            objTurma.horaInicio = txthorainicio.Text;
            objTurma.horaTermino = txthoratermino.Text;
            objTurma.idProfessor = int.Parse(cbprofessor.Text);

            objTurma.CadastrarTurma();
            MessageBox.Show("Cadastrado com Sucesso!");
        
        }

        private void dtgTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dtgTurma.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbcurso.Text = dtgTurma.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpdatainicio.Text = dtgTurma.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpdatatermino.Text = dtgTurma.Rows[e.RowIndex].Cells[3].Value.ToString();
            txthorainicio.Text = dtgTurma.Rows[e.RowIndex].Cells[4].Value.ToString();
            txthoratermino.Text = dtgTurma.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbprofessor.Text = dtgTurma.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            objTurma.codigoturma = int.Parse(txtcodigo.Text);
            objTurma.idCurso = int.Parse(cbcurso.Text);
            objTurma.dataInicio = dtpdatainicio.Text;
            objTurma.dataTermino = dtpdatatermino.Text;
            objTurma.horaInicio = txthorainicio.Text;
            objTurma.horaTermino = txthoratermino.Text;
            objTurma.idProfessor = int.Parse(cbprofessor.Text);

            objTurma.AlterarTurma();
            MessageBox.Show("Alterado com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objTurma.codigoturma = int.Parse(txtcodigo.Text);
            objTurma.ExcluirTurma();
            MessageBox.Show("Excluido com sucesso");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objTurma.ListarTurma();
        }
    }
}
