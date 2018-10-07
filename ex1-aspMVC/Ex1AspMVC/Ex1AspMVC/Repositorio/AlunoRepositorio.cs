using Ex1AspMVC.Database;
using Ex1AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ex1AspMVC.Repositorio
{
    public class AlunoRepositorio
    {
        //Obter Todos
        public List<Aluno> obterTodos()
        {
            List<Aluno> alunos = new List<Aluno>();

            SqlCommand cmd = new BancoDados().obterConexao();
            cmd.CommandText = @"SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ROUND(((Nota1 + Nota2 + Nota3)/3),1), IIF(Frequencia < 50, 'Reprovado por frequencia', IIF(((Nota1 + Nota2 + Nota3)/3) < 5, 'Reprovado por média', IIF(((Nota1 + Nota2 + Nota3)/3) < 7, 'Em exame', 'Aprovado'))) FROM Alunos";

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            foreach (DataRow linha in tabela.Rows)
            {
                Aluno aluno = new Aluno()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    CodMatricula = linha[2].ToString(),
                    Nota1 = Convert.ToByte(linha[3].ToString()),
                    Nota2 = Convert.ToDouble(linha[4].ToString()),
                    Nota3 = Convert.ToDouble(linha[5].ToString()),
                    Frequencia = Convert.ToByte(linha[6].ToString()),
                    Media = Convert.ToDouble(linha[7].ToString()),
                    Situacao = linha[8].ToString()
                };
                alunos.Add(aluno);
            }

            return alunos;
        }

        public int cadastrar(Aluno aluno){
            SqlCommand cmd = new BancoDados().obterConexao();

            cmd.CommandText = @"INSERT INTO Alunos OUTPUT INSERTED.ID VALUES(@NOME, @CODM, @N1, @N2, @N3, @FREQUENCIA)";
          
            cmd.Parameters.AddWithValue("@NOME", aluno.Nome);
            cmd.Parameters.AddWithValue("@CODM", aluno.CodMatricula);
            cmd.Parameters.AddWithValue("@N1", aluno.Nota1);
            cmd.Parameters.AddWithValue("@N2", aluno.Nota2);
            cmd.Parameters.AddWithValue("@N3", aluno.Nota3);
            cmd.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);

            int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            return id;
        }

        public bool alterar(Aluno aluno)
        {
            SqlCommand cmd = new BancoDados().obterConexao();

            cmd.CommandText = @"UPDATE Alunos SET Nome = @NOME, CodMatricula = @CODM, Nota1 = @N1, Nota2 = @N2, Nota3 = @N3, Frequencia = @FREQUENCIA WHERE Id = @ID";
            
            cmd.Parameters.AddWithValue("@ID", aluno.Id);
            cmd.Parameters.AddWithValue("@NOME", aluno.Nome);
            cmd.Parameters.AddWithValue("@CODM", aluno.CodMatricula);
            cmd.Parameters.AddWithValue("@N1", aluno.Nota1);
            cmd.Parameters.AddWithValue("@N2", aluno.Nota2);
            cmd.Parameters.AddWithValue("@N3", aluno.Nota3);
            cmd.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);

            return cmd.ExecuteNonQuery() == 1;     
        }

        public bool excluir(int id)
        {
            SqlCommand cmd = new BancoDados().obterConexao();

            cmd.CommandText = @"DELETE FROM Alunos WHERE Id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            return cmd.ExecuteNonQuery() == 1; 
        }

        public Aluno obterById(int id)
        {
            Aluno aluno = null;

            SqlCommand cmd = new BancoDados().obterConexao();

            cmd.CommandText = @"SELECT Id, Nome, CodMatricula, Nota1, Nota2, Nota3, Frequencia, ROUND(((Nota1 + Nota2 + Nota3)/3),1), IIF(Frequencia < 50, 'Reprovado por frequencia', IIF(((Nota1 + Nota2 + Nota3)/3) < 5, 'Reprovado por média', IIF(((Nota1 + Nota2 + Nota3)/3) < 7, 'Em exame', 'Aprovado'))) FROM Alunos WHERE Id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);
            
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            if (tabela.Rows.Count == 1)
            {
                aluno = new Aluno();
                aluno.Id = id;
                aluno.Nome = tabela.Rows[0][1].ToString();
                aluno.CodMatricula = tabela.Rows[0][2].ToString();
                aluno.Nota1 = Convert.ToDouble(tabela.Rows[0][3].ToString());
                aluno.Nota2 = Convert.ToDouble(tabela.Rows[0][4].ToString());
                aluno.Nota3 = Convert.ToDouble(tabela.Rows[0][5].ToString());
                aluno.Frequencia = Convert.ToByte(tabela.Rows[0][6].ToString());
                aluno.Media = Convert.ToDouble(tabela.Rows[0][7].ToString());
                aluno.Situacao = tabela.Rows[0][8].ToString();                
            }
            return aluno;
        }
    }
}