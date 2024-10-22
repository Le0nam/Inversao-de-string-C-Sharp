using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao_de_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            do
            {
                Console.WriteLine("Digite a palavra a ser invertida\n");
                string entrada = Console.ReadLine();

                string invertida = "";

                for (int i = entrada.Length - 1; i >= 0; i--)
                {
                    invertida += entrada[i];
                }

                Console.WriteLine("\nString original: " + entrada);
                Console.WriteLine("String invertida: " + invertida);

                Console.WriteLine("\n\nDigite 0 para fechar\n");
                valor = Convert.ToInt32(Console.ReadLine());

            } while (valor != 0);
        }
    }
}
