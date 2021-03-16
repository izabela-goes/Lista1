using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex10
    {
        static void Main(string[] args)
        {
            float sal, medsal, medfilhos, percentual = 0;
            float maiorsal = 0;
            float totalfilhos = 0;
            float totalsal = 0;
            int numfilhos, qtdmenor150 = 0;
            

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Informe qual o seu salário: ");
                sal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o número de filhos: ");
                numfilhos = Convert.ToInt32(Console.ReadLine());


                totalfilhos = totalfilhos + numfilhos;
                totalsal = totalsal + sal;

                if (sal > maiorsal)
                {
                    maiorsal = sal;
                }
                  
                if (sal < 150)
                {
                    qtdmenor150 = qtdmenor150 + 1;
                }

            }

            medfilhos = totalfilhos / 4;
            medsal = totalsal / 4;
            percentual = qtdmenor150 * 100 / 4;

            Console.WriteLine("A média de salário da população é: " +medsal);
            Console.WriteLine("A média de filhos da população é: " + medfilhos);
            Console.WriteLine("O maior salário encontrado foi R$: " + maiorsal);
            Console.WriteLine("O percentual de pessoas com salário menor que R$150,00 foi de: " + percentual);

            Console.ReadKey();
        }
    }
}
