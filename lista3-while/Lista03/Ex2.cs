using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex2
    {
        public Ex2()
        {
            int idade = 0;

            do
            {
                Console.WriteLine("Informe uma Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

            } while (idade <= 128);

        }
    }
}
