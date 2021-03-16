using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
        class Ex1
        {
            static void Main(string[] args)
            {
                int anos, meses, dias;

                Console.WriteLine("anos:");
                anos = int.Parse(Console.ReadLine());

                Console.WriteLine("meses:");
                meses = int.Parse(Console.ReadLine());

                Console.WriteLine("dias:");
                dias = int.Parse(Console.ReadLine());

                int diasvividos;

                diasvividos = (anos * 365) + (meses * 30) + dias;


                Console.WriteLine("Voce ja viveu {0} dias", diasvividos);

                Console.ReadKey();

            }
        }
}


