using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Exercicio_Media
    {
        static void MainMedia(string[] args)
        {
            /*
             * Escreva um programa que leia quatro notas escolares de um aluno
             * e apresentar uma mensagem que o aluno foi aprovado
             * se o valor da média escolar for maior ou igual a 7.
             * Se o valor da média for menor que 7, solicitar a nota do recuperação,
             * somar com o valor da média e obter a nova média.
             * Se a nova média for maior ou igual a 7,
             * apresentar uma mensagem informando que o aluno foi aprovado na recuperação.
             * Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição.
             * Apresentar junto com as mensagens o valor da média do aluno.
             */

            decimal media = 0;
            decimal nota;
            bool validaNota;

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    Console.WriteLine($"Informe a {i + 1}ª nota do aluno");
                    validaNota = decimal.TryParse(Console.ReadLine(), out nota);
                } while (!validaNota || nota > 10 || nota < 0);

                media += nota;
            }

            media = media / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Aprovado! sua média é {media}");
            }
            else
            {
                Console.WriteLine("Informe a nota da recuperação");
                decimal.TryParse(Console.ReadLine(), out decimal notaRecuperacao);
                media += notaRecuperacao;
                media = media / 2;
                if (media >= 7)
                {
                    Console.WriteLine($"Aprovado! sua média é {media}");
                }
                else
                {
                    Console.WriteLine($"Não foi dessa vez! sua média é {media}");
                }
            }
        }
    }
}
