using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1Entra21
{
    class Ex2
    {
        /*
         * 02:​ O objetivo desta questão é permitir o usuário digitar sua idade e de acordo com as sua idade
            apresentar a faixa etária do mesmo de acordo com os grupos abaixo:
            ➔ Criança: Até 09 anos;
            ➔ Pré-adolescência: Até 12 anos;
            ➔ Adolescência: Até 17 anos;
            ➔ Adulto:Até 59 anos;
            ➔ Idoso: Acima de 59 anos.
         *           
         */
        public Ex2()
        {
            Console.WriteLine(verificarFaixaEtaria(obterIdade()));
        }

        private string verificarFaixaEtaria(int idade)
        {
            string faixaEtaria = "";
            if (idade > 0)
            {
                if (idade <= 9)
                {
                    faixaEtaria = "\nCriança";
                }
                else if (idade <= 12)
                {
                   faixaEtaria = "\nAdolescente";
                }
                else if (idade <= 59)
                {
                    faixaEtaria = "\nAdulto";
                }
                else
                {
                    faixaEtaria = "\nIdoso";
                }
            }
            else
            {
                Console.WriteLine("\nIdade deve ser maior que zero");
            }
            return faixaEtaria;
        }

        private int obterIdade()
        {
            int idade = 0;
            try
            {
                Console.WriteLine("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade < 1 && idade > 140)
                {
                    Console.WriteLine("Idade deve ser Maior que 1 e menor que 140");
                    idade = obterIdade();
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine("Dados Inválidos");
                idade = obterIdade();
            }
            return idade;
        }
    }
}

