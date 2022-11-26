using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Aula3Parte3
    {
        static void Maina3p3(string[] args)
        {
            // Programa que calcula a idade média de um grupo de pessoas.
            // A finalização da entrada de números é dada por um -1
            // Se a idade for menor que 18, não utilize na média.

            long somaIdades = 0;
            int quantidadePessoas = 0;
            int idade = 0;

            do
            {
                Console.WriteLine("Digite -1 para calcular a média e encerrar o programa");
                Console.WriteLine("Digite a idade da pessoa");
                int.TryParse(Console.ReadLine(), out idade);

                if (idade >= 18)
                {
                    somaIdades += idade;
                    quantidadePessoas++;
                }

            } while (idade != -1);

            decimal mediaIdades = (decimal) somaIdades / quantidadePessoas;
            Console.WriteLine($"A média de idades das pessoas é {mediaIdades}");

            /*
             * 
            while (idade != -1)
            {
                Console.WriteLine("Digite -1 para calcular a média e encerrar o programa");
                Console.WriteLine("Digite a idade da pessoa");
                int.TryParse(Console.ReadLine(), out idade);

                if (idade >= 18)
                {
                    somaIdades += idade;
                    quantidadePessoas++;
                }

            }
            */
        }
    }
}
