using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Questão 01:​ A Disney deseja obter algumas informações sobre as suas mega produções, para tal deve-se
    solicitar as seguintes informações sobre cada produção:
    ➔ Nome;
    ➔ Ano de lançamento;
    ➔ Diretor;
    ➔ Orçamento;
    ➔ Receita;
    ➔ Descrição.
    A cada produção cadastrada, deve-se apresentar o lucro obtido com esta produção.
    Deve-se questionar o usuário quantas produções serão cadastradas, este deve ser o critério para o while.
    Ao final deve-se apresentar as seguintes informações:
    ➔ Nome da produção e a receita do filme com a maior receita;
    ➔ Nome da produção e o orçamento do filme com o menor orçamento;
    ➔ Ano da produção mais velha;
    ➔ Nome da produção com o maior nome de diretor;
    ➔ Nome da produção com o menor nome de diretor; 
 */

namespace prova2_while
{
    class Ex1
    {
        int qtd = 0;
        String[] nome;
        int[] ano;
        String[] diretor;
        double[] orcamento;
        double[] receita;
        String[] descricao;

        public Ex1()
        {
            cadastrarProdutos();

        }

        private void cadastrarProdutos()
        {
            int index = 0;
            Console.WriteLine("Informe a quantidade de Cadastros:");
            qtd = Convert.ToInt32(Console.ReadLine());

            nome = new String[qtd];
            ano = new int[qtd];
            diretor = new String[qtd];
            orcamento = new double[qtd];
            receita = new double[qtd];
            descricao = new String[qtd];

            while (index < qtd)
            {
                Console.WriteLine("\n-- Cadastro de Produção -- \n");

                Console.WriteLine("Nome: ");
                nome[index] = Console.ReadLine();

                Console.WriteLine("Ano de lançamento: ");
                ano[index] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Diretor: ");
                diretor[index] = Console.ReadLine();

                Console.WriteLine("Orçamento: ");
                orcamento[index] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Receita: ");
                receita[index] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Descrição: ");
                descricao[index] = Console.ReadLine();

                Console.WriteLine("Lucro: " + calcLucro(receita[index], orcamento[index]));

                index++;
            }

            imprimir(nome, ano, diretor, orcamento, receita, descricao, qtd);
        }

        public void imprimir(String[] nome, int[] ano, String[] diretor, double[] orcamento, double[] receita, String[] descricao, int qtd)
        {

            imprimirMaiorReceita(calcMaiorReceita(receita, qtd));
            imprimirMenorOrcamento(menorOrcamento(orcamento, qtd));
            imprimirProducaoMaisVelha(calcproducaoMaisVelha(ano, qtd));
            imprimirMaiorNome(calcMaiorNome(nome, qtd));
            imprimirMenorNome(calcMenorNome(nome, qtd));

        }

        private void imprimirMaiorReceita(int indice)
        {
            Console.WriteLine("\n-- Maior Receita --\n");
            Console.WriteLine("Nome: " + nome[indice]);
            Console.WriteLine("Receita: " + receita[indice]);
        }

        private void imprimirMenorOrcamento(int indice)
        {
            Console.WriteLine("\n-- Menor Orcamento --\n");
            Console.WriteLine("Nome: " + nome[indice]);
            Console.WriteLine("Orcamento: " + orcamento[indice]);
        }

        private void imprimirProducaoMaisVelha(int indice)
        {
            Console.WriteLine("\n-- Producao Mais Velha --\n");
            Console.WriteLine("Nome: " + nome[indice]);
            Console.WriteLine("Ano: " + ano[indice]);
        }

        private void imprimirMaiorNome(int indice)
        {
            Console.WriteLine("\n-- Maior Nome --\n");
            Console.WriteLine("Nome: " + nome[indice]);
        }

        private void imprimirMenorNome(int indice)
        {
            Console.WriteLine("\n-- Menor Nome --\n");
            Console.WriteLine("Nome: " + nome[indice]);
        }

        private double calcLucro(double receita, double orcamento)
        {
            return receita - orcamento;
        }

        public int calcMaiorReceita(double[] receita, int qtd)
        {

            int cont = 0;
            int indice = 0;
            double maior = receita[0];

            while (cont < qtd)
            {
                if (receita[cont] >= maior)
                {
                    maior = receita[cont];
                    indice = cont;
                }

                cont++;
            }

            return indice;
        }

        private int menorOrcamento(double[] orcamento, int qtd)
        {
            int cont = 0;
            int indice = 0;
            double menor = orcamento[0];

            while (cont < qtd)
            {
                if (orcamento[cont] <= menor)
                {
                    menor = orcamento[cont];
                    indice = cont;
                }
                cont++;
            }

            return indice;
        }

        private int calcproducaoMaisVelha(int[] ano, int qtd)
        {
            int cont = 0;
            int indice = 0;
            double maior = ano[0];

            while (cont < qtd)
            {
                if (ano[cont] <= maior)
                {
                    maior = ano[cont];
                    indice = cont;
                }
                cont++;
            }

            return indice;
        }

        private int calcMaiorNome(string[] nome, int qtd)
        {
            int cont = 0;
            int indice = 0;
            double maior = nome[0].Length;

            while (cont < qtd)
            {
                if (nome[cont].Length >= maior)
                {
                    maior = nome[cont].Length;
                    indice = cont;
                }
                cont++;
            }

            return indice;
        }

        private int calcMenorNome(string[] nome, int qtd)
        {
            int cont = 0;
            int indice = 0;
            double menor = nome[0].Length;

            while (cont < qtd)
            {
                if (nome[cont].Length <= menor)
                {
                    menor = nome[cont].Length;
                    indice = cont;
                }
                cont++;
            }

            return indice;
        }
    }
}

