using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex8
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;

            Console.WriteLine("___FORMANDO TRIÂNGULO___");

            Console.WriteLine("Informe o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine(" ");
                Console.Write("Formam triângulo!");
            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("Não formam triângulo!");
            }

            Console.ReadKey();
        }
    }
}
