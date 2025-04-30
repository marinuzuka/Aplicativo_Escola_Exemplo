using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Escola_Exemplo.DALs
{
    class AlunosDAL
    {
        // Listar TODOS os alunos
        public static DataTable ListarAlunos()
        {
            Conexao minhaConexao = new Conexao();

            string query = "SELECT * FROM tb_alunos;";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, minhaConexao.Start());

            try
            {
                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);
                
                return tabela;
            }

            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }

            finally
            {
                minhaConexao.Close();
            }
        }

        public static DataTable PesquisarAluno(string nome)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"SELECT * FROM tb_alunos WHERE nome LIKE '%{nome}%';";

            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, minhaConexao.Start());

            try
            {
                DataTable tabela = new DataTable();

                adaptador.Fill(tabela);

                return tabela;
            }

            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }

            finally
            {
                minhaConexao.Close();
            }
        }
    }
}
