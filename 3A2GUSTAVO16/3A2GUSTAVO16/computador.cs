using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3A2GUSTAVO16
{
    class computador
    {
        public int codigoPC, anoPC;
        public string nomePC, memoriaPC, discoPC, processadorPC, marcaPC, placaPC, statusPC, tipoPC;
        public string tabela = "computador";
        Conexao objConexao = new Conexao();
        public void CadastroPC()
        {
            string inserir = $@"insert into {tabela} values(null, '{nomePC}',
                              '{memoriaPC}', '{discoPC}', '{processadorPC}',
                               '{marcaPC}','{placaPC}' ,'{anoPC}', '{statusPC}', '{tipoPC}');";
            objConexao.ExeComando(inserir);
        }

        public DataTable ListarPC()
        {
            string consulta = $"select * from {tabela} order by status;";
            return objConexao.ExeConsulta(consulta);
            
        }
    }
}
