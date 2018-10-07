using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex14
    {
         public Ex14(){             
                          
             Console.Write("Digite um número: ");
             int num = Convert.ToInt32(Console.ReadLine());
             int fat = 1;
             while (num > 0)
             {
                 int aux = num;
                 fat *= num;
                 num--;
             }

             Console.WriteLine("Fatorial: "+fat);
        }
    }
}
