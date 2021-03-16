using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex7
    {
        static void Main(string[] args)
        {
            int v1, v2, v3 = 0;

            Console.WriteLine("Digite valores diferentes! ");

            Console.WriteLine("Informe o valor 1: ");
            v1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Informe o valor 2: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            if (v2 == v1)
            {
                Console.WriteLine("Informe um valor diferente: ");
                v2 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Informe o valor 3: ");
            v3 = Convert.ToInt32(Console.ReadLine());

            if ((v3 == v1) || (v3 == v2))
            {
                Console.WriteLine("Informe um valor diferente: ");
                v3 = Convert.ToInt32(Console.ReadLine());
            }

            if (v1 > v2 & v1 > v3)
            {
                Console.WriteLine("Maior valor é: " + v1);
            }
            else if (v2 > v1 & v2 > v3)
            {
                Console.WriteLine("Maior valor é: " + v2);
            }
            else
            {
                Console.WriteLine("Maior valor é: " + v3);
            }

            Console.ReadKey();
        }
    }
}