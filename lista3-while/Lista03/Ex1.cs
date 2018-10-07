using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista03
{
    class Ex1
    {
        public Ex1()
        {
            String nome;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
            }while (nome.ToLower() != "fim");
        }
    }
}
