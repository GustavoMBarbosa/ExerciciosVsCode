using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _3A2GUSTAVO16
{
    class Conexao
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string dados_conexao = "Persist Security Info=false; " +
                                       "server=localhost; " +
                                       "database=3a2gustavo16; " +
                                       "uid=root; pwd=";
                conexao = new MySqlConnection(dados_conexao);
                conexao.Open();
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao Conectar ao Banco de Dados.\n" + erro.Message);
            }

        }

        public DataTable ExeConsulta(string sql) 
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt); 
                return dt;
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao executar a CONSULTA pedida.\n" + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExeComando(string sql)
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException erro)
            {
                throw new Exception("Instrução nãorealizada.\n" + erro.Message);
            }
            finally
            {               
                conexao.Close();
            }
        }
    }
}
