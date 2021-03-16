using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex13
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (n == 0) { 
            
            Console.WriteLine("Informe o valor de N:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Digite um valor maior ou diferente de 0!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            }
        }
    }
}
