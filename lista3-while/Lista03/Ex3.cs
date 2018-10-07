using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex3
    {
        public Ex3()
        {
            double peso = 0;
            int contP = 0;

            do
            {
                Console.WriteLine("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                contP++;

            } while ((peso < 0) || (peso < 300));

            Console.WriteLine("Quantidade de pessoas que informaram o peso: "+contP);
        }
    }
}
