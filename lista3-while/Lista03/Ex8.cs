using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex8
    {
        public Ex8(){
            
            Console.WriteLine("Informe a quantidade de caracteres"); 
            int qtd = Convert.ToInt32(Console.ReadLine());
            String texto ="";

            while(qtd > 0){

                Console.WriteLine("Caractere: ");
                char c = Convert.ToChar(Console.ReadLine());

                texto +=c;
                qtd--;
            }
            Console.WriteLine(texto);
        }
    }
}
