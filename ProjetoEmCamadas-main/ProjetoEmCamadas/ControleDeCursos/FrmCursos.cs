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
    public partial class FrmUsuarios : Form
    {
        Camadas objCurso = new Camadas();
        public FrmUsuarios()
        {

            InitializeComponent();
            txtCodigo.Enabled = false;
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            
            objCurso.nomeCurso = txtAnime.Text;
            objCurso.conteudoProgramatico = txtSinopse.Text;
            objCurso.valorMensalidade = double.Parse(txtEstudio.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;

            objCurso.CadastrarCurso();
            MessageBox.Show("Cadastro com sucesso");

            txtAnime.Clear();
            txtSinopse.Clear();
            txtEstudio.Clear();
            txtCargaHoraria.Clear();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void dtgCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAnime.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSinopse.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEstudio.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.ExcluirCurso();
            MessageBox.Show("Excluido com sucesso");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.nomeCurso = txtAnime.Text;
            objCurso.conteudoProgramatico = txtSinopse.Text;
            objCurso.valorMensalidade = double.Parse(txtEstudio.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;
            objCurso.AlterarCurso();
            MessageBox.Show("Alterado com sucesso");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objCurso.ListarCursos();
        }
    }
}
