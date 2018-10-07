using ExemploMVC02.Database;
using ExemploMVC02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExemploMVC02.Repositorio
{
    public class RecrutadoraRepositorio
    {
        public List<Recrutadora> obterTodos()
        {
            List<Recrutadora> recrutadoras = new List<Recrutadora>();

            SqlCommand command = new BancoDados().obterConexao();
            command.CommandText = "SELECT Id, Nome, Cpf, TempoEmpresa, Salario FROM Recrutadoras";

            DataTable tabela = new DataTable();
            tabela.Load(command.ExecuteReader());
            foreach(DataRow linha in tabela.Rows){
                Recrutadora recrutadora = new Recrutadora(){
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    Cpf = linha[2].ToString(),
                    TempoEmpresa = Convert.ToByte(linha[3].ToString()),
                    Salario = Convert.ToDecimal(linha[4].ToString())
                };
                recrutadoras.Add(recrutadora);
            }

            return recrutadoras;
        }

        public int cadastrar(Recrutadora recrutadora)
        {
            SqlCommand command = new BancoDados().obterConexao();

            command.CommandText = "INSERT INTO Recrutadoras (Nome, Cpf, Salario, TempoEmpresa) OUTPUT INSERTED.ID VALUES(@NOME, @CPF, @SALARIO, @TEMPOEMPRESA)";
            command.Parameters.AddWithValue("@NOME", recrutadora.Nome);
            command.Parameters.AddWithValue("@CPF", recrutadora.Cpf);
            command.Parameters.AddWithValue("@SALARIO", recrutadora.Salario);
            command.Parameters.AddWithValue("@TEMPOEMPRESA", recrutadora.TempoEmpresa);

            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            
            return id;
        }

        public bool alterar(Recrutadora recrutadora)
        {
            SqlCommand command = new BancoDados().obterConexao();
            command.CommandText = "UPDATE Recrutadoras SET Nome = @NOME, Cpf = @CPF, Salario = @SALARIO, TempoEmpresa = @TEMPOEMPRESA WHERE Id = @ID";
            command.Parameters.AddWithValue("@ID", recrutadora.Id);
            command.Parameters.AddWithValue("@NOME", recrutadora.Nome);
            command.Parameters.AddWithValue("@CPF", recrutadora.Cpf);
            command.Parameters.AddWithValue("@SALARIO", recrutadora.Salario);
            command.Parameters.AddWithValue("@TEMPOEMPRESA", recrutadora.TempoEmpresa);

            return command.ExecuteNonQuery() == 1;                     
        }

        public bool excluir(int id)
        {
            SqlCommand command = new BancoDados().obterConexao();
            command.CommandText = "DELETE FROM Recrutadoras WHERE Id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            
            return command.ExecuteNonQuery() == 1;            
        }

        public Recrutadora obterById(int id)
        {
            Recrutadora recrutadora = null;
            SqlCommand command = new BancoDados().obterConexao();
            command.CommandText = "SELECT Nome, Cpf, TempoEmpresa, Salario FROM Recrutadoras WHERE Id = @ID";
            command.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(command.ExecuteReader());
            if (tabela.Rows.Count == 1)
            {
                recrutadora = new Recrutadora();
                recrutadora.Id = id;
                recrutadora.Nome = tabela.Rows[0][0].ToString();
                recrutadora.Cpf = tabela.Rows[0][1].ToString();
                recrutadora.TempoEmpresa = Convert.ToByte(tabela.Rows[0][2].ToString());
                recrutadora.Salario = Convert.ToDecimal(tabela.Rows[0][3].ToString());
            }

            return recrutadora;
        }
    }
}