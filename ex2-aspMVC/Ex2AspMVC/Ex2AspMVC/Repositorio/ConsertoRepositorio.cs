using Ex2AspMVC.Database;
using Ex2AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Ex2AspMVC.Repositorio
{
    public class ConsertoRepositorio
    {
        public List<Conserto> obterTodos()
        {
            List<Conserto> consertos = new List<Conserto>();

            SqlCommand cmd = new Conexao().obterConexao();
            cmd.CommandText = @"SELECT Id, DonoVeiculo, ModeloVeiculo, CorVeiculo, Situacao FROM Consertos";

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            foreach (DataRow linha in tabela.Rows)
            {
                Conserto conserto = new Conserto()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    DonoVeiculo= linha[1].ToString(),
                    ModeloVeiculo = linha[2].ToString(),
                    CorVeiculo = linha[3].ToString(),                    
                    Situacao = linha[4].ToString()
                };
                consertos.Add(conserto);
            }

            return consertos;
        }

        public int cadastrar(Conserto conserto)
        {
            SqlCommand cmd = new Conexao().obterConexao();

            cmd.CommandText = @"INSERT INTO Consertos(DonoVeiculo, ModeloVeiculo, CorVeiculo, Situacao) OUTPUT INSERTED.ID VALUES(@DONOVEICULO, @MODELOVEICULO, @CORVEICULO, @SITUACAO)";

            cmd.Parameters.AddWithValue("@DONOVEICULO", conserto.DonoVeiculo);
            cmd.Parameters.AddWithValue("@MODELOVEICULO", conserto.ModeloVeiculo);
            cmd.Parameters.AddWithValue("@CORVEICULO", conserto.CorVeiculo);
            cmd.Parameters.AddWithValue("@SITUACAO", conserto.Situacao);

            int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            return id;
        }

        public bool alterar(Conserto conserto)
        {
            SqlCommand cmd = new Conexao().obterConexao();

            cmd.CommandText = @"UPDATE Consertos SET DonoVeiculo = @DONOVEICULO, ModeloVeiculo = @MODELOVEICULO, CorVeiculo = @CORVEICULO, Situacao = @SITUACAO WHERE Id = @ID";

            cmd.Parameters.AddWithValue("@ID", conserto.Id);
            cmd.Parameters.AddWithValue("@DONOVEICULO", conserto.DonoVeiculo);
            cmd.Parameters.AddWithValue("@MODELOVEICULO", conserto.ModeloVeiculo);
            cmd.Parameters.AddWithValue("@CORVEICULO", conserto.CorVeiculo);
            cmd.Parameters.AddWithValue("@SITUACAO", conserto.Situacao);

            return cmd.ExecuteNonQuery() == 1;
        }

        public bool excluir(int id)
        {
            SqlCommand cmd = new Conexao().obterConexao();

            cmd.CommandText = @"DELETE FROM Consertos WHERE Id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            return cmd.ExecuteNonQuery() == 1;
        }

        public Conserto obterById(int id)
        {
            Conserto conserto = null;

            SqlCommand cmd = new Conexao().obterConexao();

            cmd.CommandText = @"SELECT Id, DonoVeiculo, ModeloVeiculo, CorVeiculo, Situacao FROM Consertos WHERE Id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());

            if (tabela.Rows.Count == 1)
            {
                conserto = new Conserto();
                conserto.Id = id;
                conserto.DonoVeiculo = tabela.Rows[0][1].ToString();
                conserto.ModeloVeiculo = tabela.Rows[0][2].ToString();
                conserto.CorVeiculo = tabela.Rows[0][3].ToString();
                conserto.Situacao = tabela.Rows[0][4].ToString();
                
            }
            return conserto;
        }
    }
}