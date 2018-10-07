using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1Entra21
{
    /*class Ex4
    {
        
         * 04:​ Solicitar o nome, idade e altura de quatro pessoas, apresentar no final:
        ➔ Média das idades:
        ➔ O nome da pessoa com a menor idade;
        ➔ O nome da pessoa com a maior idade;
        ➔ Média das alturas:
        ➔ O nome da pessoa com a maior altura;
        ➔ O nome da pessoa com a menor altura;
        ➔ O nome da pessoa com o maior nome.
        ➔ O nome da pessoa com o menor nome.
         * 
         

        int idade1 = 0, idade2 = 0, idade3 = 0, idade4 = 0, somaIdade = 0;
        double alt1 = 0, alt2 = 0, alt3 = 0, alt4 = 0;
        string nome1 = "", nome2 = "", nome3 = "", nome4 = "";

        public Ex4()
        {
            obterPessoas();
            Console.WriteLine("Média de Idades: " + mediaIdades());
            calcMaiorAndMenorIdade();
        }

        private void calcMaiorAndMenorIdade()
        {
            if (idade1 > idade2 && idade1 > idade3)
            {
                Console.WriteLine("--- Maior Idade ---\n");
                Console.WriteLine("\n--- Menor Salario ---\nNome: {0} - Salario {1}", nome2, salario2);
            }
            else if (salario1 < salario2)
            {
                Console.WriteLine("--- Maior Salario ---\nNome: {0} - Salario {1}", nome2, salario2);
                Console.WriteLine("\n--- Menor Salario ---\nNome: {0} - Salario {1}", nome1, salario1);

            }
            else
            {
                Console.WriteLine("Salários Iguais!");
            }
        }

        private double mediaIdades()
        {
            somaIdade = idade1 + idade2 + idade3 + idade4;

            return somaIdade / 4;
        }

        private void obterPessoas()
        {
            Console.WriteLine("Pessoa 1\n");
            Console.WriteLine("Nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura: ");
            alt1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pessoa 2\n");
            Console.WriteLine("Nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura: ");
            alt2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pessoa 3\n");
            Console.WriteLine("Nome: ");
            nome3 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura: ");
            alt3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pessoa 4\n");
            Console.WriteLine("Nome: ");
            nome4 = Console.ReadLine();
            Console.WriteLine("Idade: ");
            idade4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura: ");
            alt4 = Convert.ToInt32(Console.ReadLine());
        }
    }
    */
}
