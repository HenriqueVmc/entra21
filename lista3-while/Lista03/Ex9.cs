using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex9
    {
        public Ex9(){
            
            Console.WriteLine("Informe o texto"); 
            String texto = Console.ReadLine();

            char c;
            int i = 0;
            int tam = texto.Length;

            while(tam > 0){

                Console.WriteLine("Caractere: "+ texto[i]);                
                i++;
                tam--;
            }

        }
    }
}
