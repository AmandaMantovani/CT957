using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Exercicio_Codigo
    {
        static void MainCodigo(string[] args)
        {
            Console.Write("Digite um código (1, 2 ou 3): ");

            string codigo = Console.ReadLine();
            switch (codigo)
            {
                case "1":
                    Console.WriteLine("Um");
                    break;
                case "2":
                    Console.WriteLine("Dois");
                    break;
                case "3":
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
        }

        static void Main2Codigo(string[] args)
        {
            string codigo = "";
            while (codigo != "1" && codigo != "2" && codigo != "3")
            {
                Console.Write("Digite um código (1, 2 ou 3): ");
                codigo = Console.ReadLine();
            }

            switch (codigo)
            {
                case "1":
                    Console.WriteLine("Um");
                    break;
                case "2":
                    Console.WriteLine("Dois");
                    break;
                case "3":
                    Console.WriteLine("Três");
                    break;
            }
        }
    }
}
