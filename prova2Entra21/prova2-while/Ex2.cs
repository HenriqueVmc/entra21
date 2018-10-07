using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Questão 02:​ A empresa que vende computadores quer cadastrar os seus clientes, para tal deve-se solicitar
    as seguintes informações abaixo enquanto o nome não for fim:
    ➔ Quantidade de peças;
    ➔ Valor total da compra;
    Ao final deve-se apresentar:
    ➔ Quantidade de vendas realizadas;
    ➔ Valor total de todas as compras;
    ➔ Média do total de todas as compras;
    ➔ Quantidade de peças do pedido com mais peças;
    ➔ Quantidade de peças do pedido com menos peças; 
 */
namespace prova2_while
{
    class Ex2
    {
        String[] nome;
        int[] qtdPecas;
        double[] valCompra;
        int index, aux=0;

        public Ex2()
        {
            cadastrarCompra();            
        }

        private void cadastrarCompra()
        {
            nome = new String[100];
            qtdPecas = new int[100];
            valCompra = new double[100];
            index = 0;

            do
            {                
                aux = index;
                Console.WriteLine("\n-- Cadastro de Compra --\n");
                Console.WriteLine("Cliente: ");
                nome[index] = Console.ReadLine();
              
                if (nome[index].ToString().ToLower() != "fim") {
                    Console.WriteLine("Quantidade de peças: ");
                    qtdPecas[index] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor Total da Compra: ");
                    valCompra[index] = Convert.ToDouble(Console.ReadLine());
                    index++;          
                }                              

            } while (nome[aux].ToString().ToLower() != "fim" && index < 100);

            imprimir(nome, qtdPecas, valCompra, index);
        }

        private void imprimir(string[] nome, int[] qtdPecas, double[] valCompra, int index)
        {
            imprimirQtdVendas(qtdPecas, index);
            imprimirValorTotalCompras(valCompra, index);
            imprimirMediaValorTotalCompras(index);
            imprimirPedidoComMaisPecas(qtdPecas, index);
            imprimirPedidoComMenosPecas(qtdPecas, index);
        }

        private void imprimirPedidoComMenosPecas(int[] qtdPecas, int index)
        {
            int cont = 0;
            int indice = 0;
            int menor = qtdPecas[0];

            while (cont < index)
            {
                if (qtdPecas[cont] <= menor)
                {
                    menor = qtdPecas[cont];
                    indice = cont;
                }
                cont++;
            }

            Console.WriteLine("\n--- Pedido Com Menor Quantidade de Pecas ---\n");
            Console.WriteLine("\nCliente: " + nome[indice]);
            Console.WriteLine("\nPeças: " + qtdPecas[indice]);
        }

        private void imprimirPedidoComMaisPecas(int[] qtdPecas, int index)
        {
            int cont = 0;
            int indice = 0;
            int maior = qtdPecas[0];

            while (cont < index)
            {
                if (qtdPecas[cont] >= maior)
                {
                    maior = qtdPecas[cont];
                    indice = cont;
                }
                cont++;
            }

            Console.WriteLine("\n--- Pedido Com Maior Quantidade de Pecas ---\n");
            Console.WriteLine("\nCliente: "+nome[indice]);
            Console.WriteLine("\nPeças: " + qtdPecas[indice]);
        }

        private void imprimirMediaValorTotalCompras(int index)
        {
            Console.WriteLine("\nMédia total de todas as Compras: " + (calcValorTotalCompras(index) / index));
        }

        private void imprimirValorTotalCompras(double[] valCompra, int index)
        {

            Console.WriteLine("\nValor total de todas as Compras: " + calcValorTotalCompras(index));
        }

        private double calcValorTotalCompras(int index){
            
            int cont = 0;
            double somaVal = 0;

            while (cont < index)
            {
                somaVal += valCompra[cont];
                cont++;
            }
            
            return somaVal;
        }
        private void imprimirQtdVendas(int[] qtdPecas, int index)
        {
            int cont = 0;
            int somaQtd = 0;
            
            while (cont < index)
            {
                somaQtd += qtdPecas[cont];
                cont++;
            }

            Console.WriteLine("\nQuantidade de Vendas: " + somaQtd);
        }
    }
}
