using ExemploBD_02.Modelo;
using ExemploBD_02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD_02
{
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroHeroi(0).ShowDialog();

        }

        private void atualizarLista()
        {
            string coluna = "nome";            

            if (rdbFiltrosNome.Checked)
            {
                coluna = "nome";

            }else if(rdbFiltrosRaca.Checked){
                coluna = "raca";
            }
            else if (rdbFiltrosCB.Checked)
            {
                coluna = "contaBancaria";
            }

            string ordenacao = "ASC";
            int aux = cbOrdenacao.SelectedIndex;
            
            if (aux == 1)
            {
                ordenacao = "DESC";
            }

            dtgvHerois.Rows.Clear();

            List<Heroi> herois = new HeroiRepositorio().obterTodos(txtPesquisa.Text, coluna, ordenacao);
            foreach(Heroi heroi in herois){
                dtgvHerois.Rows.Add(new object[]{
                    heroi.Id,
                    heroi.Nome,
                    heroi.Raca,
                    heroi.ContaBancaria
                });
            }
        }

        

        private void ListaHerois_Load(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dtgvHerois.CurrentRow.Index;
            int codigo = Convert.ToInt32(dtgvHerois.Rows[linhaSelecionada].Cells[0].Value.ToString());
            bool excluido = new HeroiRepositorio().apagar(codigo);
            if (excluido)
            {
                dtgvHerois.Rows.RemoveAt(linhaSelecionada);
                MessageBox.Show("Registro excluido com Suceso!");

            }
            else
            {
                MessageBox.Show("Não foi possivel apagar");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            new EstatisticasHerois().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dtgvHerois.CurrentRow.Index;
            int codigo = Convert.ToInt32(dtgvHerois.Rows[linhaSelecionada].Cells[0].Value.ToString());
            new CadastroHeroi(codigo).ShowDialog();
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void rdbFiltrosNome_CheckedChanged(object sender, EventArgs e)
        {
            atualizarLista();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            atualizarLista();
        }

        private void ListaHerois_Activated(object sender, EventArgs e)
        {
           atualizarLista(); 
        }
    }
}

