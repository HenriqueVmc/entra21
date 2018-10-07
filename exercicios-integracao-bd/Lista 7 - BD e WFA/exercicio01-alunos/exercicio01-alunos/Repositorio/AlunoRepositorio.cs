using exercicio01_alunos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01_alunos.Repositorio
{
    class AlunoRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Documents\bd-lista7.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection connection = null;

        public AlunoRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }

        public int insert(Aluno aluno)
        {
            connection.Open();
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            //OUTPUT INSERTED.Id = retorna ID do registro inserido
            insert.CommandText = "INSERT INTO Alunos (Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia) OUTPUT INSERTED.Id VALUES(@Nome, @CodM, @Nota1, @Nota2, @Nota3, @Frequencia)";

            insert.Parameters.AddWithValue("@Nome", aluno.Nome);
            insert.Parameters.AddWithValue("@CodM", aluno.CodMatricula);
            insert.Parameters.AddWithValue("@Nota1", aluno.Nota1);
            insert.Parameters.AddWithValue("@Nota2", aluno.Nota1);
            insert.Parameters.AddWithValue("@Nota3", aluno.Nota1);
            insert.Parameters.AddWithValue("@Frequencia", aluno.Frequencia);

            int id = Convert.ToInt32(insert.ExecuteScalar().ToString());//returna uma úinica info, nesse caso Id
            connection.Close();
            return id; 
        }

        public bool alter(Aluno aluno)
        {
            connection.Open();
            SqlCommand alter = new SqlCommand();
            alter.Connection = connection;
            alter.CommandText = @"UPDATE Alunos SET Nome = @Nome, CodMatricula = @CodM, Nota1 = @Nota1, Nota2 = @Nota2, Nota3 = @Nota3, Frequencia = @Frequencia WHERE Id = @Id";

            alter.Parameters.AddWithValue("@Id", aluno.Id);
            alter.Parameters.AddWithValue("@Nome", aluno.Nome);
            alter.Parameters.AddWithValue("@CodM", aluno.CodMatricula);
            alter.Parameters.AddWithValue("@Nota1", aluno.Nota1);
            alter.Parameters.AddWithValue("@Nota2", aluno.Nota2);
            alter.Parameters.AddWithValue("@Nota3", aluno.Nota3);
            alter.Parameters.AddWithValue("@Frequencia", aluno.Frequencia);

            int alterado = alter.ExecuteNonQuery();

            connection.Close();
            return alterado == 1;
        }

        public List<Aluno> select(string txtParaPesquisa)//, string txtOrderColuna = "Nome", string txtOrdenacao = "ASC"
        {
            txtParaPesquisa = "%" + txtParaPesquisa + "%";

            List<Aluno> alunos = new List<Aluno>();

            connection.Open();

            SqlCommand select = new SqlCommand();
            select.Connection = connection;
            //select.CommandText = "SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ((Nota1 + Nota2 + Nota3)/3),  FROM Alunos";

            select.CommandText = "SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ((Nota1 + Nota2 + Nota3)/3), IIF(Frequencia < 50, 'Reprovado por frequencia', IIF(((Nota1 + Nota2 + Nota3)/3) < 5, 'Reprovado por média', IIF(((Nota1 + Nota2 + Nota3)/3) < 7, 'Em exame', 'Aprovado'))) FROM Alunos WHERE Nome LIKE @Pesquisa OR CodMatricula LIKE @Pesquisa";


            select.Parameters.AddWithValue("@Pesquisa", txtParaPesquisa);

            DataTable table = new DataTable();
            table.Load(select.ExecuteReader());

            for (int i = 0; i < table.Rows.Count; i++)
            {
               Aluno aluno = new Aluno();

                aluno.Id = Convert.ToInt32(table.Rows[i][0].ToString());
                aluno.Nome = table.Rows[i][1].ToString();
                aluno.CodMatricula = table.Rows[i][2].ToString();
                aluno.Nota1 = Convert.ToDouble(table.Rows[i][3].ToString());
                aluno.Nota2 = Convert.ToDouble(table.Rows[i][4].ToString());
                aluno.Nota3 = Convert.ToDouble(table.Rows[i][5].ToString());
                aluno.Frequencia = Convert.ToByte(table.Rows[i][6].ToString());
                aluno.Media = Convert.ToDouble(table.Rows[i][7].ToString());
                aluno.Situacao = table.Rows[i][8].ToString();

                alunos.Add(aluno);
            }

            connection.Close();

            return alunos;
        }

        public bool delete(int codM)
        {
            connection.Open();

            SqlCommand delete = new SqlCommand();
            delete.Connection = connection;
            delete.CommandText = "DELETE FROM Alunos WHERE CodMatricula = @CodM";

            delete.Parameters.AddWithValue("@CodM", codM);
            int excluido = delete.ExecuteNonQuery();

            connection.Close();

            return excluido == 1;
        }

        public Aluno selectByCod(int codigo)
        {
            connection.Open();
            SqlCommand select = new SqlCommand();
            select.Connection = connection;
            //@ = para diferenriar o que é texto, e o que é parametro
            select.CommandText = @"SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ((Nota1 + Nota2 + Nota3)/3), IIF(Frequencia < 50, 'Reprovado por frequencia', IIF(((Nota1 + Nota2 + Nota3)/3) < 5, 'Reprovado por média', IIF(((Nota1 + Nota2 + Nota3)/3) < 7, 'Em exame', 'Aprovado'))) FROM Alunos WHERE Id = @Id";

            select.Parameters.AddWithValue("@Id", codigo);

            DataTable table = new DataTable();
            table.Load(select.ExecuteReader());

            if (table.Rows.Count == 0)
            {
                return null;
            }
            
            Aluno aluno = new Aluno();
            aluno.Id = Convert.ToInt32(table.Rows[0][0].ToString());
            aluno.Nome = table.Rows[0][1].ToString();
            aluno.CodMatricula = table.Rows[0][2].ToString();
            aluno.Nota1 = Convert.ToDouble(table.Rows[0][3].ToString());
            aluno.Nota2 = Convert.ToDouble(table.Rows[0][4].ToString());
            aluno.Nota3 = Convert.ToDouble(table.Rows[0][5].ToString());
            aluno.Frequencia = Convert.ToByte(table.Rows[0][6].ToString());
            aluno.Media = Convert.ToDouble(table.Rows[0][7].ToString());
            aluno.Situacao = table.Rows[0][8].ToString();


            connection.Close();

            return aluno;
        }
    }
}

