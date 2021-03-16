using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Ex14
    {
		public static void Main()
		{
			int i, qtd = 0;
			int soma = 0;
			float media = 0;

			for (i = 15; i <= 100; i++)
			{
				soma = soma + i;
				qtd++;
			}

			media = soma / qtd;
			Console.WriteLine("A média dos números inteiros é: " + media);

		}
	}
}
