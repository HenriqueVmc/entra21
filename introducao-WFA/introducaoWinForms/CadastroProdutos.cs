using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace introducaoWinForms
{
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }
        int qtd1 = 0, qtd2 = 0, qtd3 = 0, qtd4 = 0;
        double val1 = 0, val2 = 0, val3 = 0, val4 = 0;        

        public bool qtdInvalida()
        {
            try
            {
                qtd1 = Convert.ToInt32(numQtd1.Value);
                qtd2 = Convert.ToInt32(numQtd2.Value);
                qtd3 = Convert.ToInt32(numQtd3.Value);
                qtd4 = Convert.ToInt32(numQtd4.Value);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Quantidade deve ser numerica");
                return true;
            }
            return false;
        }

        public bool valInvalido()
        {
            try
            {
                val1 = Convert.ToDouble(txtVal1.Text);
                val2 = Convert.ToDouble(txtVal2.Text);
                val3 = Convert.ToDouble(txtVal3.Text);
                val4 = Convert.ToDouble(txtVal4.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show("Valores devem ser Numericos");
                txtVal1.Focus();
                txtVal2.Focus();
                txtVal3.Focus();
                txtVal4.Focus();
                return true;
            }
            return false;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Fazer Validaçoes de Campos
            while (nomeInvalido() || qtdInvalida() || valInvalido())
            {
                return;
            }

            rtbResultado.Text = string.Format(" --- Lista de Produtos ---\nProduto: {8}\nQuantidade: {0} - Valor: {1}\nQuantidade: {2} - Valor: {3}\nQuantidade: {4} - Valor: {5}\nQuantidade: {6} - Valor: {7}\n", qtd1, val1, qtd2, val2, qtd3, val3, qtd4, val4, txtNome.Text);
            txtTotal.Text = Convert.ToString((qtd1 * val1) + (qtd2 * val2) + (qtd3 * val3) + (qtd4 * val4));
        }

        private bool nomeInvalido()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto");
                txtNome.Focus();
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTotal.Text = "";
            txtVal1.Text = "";
            txtVal2.Text = "";
            txtVal3.Text = "";
            txtVal4.Text = "";
            numQtd1.Value = 0;
            numQtd2.Value = 0;
            numQtd3.Value = 0;
            numQtd4.Value = 0;
            rtbResultado.Text = "";

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void txtVal1_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "";
        }

        private void txtVal2_Click(object sender, EventArgs e)
        {
            txtVal2.Text = "";
        }

        private void txtVal3_Click(object sender, EventArgs e)
        {
            txtVal3.Text = "";
        }

        private void txtVal4_Click(object sender, EventArgs e)
        {
            txtVal4.Text = "";
        }

        private void rtbResultado_EnabledChanged(object sender, EventArgs e)
        {
            txtVal4.Text = "";
        }

        private void txtVal1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVal1.Text))
            {
                txtVal1.Text = "0";
            }
        }

        private void txtVal2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVal2.Text))
            {
                txtVal2.Text = "0";
            }
        }

        private void txtVal3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVal3.Text))
            {
                txtVal3.Text = "0";
            }
        }

        private void txtVal4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVal3.Text))
            {
                txtVal4.Text = "0";
            }
        }




    }
}

