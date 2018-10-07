using exercicio01_alunos.Modelo;
using exercicio01_alunos.Repositorio;
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

namespace exercicio01_alunos
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
            carregaDGVAluno();
        }      
       
        public void carregaDGVAluno(string pesquisa = "%%")
        {
            try
            {
                dtgvAlunos.Rows.Clear();
                List<Aluno> alunos = new AlunoRepositorio().select(pesquisa);
               
                foreach (Aluno aluno in alunos)
                {
                    dtgvAlunos.Rows.Add(new object[]{
                        aluno.Id,
                        aluno.Nome,
                        aluno.CodMatricula,
                        aluno.Nota1,
                        aluno.Nota2,
                        aluno.Nota3,
                        aluno.Frequencia,
                        aluno.Media,
                        aluno.Situacao
                    });
                }  
                         
            }
            catch (SqlException errosql)
            {
                MessageBox.Show("Erro" + errosql);
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        } 
        
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = txtNome.Text;
            aluno.CodMatricula = txtCodM.Text;
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);
            aluno.Nota3 = Convert.ToDouble(txtNota3.Text);
            aluno.Frequencia = Convert.ToByte(txtFrequencia.Text);            

            if (string.IsNullOrEmpty(txtCod.Text))
            {

                int id = new AlunoRepositorio().insert(aluno);
                txtCod.Text = Convert.ToString(id);
                MessageBox.Show("Registro Cadastrado com Sucesso!");
                clear();
                carregaDGVAluno();
                tpLista.Show();
            }
            else
            {
                int id = Convert.ToInt32(txtCod.Text);
                aluno.Id = id;
                bool alterou = new AlunoRepositorio().alter(aluno);

                if (alterou)
                {
                    MessageBox.Show("Registro Alterado com Sucesso!");
                    clear();
                    carregaDGVAluno();
                    tpLista.Show();
                }
                else
                {
                    clear();
                    MessageBox.Show("Não foi possível alterar!");
                }
            }            
        }
      

        private void btnCadExcluir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCod.Text);
            bool excluido = new AlunoRepositorio().delete(cod);
            if (excluido)
            {
                clear();
                MessageBox.Show("Registro excluido com Suceso!");
            }
            else
            {
                clear();
                MessageBox.Show("Não foi possivel excluir!");
            }
        }

        private void clear()
        {
            txtCod.Text = "";
            txtNome.Text = "";
            txtCodM.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtFrequencia.Text = "";
            rtxSituacao.Text = "";
        }

        private void btnListaAlterar_Click(object sender, EventArgs e)
        {            
            int row = dtgvAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dtgvAlunos.Rows[row].Cells[0].Value.ToString());

            Aluno aluno = new AlunoRepositorio().selectByCod(codigo);

            preencherCampos(aluno);
            tpCadastro.Show();            
        }

        private void preencherCampos(Aluno aluno)
        {
            txtCod.Text = Convert.ToString(aluno.Id);
            txtNome.Text = aluno.Nome;
            txtCodM.Text = aluno.CodMatricula;
            txtNota1.Text = Convert.ToString(aluno.Nota1);
            txtNota2.Text = Convert.ToString(aluno.Nota2);
            txtNota3.Text = Convert.ToString(aluno.Nota3);
            txtFrequencia.Text = Convert.ToString(aluno.Frequencia);
            rtxSituacao.Text = "  Situação: "+aluno.Situacao+"  -  Média: "+Convert.ToString(aluno.Media);
        }

        private void btnListaExcluir_Click(object sender, EventArgs e)
        {
            int row = dtgvAlunos.CurrentRow.Index;
            int codigo = Convert.ToInt32(dtgvAlunos.Rows[row].Cells[0].Value.ToString());
            bool excluido = new AlunoRepositorio().delete(codigo);
            if (excluido)
            {
                dtgvAlunos.Rows.RemoveAt(row);
                MessageBox.Show("Registro excluido com Suceso!");

            }
            else
            {
                MessageBox.Show("Não foi possivel excluir!");
            }
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCod.Text))
            {
                try
                {
                    int cod = Convert.ToInt32(txtCod.Text);
                    Aluno aluno = new AlunoRepositorio().selectByCod(cod);

                    if (aluno != null)
                    {
                        preencherCampos(aluno);
                    }
                    else
                    {
                        MessageBox.Show("Registro não existe!");
                        txtCod.Focus();

                        //Faz um "ctrl+A" no txtCod
                        txtCod.SelectionStart = 0;
                        txtCod.SelectionLength = txtCod.Text.Length;
                    }
                }
                catch (NotFiniteNumberException ex)
                {
                    MessageBox.Show("Informe um Código válido!");
                    txtCod.Focus();
                    txtCod.SelectionStart = 0;
                    txtCod.SelectionLength = txtCod.Text.Length;
                }
            }
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            carregaDGVAluno(txtPesquisa.Text);
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            
        }

        private void rdbFiltrosNome_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
