using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex7
    {
        int index;
        String[] nome;
        int[] idade, gols, cartaoAmarelo, cartaoVermelho;
        double[] peso, altura;
        char[] sexo;        

        public Ex7()
        {
            index = 0;
            nome = new String[22];
            idade = new int[22];
            gols = new int[22];
            cartaoAmarelo = new int[22];
            cartaoVermelho = new int[22];
            peso = new double[22];
            altura = new double[22];
            sexo = new char[22];
            int op = 0;

            do{
                
                Console.Write("\n1 - Cadastrar Novo Jogador");
                Console.Write("\n2 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
                
                if (op == 1)
                {
                    solicitarDados(index);
                    index++;            
                }                            

            }while(index < 22 && op == 1);

            imprimirEstatisticas(nome, idade, gols, peso, altura, sexo, cartaoAmarelo, cartaoVermelho, index);            
        }

        private void imprimirEstatisticas(String[] nome, int[] idade, int[] gols, double[] peso, double[] altura, char[] sexo, int[] cartaoA, int[] cartaoV, int index)
        {
            Console.WriteLine("\nMenor Peso: "+calcMenorPeso(peso, index));
            Console.WriteLine("\nMaior Altura: " + calcMaiorAlt(altura, index));            
            Console.WriteLine("\nMaior Nome: " + calcMaiorNome(nome, index));
            Console.WriteLine("\nQuantidade de Jogadoras: " + calcQtdJogadoras(sexo, index));
            Console.WriteLine("\nQuantidade de Jogadores: " + calcQtdJogadores(sexo, index));
            Console.WriteLine("\nJogador com menos Cartões Amarelos: " + nome[menosCartaoA(cartaoA, index)]);
            Console.WriteLine("\nMenor Nome: " + calcMenorNome(nome, index));
            Console.WriteLine("\nMaior Peso: " + calcMaiorPeso(peso, index));
            Console.WriteLine("\nJogador com mais Cartões Vermelhos: " + nome[maisCartaoV(cartaoV, index)]);
            Console.WriteLine("\nJogador com mais Cartões Amarelos: " + nome[maisCartaoA(cartaoA, index)]);
            Console.WriteLine("\nJogador com menos Cartões Vermelhos: " + nome[menosCartaoV(cartaoV, index)]);
        }

        private int menosCartaoV(int[] cartaoV, int index)
        {
            int cont = 0, i = 0;
            int menos = cartaoV[0];

            while (cont < index)
            {
                if (cartaoV[cont] <= menos)
                {
                    menos = cartaoV[cont];
                    i = cont;
                }
                cont++;
            }
            return i;
        }

        private int maisCartaoA(int[] cartaoA, int index)
        {
            int cont = 0, i = 0;
            int mais = cartaoA[0];

            while (cont < index)
            {
                if (cartaoA[cont] >= mais)
                {
                    mais = cartaoA[cont];
                    i = cont;
                }
                cont++;
            }
            return i;
        }

        private int maisCartaoV(int[] cartaoV, int index)
        {
            int cont = 0, i = 0;
            int mais = cartaoV[0];

            while (cont < index)
            {
                if (cartaoV[cont] >= mais)
                {
                    mais = cartaoV[cont];
                    i = cont;
                }
                cont++;
            }
            return i;
        }

        private double calcMaiorPeso(double[] peso, int index)
        {
            int cont = 0;
            double maior = peso[0];

            while (cont < index)
            {
                if (peso[cont] >= maior)
                {
                    maior = peso[cont];
                }
                cont++;
            }
            return maior;
        }

        private int calcMenorNome(string[] nome, int index)
        {
            int cont = 0;
            int menor = nome[0].Length;

            while (cont < index)
            {
                if (nome[cont].Length <= menor)
                {
                    menor = nome[cont].Length;
                }
                cont++;
            }
            return menor;
        }

        private int menosCartaoA(int[] cartaoA, int index)
        {
            int cont = 0, i = 0;
            int menos = cartaoA[0];

            while (cont < index)
            {
                if (cartaoA[cont] <= menos)
                {
                    menos = cartaoA[cont];
                    i = cont;
                }
                cont++;
            }
            return i;
        }

        private int calcQtdJogadoras(char[] sexo, int index)
        {
            int cont = 0;
            int qtd = 0;

            while (cont < index)
            {
                if (sexo[cont] == 'F')
                {
                    qtd++;
                }
                cont++;
            }
            return qtd;
        }

        private int calcQtdJogadores(char[] sexo, int index)
        {
            int cont = 0;
            int qtd = 0;

            while (cont < index)
            {
                if (sexo[cont] == 'M')
                {
                    qtd++;
                }
                cont++;
            }
            return qtd;
        }
        private int calcMaiorNome(string[] nome, int index)
        {
            int cont = 0;
            int maior = nome[0].Length;

            while (cont < index)
            {
                if (nome[cont].Length >= maior)
                {
                    maior = nome[cont].Length;
                }
                cont++;
            }
            return maior;
        }

        private double calcMaiorAlt(double[] altura, int index)
        {
            int cont = 0;
            double maior = altura[0];

            while (cont < index)
            {
                if (altura[cont] >= maior)
                {
                    maior = altura[cont];
                }
                cont++;
            }
            return maior;            
        }

        private double calcMenorPeso(double[] peso, int index)
        {
            int cont = 0;
            double menor = peso[0];

            while (cont < index)
            {
                if (peso[cont] <= menor)
                {
                    menor = peso[cont];
                }
                cont++;
            }
            return menor;
        }

        private void solicitarDados(int index)
        {
            try
            {
                Console.Write("Nome: ");
                nome[index] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[index] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Peso: ");
                peso[index] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sexo: ");
                sexo[index] = Convert.ToChar(Console.ReadLine()[0]);

                Console.Write("Altura: ");
                altura[index] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantidade de Gols: ");
                gols[index] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões Amarelos: ");
                cartaoAmarelo[index] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões Vermelhos: ");
                cartaoVermelho[index] = Convert.ToInt32(Console.ReadLine());
            }catch(Exception e){
                Console.WriteLine("Erro.: "+e.ToString());
            }
        }        
    }    
}


/*
                Console.Write("\n1 - Cadastrar Novo Jogador");
                Console.Write("\n2 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
*/