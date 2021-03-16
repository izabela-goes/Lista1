using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex3
    {
        static void Main(string[] args)
        {

            int percentualDistribuidor = 28;
            int percentualImposto = 45;

            Console.WriteLine("Informe o custo de fábrica: ");
            double valorCustoFabrica = Convert.ToDouble(Console.ReadLine());

            double custoPercentualDistribuidor = (valorCustoFabrica * percentualDistribuidor) / 100;
            double custoPercentualImposto = (valorCustoFabrica * percentualImposto) / 100;

            double valorTotalConsumidor = valorCustoFabrica + custoPercentualDistribuidor + custoPercentualImposto;

            Console.WriteLine(" O custo final ao consumidor é: R$ " + valorTotalConsumidor.ToString());

            Console.ReadKey();
        }
           
    }
}
