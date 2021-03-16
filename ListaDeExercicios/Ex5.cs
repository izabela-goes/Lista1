using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex5
    {
        static void Main(string[] args)
        {
            decimal alturaUsuario, pesoIdeal;
            string sexo;
            bool alturaValida;

            Console.Write("Digite sua altura em (Metros):");
            alturaValida = decimal.TryParse(Console.ReadLine(), out alturaUsuario);

            if (!alturaValida)
            {
                Console.WriteLine("O valor digitado não corresponde a um valor numérico.");
                Environment.Exit(1);
            }

            Console.Write("Digite o sexo [M]asculino / [F]eminino:");
            sexo = Console.ReadKey().KeyChar.ToString().ToUpper();


            if (sexo.Equals("M"))
            {
                pesoIdeal = alturaUsuario * 72.7m - 58m;
                Console.WriteLine($"\n\nSeu peso ideal é {pesoIdeal:N1}kg.");
            }
            else if (sexo.Equals("F"))
            {
                pesoIdeal = alturaUsuario * 62.1m - 44.7m;
                Console.WriteLine($"\n\nSeu peso ideal é {pesoIdeal:N1}kg.");
            }
            else
            {
                Console.WriteLine($"\n\nO valor digitado ({sexo}) não é um sexo válido");
            }

            Console.ReadKey();
        }
    }

}
