using ExemploBD_02.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBD_02.Repositorio
{
    public class HeroiRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\i3i\Documents\exemploBD_02.mdf;Integrated Security=True;Connect Timeout=30";
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Henricoltz\Documents\GitHub\Entra21\exercicios-integracao-bd\ExemploBD_02\ExemploBD_02\bd-herois.mdf;Integrated Security=True;Connect Timeout=30";        

        private SqlConnection connection = null;

        public HeroiRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }        

        public int inserir(Heroi heroi) {
            connection.Open();
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            //OUTPUT INSERTED.Id = retorna ID do registro inserido
            insert.CommandText = "INSERT INTO Herois (Nome, Escuridao, NomePessoa, Raca, ContaBancaria, DataNascimento, Sexo, QtdFilmes, Descricao) OUTPUT INSERTED.Id VALUES (@Nome, @Escuridao, @NomePessoa, @Raca, @ContaBancaria, @DataNascimento, @Sexo, @QtdFilmes, @Descricao)";

            insert.Parameters.AddWithValue("@Nome", heroi.Nome);
            insert.Parameters.AddWithValue("@Escuridao", heroi.Escuridao);
            insert.Parameters.AddWithValue("@NomePessoa", heroi.NomePessoa);
            insert.Parameters.AddWithValue("@Raca", heroi.Raca);
            insert.Parameters.AddWithValue("@ContaBancaria", heroi.ContaBancaria);
            insert.Parameters.AddWithValue("@DataNascimento", heroi.DataNascimento);
            insert.Parameters.AddWithValue("@Sexo", heroi.Sexo);
            insert.Parameters.AddWithValue("@QtdFilmes", heroi.QtdFilmes);
            insert.Parameters.AddWithValue("@Descricao", heroi.Descricao);

            int id = Convert.ToInt32(insert.ExecuteScalar().ToString());//returna uma úinica info, nesse caso Id
            connection.Close();
            return id; 
        }

        public bool alterar(Heroi heroi) {

            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = @"UPDATE Herois SET Nome = @Nome, DataNascimento = @DataNascimento, NomePessoa = @NomePessoa, ContaBancaria = @ContaBancaria, Raca = @Raca, Sexo = @Sexo, QtdFilmes = @QtdFilmes, Escuridao = @Escuridao, Descricao = @Descricao WHERE Id = @Id";

            comando.Parameters.AddWithValue("@Id", heroi.Id);
            comando.Parameters.AddWithValue("@Nome", heroi.Nome);
            comando.Parameters.AddWithValue("@DataNascimento", heroi.DataNascimento);
            comando.Parameters.AddWithValue("@NomePessoa", heroi.NomePessoa);
            comando.Parameters.AddWithValue("@ContaBancaria", heroi.ContaBancaria);
            comando.Parameters.AddWithValue("@Raca", heroi.Raca);
            comando.Parameters.AddWithValue("@Sexo", heroi.Sexo);
            comando.Parameters.AddWithValue("@QtdFilmes", heroi.QtdFilmes);
            comando.Parameters.AddWithValue("@Escuridao", heroi.Escuridao);
            comando.Parameters.AddWithValue("@Descricao", heroi.Descricao);

            int qtdAlterada = comando.ExecuteNonQuery();

            connection.Close();
            return qtdAlterada == 1;
        }

        public List<Heroi> obterTodos(string txtParaPesquisa = "%%", string txtOrderColuna = "Nome", string txtOrdenacao = "ASC")
        {

            txtParaPesquisa = "%" + txtParaPesquisa + "%";
            List<Heroi> herois = new List<Heroi>();
            
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "SELECT Id, Nome, Raca, ContaBancaria FROM Herois WHERE Nome LIKE @Pesquisa OR RACA LIKE @Pesquisa ORDER BY "+txtOrderColuna+" "+txtOrdenacao+";";

            comando.Parameters.AddWithValue("@Pesquisa", txtParaPesquisa);

            DataTable tableEmMemoria = new DataTable();
            tableEmMemoria.Load(comando.ExecuteReader());

            for (int i = 0; i < tableEmMemoria.Rows.Count; i++)
            {
                Heroi heroi = new Heroi();

                heroi.Id = Convert.ToInt32(tableEmMemoria.Rows[i][0].ToString());
                heroi.Nome = tableEmMemoria.Rows[i][1].ToString();
                heroi.Raca = tableEmMemoria.Rows[i][2].ToString();
                heroi.ContaBancaria = Convert.ToDouble(tableEmMemoria.Rows[i][3].ToString());
                herois.Add(heroi);
            }

            connection.Close();            

            return herois;
        }

        public bool apagar(int codigo) {

            connection.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            comando.CommandText = "DELETE FROM Herois WHERE Id = @Cod";

            comando.Parameters.AddWithValue("@Cod", codigo);
            int quantidade = comando.ExecuteNonQuery();

            connection.Close();

            return quantidade == 1; 
        }

        public double obterTotalContas()
        {
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT SUM(ContaBancaria) FROM Herois;";
            
            double total = Convert.ToDouble(command.ExecuteScalar());
            connection.Close();

            return total;//Retorna Primeira Coluna
        }

        public Heroi obterByCod(int codigo)
        {
            connection.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = connection;
            //@ = para diferenriar o que é texto, e o que é parametro
            comando.CommandText = @"SELECT Id, Nome, Raca, NomePessoa, ContaBancaria, QtdFilmes, DataNascimento, Sexo, Escuridao, Descricao FROM Herois WHERE Id = @Id";
            comando.Parameters.AddWithValue("@Id", codigo);

            DataTable tableEmMemoria = new DataTable();
            tableEmMemoria.Load(comando.ExecuteReader());

            if (tableEmMemoria.Rows.Count == 0)
            {
                return null;
            }

            Heroi heroi = new Heroi();
            heroi.Id = Convert.ToInt32(tableEmMemoria.Rows[0][0].ToString());
            heroi.Nome = tableEmMemoria.Rows[0][1].ToString();
            heroi.Raca = tableEmMemoria.Rows[0][2].ToString();
            heroi.NomePessoa = tableEmMemoria.Rows[0][3].ToString();
            heroi.ContaBancaria = Convert.ToDouble(tableEmMemoria.Rows[0][4].ToString());   
            heroi.QtdFilmes = Convert.ToByte(tableEmMemoria.Rows[0][5].ToString());
            heroi.DataNascimento = Convert.ToDateTime(tableEmMemoria.Rows[0][6].ToString());            
            heroi.Sexo = Convert.ToChar(tableEmMemoria.Rows[0][7].ToString());
            heroi.Escuridao = Convert.ToBoolean(tableEmMemoria.Rows[0][8].ToString());
            heroi.Descricao = tableEmMemoria.Rows[0][9].ToString();

            connection.Close();

            return heroi;
        }
    }
}




