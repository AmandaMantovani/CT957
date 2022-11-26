using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Aula3Parte1
    {
        static void Maina3p1(string[] args)
        {
            /*
             * Faça um programa que solicite a quantidade em anos
             * que uma pessoa possui experiencia em programação.
             * Classifique a resposta conforme abaixo: 
                0 anos de experiencia: Inexperiente
                1-2 anos de experiencia: Iniciante
                3-5 anos de experiencia: Intermediario
                mais de 5 anos de experiencia: Avançado
            */
            Console.WriteLine("Quantos anos de experiencia?");
            int.TryParse(Console.ReadLine(), out int anosExperiencia);

            switch (anosExperiencia)
            {
                case 0:
                    Console.WriteLine("Sem experiencia");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Iniciante");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Intermediario");
                    break;
                default:
                    Console.WriteLine("Avançado");
                    break;
            }

            string mensagem;
            switch (anosExperiencia)
            {
                case 0:
                    mensagem = "Sem experiencia";
                    break;
                case int i when i > 0 && i <= 2:
                    mensagem = "Iniciante";
                    break;
                case int i when i > 2 && i <= 5:
                    mensagem = "Intermediario";
                    break;
                default:
                    mensagem = "Avançado";
                    break;
            }
            Console.WriteLine(mensagem);

            mensagem = anosExperiencia switch
            {
                int i when i == 0 => "Sem experiencia",
                int i when i > 0 && i <= 2 => "Iniciante",
                int i when i is > 2 and <= 5 => "Intermediario",
                _ => "Avançado"
            };
            Console.WriteLine(mensagem);

            mensagem = anosExperiencia switch
            {
                0 => "Sem experiencia",
                > 0 and <= 2 => "Iniciante",
                > 2 and <= 5 => "Intermediario",
                _ => "Avançado"
            };
            Console.WriteLine(mensagem);

        }
    }
}
