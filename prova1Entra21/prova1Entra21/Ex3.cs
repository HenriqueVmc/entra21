using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1Entra21
{
    class Ex3
    {
        /*         
           03:​ Ler o nome e o salário de dois funcionários e apresentar ao final:
           ➔ Nome e o salário do funcionário com o maior salário;
           ➔ Nome e o salário do funcionário com o menor salário.
        */

        double salario1 = 0, salario2 = 0;
        string nome1 = "", nome2 = "";
        public Ex3()
        {
            //Ñ PODE USAR FOR?
            obterFuncionario(1);
            obterFuncionario(2);
            calcMaiorAndMenorSalario();
        }

        private void calcMaiorAndMenorSalario()
        {
            if (salario1 > salario2)
            {
                Console.WriteLine("--- Maior Salario ---\nNome: {0} - Salario {1}", nome1, salario1);
                Console.WriteLine("\n--- Menor Salario ---\nNome: {0} - Salario {1}", nome2, salario2);
            }
            else if(salario1 < salario2)
            {
                Console.WriteLine("--- Maior Salario ---\nNome: {0} - Salario {1}", nome2, salario2);
                Console.WriteLine("\n--- Menor Salario ---\nNome: {0} - Salario {1}", nome1, salario1);
                
            }
            else
            {
                Console.WriteLine("Salários Iguais!");
            }
        }

        private void obterFuncionario(int f)
        {
            try
            {
                Console.WriteLine("--- Funcionário ---\n");
                if (f == 1)
                {                 
                    Console.WriteLine("Nome: ");
                    nome1 = Console.ReadLine();
                    Console.WriteLine("Salário: ");
                    salario1 = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Nome: ");
                    nome2 = Console.ReadLine();
                    Console.WriteLine("Salário: ");
                    salario2 = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch(Exception e){
                Console.WriteLine("Dados Inválidos");
            }
        }
    }
}
