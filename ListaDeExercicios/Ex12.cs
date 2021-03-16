using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex12
    {
        static void Main(string[] args)
        {
            float numero = 0;
            float soma = 0;

            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("Informe um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma = soma + numero;

            }

            Console.WriteLine("A soma total dos números lidos é: " +soma);

            Console.ReadKey();
        }
     
    }

}
