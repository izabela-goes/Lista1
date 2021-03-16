using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex2
    {
        static void Main(string[] args)
        {
            float totaleleitores, votosbrancos, votosnulos, votosvalidos = 0;

            Console.WriteLine("Informe o total de eleitores do Município: ");
            totaleleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o total de votos brancos: ");
            votosbrancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o total de votos nulos: ");
            votosnulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o total de votos válidos: ");
            votosvalidos = Convert.ToInt32(Console.ReadLine());

            votosbrancos = 100 * votosbrancos / totaleleitores;
            votosnulos = 100 * votosnulos / totaleleitores;
            votosvalidos = 100 * votosvalidos / totaleleitores;

            Console.WriteLine("Porcentagem de votos brancos: " + votosbrancos + "%");
            Console.WriteLine("Porcentagem de votos nulos: " + votosnulos + "%");
            Console.WriteLine("Porcentagem de votos válidos: " + votosvalidos + "%");

            Console.ReadKey();
        }

    }
}
