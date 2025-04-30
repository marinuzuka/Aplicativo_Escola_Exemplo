using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_Escola_Exemplo.DALs
{
    class SalasDAL
    {
        public static DataTable ListarIDsDeSalas()
        {
            Conexao minhaConexao = new Conexao();

            string query = $"SELECT id_sala AS 'ID' FROM tb_alunos GROUP BY id_sala;";

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

        public static DataTable ListarSalas()
        {
            Conexao minhaConexao = new Conexao();

            //string query = $"SELECT a.id_sala AS 'ID', " +
            //    $"nome AS 'Nome do Aluno', " +
            //    $"a.email AS 'E-mail do Aluno' " +
            //    $"FROM tb_alunos AS a " +
            //    $"INNER JOIN tb_salas AS s " +
            //    $"ON a.id_sala = s.id_sala " +
            //    $"ORDER BY a.id_sala ASC;";

            string query = $"" +
                $"SELECT s.id_sala as \"ID da turma\", " +
                $"p.nome as \"Nome do professor\", " +
                $"c.nome as \"Nome do Curso\", " +
                $"c.carga_horaria as \"Duração\", " +
                $"count(a.id_sala) as \"Qtd. alunos na turma\" " +
                $"FROM tb_salas AS s " +
                $"INNER JOIN tb_cursos AS c ON s.id_curso = c.id_curso " +
                $"INNER JOIN tb_professores AS p ON s.id_professor = p.id_professor " +
                $"INNER JOIN tb_alunos AS a ON s.id_sala = a.id_sala " +
                $"GROUP BY a.id_sala " +
                $"ORDER BY s.id_sala ASC;";

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

        public static DataTable PesquisarSala(int idSala)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"" +
                $"SELECT a.id_sala AS 'ID da Turma', " +
                $"nome AS 'Nome do Aluno', " +
                $"a.email AS 'E-mail do Aluno' " +
                $"FROM tb_alunos AS a " +
                $"INNER JOIN tb_salas AS s ON a.id_sala = s.id_sala " +
                $"WHERE a.id_sala = {idSala} " +
                $"ORDER BY a.nome ASC;";

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
