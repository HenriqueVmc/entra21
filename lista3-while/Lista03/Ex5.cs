using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex5
    {
        public Ex5()
        {
            double n1 = 0;
            double n2 = 0;           

            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n --- MENU --- \n" +
                              "\n1- SOMA" +
                              "\n2- SUBTRAIR" +
                              "\n3- MULTIPLICAR" +
                              "\n4- DIVIDIR" +
                              "\n5- SAIR"+
                              "\nOpção: ");
            int op = 0;
            op = Convert.ToInt32(Console.ReadLine());

            while (op != 5)
            {
                if (op == 1)
                {
                    double somaNumeros = n1 + n2;
                    Console.WriteLine(somaNumeros);
                }
                else if (op == 2)
                {
                    double subtracaoNumeros = n1 - n2;
                    Console.WriteLine(subtracaoNumeros);
                }
                else if (op == 3)
                {
                    double multiplicacaoNumeros = n1 * n2;
                    Console.WriteLine(multiplicacaoNumeros);
                }
                else
                {
                    double divisaoNumeros = n1 / n2;
                    Console.WriteLine(divisaoNumeros);

                }
                break;
            }
        }
    }
}
