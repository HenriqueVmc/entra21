using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1Entra21
{
    class Ex1
    {
        /* 
         * ➔ Valor recebido por hora;
           ➔ Quantidade de horas trabalhadas no mês vigente;
           ➔ Auxílio transporte;
           ➔ Auxílio alimentação;
           ➔ Desconto da contribuição do INSS;
           ➔ Desconto da contribuição sindical.
         * 
           Ao final deve-se apresentar o salário bruto e o salário líquido.
           Definição de salário bruto: É a remuneração mensal que um trabalhador recebe sem considerar os auxílios
           e descontos.
           Definição de salário líquido: É a remuneração mensal que um trabalhador recebe considerando os auxílios
           e descontos.
         * 
        */
        double salarioByHrs = 0, qtdHrsByMes = 0, auxAlimentacao = 0, auxTransporte = 0, inss = 0, roubo = 0;

        public Ex1(){

            obterValByHora();
            obterQtdHrsByMes();
            obterAuxilios();
            obterDescontos();
            calcSalarioLiquido();
            imprimirSalario();
        }

        private void imprimirSalario()
        {
            Console.WriteLine("\n--- Salario ---\n");
            Console.WriteLine("Salario Liquido: R$ "+ calcSalarioLiquido());
            Console.WriteLine("Salario Bruto: R$ "+ calcSalarioBruto());
        }
          
        public void obterValByHora()
        {
            try{
                Console.WriteLine("Valor Recebido por Hora: ");
                salarioByHrs = Convert.ToDouble(Console.ReadLine());

            }catch(Exception e1){
                Console.WriteLine("Dados Inválidos");
                obterValByHora();
            }
        }

        private void obterQtdHrsByMes()
        {
            try{
                Console.WriteLine("Quantidade de Horas trabalhadas(mês): ");
                qtdHrsByMes = Convert.ToDouble(Console.ReadLine());

            }catch(Exception e1){
                Console.WriteLine("Dados Inválidos");
                obterQtdHrsByMes();
            }
        }

        private void obterAuxilios()
        {
            try
            {
                Console.WriteLine("--- Informe o valor dos Benefícios ---\n");
                obterAuxTransporte();
                obterAuxAlimentacao();

            }
            catch (Exception e1)
            {
                Console.WriteLine("Dados Inválidos");
                obterAuxilios();
            }
        }

        private void obterAuxAlimentacao()
        {
            Console.WriteLine("Auxílio Alimentação: ");
            auxAlimentacao = Convert.ToDouble(Console.ReadLine());
        }

        private void obterAuxTransporte()
        {
            Console.WriteLine("Auxílio Transporte: ");
            auxTransporte = Convert.ToDouble(Console.ReadLine());
        }     

        private void obterDescontos()
        {
            try
            {
                Console.WriteLine("--- Informe o valor dos Descontos ---\n");
                obterInss();
                rouboSindical();

            }
            catch (Exception e1)
            {
                Console.WriteLine("Dados Inválidos");
                obterDescontos();
            }
        }

        private void obterInss()
        {
            Console.WriteLine("INSS: ");
            inss = Convert.ToDouble(Console.ReadLine());
        }

        private void rouboSindical()
        {
            Console.WriteLine("'Contribuição' Sindical: ");
            roubo = Convert.ToDouble(Console.ReadLine());
        }

        private double calcSalarioLiquido()
        {
            try
            {
                return ((salarioByHrs * qtdHrsByMes) - (inss + roubo)) + (auxAlimentacao + auxTransporte);
            }
            catch(Exception e2)
            {
                Console.WriteLine("Erro ao Calcular Salario.: "+e2.ToString());
            }
            return 0;
        }

        private double calcSalarioBruto()
        {
            return salarioByHrs * qtdHrsByMes;
        }
    }
}
