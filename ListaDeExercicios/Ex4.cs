using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex4
    {
        static void Main(string[] args)
        {
           
            int percentualGanhoValorVenda = 5;

            Console.WriteLine("Digite o total de carros vendidos:");
            int totalCarrosVendidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor total das vendas:");
            double ValorTotalVendas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite  o salario fixo do Revendedor:");
            double salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor por carro vendido:");
            double ValorPagoCarroVendido = Convert.ToDouble(Console.ReadLine());

           
            double salarioFinal = salarioFixo + (totalCarrosVendidos * ValorPagoCarroVendido) + ((ValorTotalVendas * percentualGanhoValorVenda) / 100);

            string valorArredondado = Math.Round(salarioFinal, 2).ToString();

            Console.WriteLine("O salario do Funcionário é: R$" + valorArredondado);

            Console.ReadKey();
        }
        
    }
}
