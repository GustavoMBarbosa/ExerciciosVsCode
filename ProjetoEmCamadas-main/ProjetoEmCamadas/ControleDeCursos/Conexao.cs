using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleDeCursos
{
    class Conexao
    {
        //passo 1
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                //Passo 1-1
                string dados_conexao = "Persist Security Info=false; " +
                                       "server=localhost; " +
                                       "database=3a2anime; " +
                                       "uid=root; pwd=";
                //Passo 1-2
                conexao = new MySqlConnection(dados_conexao);
                //Passo 1-3
                conexao.Open();
            }
            catch (MySqlException erro)
            {
                // mostrando o erro
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + erro.Message);
            }

        }

        public DataTable ExecutarConsulta(string sql)       //sql é uma string que deve conter uma instrução Select
        {
            try
            {
                //Passo 3 - 1: conectar ao banco
                Conectar();
                //Passo 3 - 2: exectar a consulta sql
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                //Passo 3 - 3:onde será guardado resultado da consulta
                DataTable dt = new DataTable();
                //Passo 3 - 4: guardar os dados da consulta
                dados.Fill(dt);    //Preenchimento do objeto DataTable(dt) com os dados obtidos da execução do select
                //Passo 3 - 5: fecha a conexão com o banco
                return dt;
            }
            catch (MySqlException erro)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)     //sql: instrução sql de INSERT, UPDATE ou DELETE
        {
            //Passo 2 - 1: conectar no banco 
            Conectar();

            try
            { //Passo 2 - 2: preparar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);
              //Passo 2 - 3: executar a intrução sql  
                comando.ExecuteNonQuery();      //Método responsável por executar a instrução sql
            }
            catch (MySqlException erro)
            {
                throw new Exception("A instrução não foi realizada.\n" + erro.Message);
            }
            finally
            {
                //Passo 2 - 4 :fechar a conexão com o banco
                conexao.Close();        //Importante para que o banco não fique vulnerável.
            }
        }
    }
}
