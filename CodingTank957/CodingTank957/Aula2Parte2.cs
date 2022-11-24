using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma957
{
    public class Aula2Parte2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            bool conversao = int.TryParse(Console.ReadLine(), out int numeroDigitado);

            // ! serve para negativar a condição
            // conversao == false

            if (!conversao)
            {
                Console.WriteLine("Valor digitado incorreto");
            }
            else if (numeroDigitado > 10)
            {
                Console.WriteLine("Número maior que 10");
            }
            else if (numeroDigitado == 10)
            {
                Console.WriteLine("Número é igual a 10");
            }
            else
            {
                Console.WriteLine("Número menor que 10");
            }
            /*
            * > maior
            * < menor
            * >= maior ou igual
            * <= menor ou igual
            * == igual
            * != diferente
            */

            bool? teste = null;

            if (teste == null || teste.HasValue || teste is null)
            {

            }

            /*
             * O Cinema Ada é uma franquia nacional e disponibiliza valor de meia entrada
             * nas seguintes condições:
            Estudante;
            Doador de sangue;
            Trabalhador da prefeitura e a prefeitura possui contrato firmado com o cinema.
            Realize um questionário S e N e exiba se a pessoa tem direito a meia entrada ou não.
            */

            Console.WriteLine("CINEMA ADA\n");
            Console.WriteLine("Responda S - Sim ou N - Não");
            Console.WriteLine("\nVocê é estudante?");

            if ((Console.ReadLine().ToUpper() == "S"))
            {
                Console.WriteLine("Uhuu!! Você tem direito a meia entrada!!!");
            }

            Console.WriteLine("\nVocê é doador de sangue?");
            if ((Console.ReadLine().ToUpper() == "S"))
            {
                Console.WriteLine("Uhuu!! Você tem direito a meia entrada!!!");
            }

            Console.WriteLine("\nVocê trabalha na prefeitura?");
            bool trabalhadorPrefeitura = (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("\nA prefeitura tem contrato com o cinema?");
            bool contratoPrefeitura = (Console.ReadLine().ToUpper() == "S");

            if (trabalhadorPrefeitura && contratoPrefeitura)
            {
                Console.WriteLine("Uhuu!! Você tem direito a meia entrada!!!");
            }
            else
            {
                Console.WriteLine("Que pena!! Você não tem direito a meia entrada!");
            }

            //bool estudanteLogico = false;
            //if (estudante == "S")
            //{
            //    estudanteLogico = true;
            //}
            //else
            //{
            //    estudanteLogico = false;
            //}
            //estudanteLogico = (estudante == "S");

            //string estud = (estudante == "S") ? "Sim" : "Não";

        }
    }
}
