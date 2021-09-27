using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;
        public string tabela = "tbl_curso";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastrarCurso()
        {
            string inserir = $@"insert into {tabela} values(null,'{nomeCurso}',
                             '{conteudoProgramatico}' , '{valorMensalidade}' , '{cargaHoraria}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }

        public void AlterarCurso()
        {
            string alterar = $@"update {tabela} set codigo='{codigoCurso}',nomeCurso='{nomeCurso}',
                             conteudo='{conteudoProgramatico}' , ValorMensalidade='{valorMensalidade}' , cargaHoraria='{cargaHoraria}';";
            objConexao.ExecutarComando(alterar);
        }

        public void ExcluirCurso()
        {
            string excluir = $@"delete from {tabela} where codigo = '{codigoCurso}';";          
            objConexao.ExecutarComando(excluir);
        }

        public DataTable ListarCursos()     //Requer: using System.Data;
        {
            string consulta = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(consulta);
            
        }
    }
    class professor
    {
        public int codigoProfessor;
        public string nomeProfessor, telefone;
        public double valorHouraAula;
        public string tabela = "tbl_professor";
        //Declarando a classe de conexão
        Conexao objConexao = new Conexao();
        public void CadastraProfessor()
        {
            string inserir = $@"insert into {tabela} values(null,'{nomeProfessor}',
                             '{valorHouraAula}' , '{telefone}');";
            //chamando o metodo ExecutarComando para executar o meu insert
            objConexao.ExecutarComando(inserir);
        }
        public DataTable ListarProfessor()
        {
            string consulta = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(consulta);
        }
        public void ExcluirProfessor()
        {
            string excluir = $@"delete from {tabela} where codigo = '{codigoProfessor}';";
            objConexao.ExecutarComando(excluir);
        }
        public void AlterarProfessor()
        {
            string alterar = $@"update {tabela} set codigo='{codigoProfessor}',nome='{nomeProfessor}',
                                valorHoraAula='{valorHouraAula}', telefone='{telefone}';";
            objConexao.ExecutarComando(alterar);
        }
        

    }
    class turma
    {
        public int codigoturma, idCurso, idProfessor;
        public string dataInicio, dataTermino, horaInicio, horaTermino;
        public string tabela = "tbl_turma";
        Conexao objconexao = new Conexao();

        public void CadastrarTurma()
        {
            string inserir = $@"insert into {tabela} values(null,'{idCurso}',
                                '{dataInicio}','{dataTermino}','{horaInicio}','{horaTermino}','{idProfessor}');";
            objconexao.ExecutarComando(inserir);
        }
        public DataTable ListarTurma()
        {
            string consulta = $"select * from {tabela} order by codigo;";
            return objconexao.ExecutarConsulta(consulta);
        }
        public void ExcluirTurma()
        {
            string excluir = $@"delete from {tabela} where codigo = '{codigoturma}';";
            objconexao.ExecutarComando(excluir);
        }
       public void AlterarTurma()
        {
            string alterar = $@"update {tabela} set codigo='{codigoturma}', idCurso='{idCurso}', dataInicio='{dataInicio}',
                                dataTermino='{dataTermino}' ,horaInicio='{horaInicio}', horaTermino='{horaTermino}', idProfessor='{idProfessor}';";
            objconexao.ExecutarComando(alterar);
        }
    }
}
