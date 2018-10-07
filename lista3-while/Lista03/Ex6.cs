using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex6
    {
        int op, codigo, bolos, doces, sanduiches, pizzas;
        double valProduto1, valProduto2, valProduto3, valProduto4, valProduto5;
        double valProduto6, valProduto7, valProduto8, valProduto9, valProduto10;
        double valProduto11, valProduto12, valProduto13, valProduto14, valProduto15;                
        double valTotal;        

        public Ex6()
        {
            codigo = 0;
            valProduto1 = 29.50;
            valProduto2 = 2.00;
            valProduto3 = 29.23;
            valProduto4 = 7.10;
            valProduto5 = 19.33;
            valProduto6 = 17.71;
            valProduto7 = 4.82;
            valProduto8 = 21.16;
            valProduto9 = 12.70;
            valProduto10 = 19.70;
            valProduto11 = 28.22;
            valProduto12 = 6.98;
            valProduto13 = 0.42;
            valProduto14 = 16.36;
            valProduto15 = 27.50;
            op = 1;
            valTotal = 0;
            bolos = 0;
            doces = 0;
            sanduiches = 0;
            pizzas = 0;                        

            Console.WriteLine("\n1 - Nova Copra");
            Console.WriteLine("\n2 - Sair");
            op = Convert.ToInt32(Console.ReadLine());

            while (op == 1)
            {                
                try
                {
                    imprimirCardapio();
                    do
                    {
                        Console.WriteLine("\nInformme o código do produto: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        switch (codigo)
                        {
                            case 1:
                                valTotal += valProduto1;
                                bolos++;
                                break;
                            case 2:
                                valTotal += valProduto2;
                                bolos++;
                                break;
                            case 3:
                                valTotal += valProduto3;
                                bolos++;
                                break;
                            case 4:
                                valTotal += valProduto4;
                                bolos++;
                                break;
                            case 5:
                                valTotal += valProduto5;
                                bolos++;
                                break;
                            case 6:
                                valTotal += valProduto6;
                                doces++;
                                break;
                            case 7:
                                valTotal += valProduto7;
                                doces++;
                                break;
                            case 8:
                                valTotal += valProduto8;
                                sanduiches++;
                                break;
                            case 9:
                                valTotal += valProduto9;
                                sanduiches++;
                                break;
                            case 10:
                                valTotal += valProduto10;
                                sanduiches++;
                                break;
                            case 11:
                                valTotal += valProduto11;
                                sanduiches++;
                                break;
                            case 12:
                                valTotal += valProduto12;
                                pizzas++;
                                break;
                            case 13:
                                valTotal += valProduto13;
                                pizzas++;
                                break;
                            case 14:
                                valTotal += valProduto14;
                                pizzas++;
                                break;
                            case 15:
                                valTotal += valProduto15;
                                pizzas++;
                                break;
                            case 16:
                                Console.WriteLine("\nSaindo...");
                                break;
                            default:
                                Console.WriteLine("\nOpção Inválida!");
                                break;
                        }

                    } while (codigo != 16);

                    imprimirCompra();
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nErro.: " + e.ToString());
                }
                Console.WriteLine("\n1 - Nova Compra");
                Console.WriteLine("\n2 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
            }
        }       

        private void imprimirCompra()
        {
            Console.WriteLine("\n--- Produtos Comprados ---\n");
            Console.WriteLine("Bolos: "+bolos);
            Console.WriteLine("Doces: "+doces);
            Console.WriteLine("Sanduiches: "+sanduiches);
            Console.WriteLine("Pizzas: "+pizzas);
            Console.WriteLine("Valor da compra: R$"+valTotal);

            limparCompra();
        }

        private void limparCompra()
        {
            bolos = 0; doces = 0; sanduiches = 0; pizzas = 0; valTotal = 0;
        } 

        private void imprimirCardapio()
        {
            Console.WriteLine("\n--- CARDÁPIO DE PRODUTOS ---\n"+
                            "\nCódigo"+
                            "\n1      Bolos         Bolo Brigadeiro                                R$ 29,50" +
                            "\n2      Bolos         Bolo Floresta Negra                            R$2,00" +
                            "\n3      Bolos         Bolo leite com Nutella                         R$29,23" +
                            "\n4      Bolos         Mousse de chocolate                            R$7,10" +
                            "\n5      Bolos         Bolo Nega Maluca                               R$19,33" +
                            "\n6      Doces         Bomba de creme                                 R$17,71" +
                            "\n7      Doces         Bomba de morango                               R$4,82" +
                            "\n8      Sanduiches    File-Mignon com fritas e cheddar               R$21,16" +
                            "\n9      Sanduiches    Hambúrguer com Queijos, Champignon e rúcula    R$12,70" +
                            "\n10     Sanduiches    Provolone com salame                           R$19,70" +
                            "\n11     Sanduiches    Vegetariano de berinjela                       R$28,22" +
                            "\n12     Pizzas        Calabresa                                      R$6,98" +
                            "\n13     Pizzas        Napolitana                                     R$0,42" +
                            "\n14     Pizzas        Peruana                                        R$16,36" +
                            "\n15     Pizzas        Portuguesa                                     R$27,50" +
                            "\n\n16 - Sair");
        }
    }
}