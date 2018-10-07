using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex4
    {
        public Ex4()
        {
            int qtdCarros = 0;
            string modelo = "";
            int anoCarro = 0;
            double valCarro = 0;
            int somaAnoCarro = 0;
            double somaValCarro = 0;
            int carrosG = 0;
            int carrosA = 0;         
            int cont = 0;

            Console.WriteLine("Informe a quanidade de carros que deseja cadastrar: ");
            qtdCarros = Convert.ToInt32(Console.ReadLine());

            while (qtdCarros > cont)
            {
                Console.WriteLine("\nModelo: ");
                modelo = Console.ReadLine();

                Console.WriteLine("Valor: ");
                valCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ano do carro: ");
                anoCarro = Convert.ToInt32(Console.ReadLine());                

                somaAnoCarro += anoCarro;
                somaValCarro += valCarro;

                if (modelo[0] == 'g' || modelo[0] == 'G')
                {
                    carrosG++;
                }
                else if (modelo[0] == 'a' || modelo[0] == 'A')
                {
                    carrosA++;
                }
                cont++;
            }


            double mediaAnoCarro = somaAnoCarro / qtdCarros;
            double mediaValCarro = somaValCarro / qtdCarros;

            Console.WriteLine("\nMédia do ano dos carros: " + mediaAnoCarro +
                              "\nMédia do valor dos carros: " + mediaValCarro +
                              "\nQuantidade de carros que começam com a letra G: " + carrosG +
                              "\nQuantidade de carros que começam com a letra A: " + carrosA);
        }
    }
}
