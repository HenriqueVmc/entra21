using ExemploBD_02.Modelo;
using ExemploBD_02.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBD_02
{
    public partial class CadastroHeroi : Form
    {
        private int codigo;
      
        public CadastroHeroi(int codigo)
        {
            InitializeComponent();
            
            this.codigo = codigo;
            Heroi heroi = new HeroiRepositorio().obterByCod(codigo);
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCod.Text = Convert.ToString(heroi.Id);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            txtQtdFilmes.Text = Convert.ToString(heroi.QtdFilmes);
            cbxMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            txtDescricao.Text = heroi.Descricao;

            if (heroi.Escuridao) { rdbEscuridaoSim.Checked = true; }
            else rdbEscuridaoNao.Checked = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heroi heroi = new Heroi();

            heroi.Nome = txtNome.Text;
            heroi.NomePessoa = txtNomePessoa.Text;
            heroi.ContaBancaria = Convert.ToDouble(txtContaBancaria.Text);
            heroi.DataNascimento= dtNascimento.Value;
            heroi.Escuridao = rdbEscuridaoSim.Checked;
            heroi.QtdFilmes = Convert.ToByte(txtQtdFilmes.Text);
            heroi.Raca = cbRaca.SelectedItem.ToString();
            heroi.Sexo = cbxMulher.Checked ? 'm' : 'h';
            heroi.Descricao = txtDescricao.Text;

            if(string.IsNullOrEmpty(txtCod.Text)){            

                int cadastrou = new HeroiRepositorio().inserir(heroi);
                txtCod.Text = Convert.ToString(cadastrou);
                MessageBox.Show("Registro Cadastrado com Sucesso!");
            }
            else
            {
                int id = Convert.ToInt32(txtCod.Text);
                heroi.Id = id;
                bool alterou = new HeroiRepositorio().alterar(heroi);

                if (alterou)
                {
                    MessageBox.Show("Registro Alterado com Sucesso!");
                }else{
                    MessageBox.Show("Não foi possível alterar!");
                }
            }
        }

        private void txtCod_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCod.Text))
            {
                try
                {
                    int cod = Convert.ToInt32(txtCod.Text);
                    Heroi heroi = new HeroiRepositorio().obterByCod(cod);

                    if (heroi != null)
                    {
                        preencherCampos(heroi);
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
                catch(NotFiniteNumberException ex)
                {
                    MessageBox.Show("Informe um Código válido!");
                    txtCod.Focus();
                    txtCod.SelectionStart = 0;
                    txtCod.SelectionLength = txtCod.Text.Length;
                }
            }
        }

        private void preencherCampos(Heroi heroi)
        {
            txtNome.Text = heroi.Nome;
            txtNomePessoa.Text = heroi.NomePessoa;
            txtCod.Text = Convert.ToString(heroi.Id);
            txtContaBancaria.Text = Convert.ToString(heroi.ContaBancaria);
            txtQtdFilmes.Text = Convert.ToString(heroi.QtdFilmes);
            cbxMulher.Checked = heroi.Sexo == 'm';
            cbRaca.SelectedItem = heroi.Raca;
            txtDescricao.Text = heroi.Descricao;
        }
    }
}


