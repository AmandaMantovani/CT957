using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTank957
{
    public class Aula3Parte2
    {
        static void Maina3p2(string[] args)
        {
            //int[] vetorInteiro;
            //vetorInteiro = new int[5];

            //int[] vetorInteiro2 = new int[5];

            //vetorInteiro[0] = 10;
            //vetorInteiro[1] = 15;
            //vetorInteiro[2] = 20;
            //vetorInteiro[3] = 25;
            //vetorInteiro[4] = 30;

            //int[] vetorInteiro3 = new int[5] { 10, 15, 20, 25, 30 };
            //int[] vetorInteiro4 = { 10, 15, 20, 25, 30 };

            //vetorInteiro3[3] = 50;


            //Console.WriteLine("Digite a nota 1 do aluno:");
            //decimal.TryParse(Console.ReadLine(), out notasAluno[0]);

            //Console.WriteLine("Digite a nota 2 do aluno:");
            //decimal.TryParse(Console.ReadLine(), out notasAluno[1]);

            //Console.WriteLine("Digite a nota 3 do aluno:");
            //decimal.TryParse(Console.ReadLine(), out notasAluno[2]);

            //Console.WriteLine("Digite a nota 4 do aluno:");
            //decimal.TryParse(Console.ReadLine(), out notasAluno[3]);

            //decimal mediaFinal = (notasAluno[0] + notasAluno[1] + notasAluno[2] + notasAluno[3]) / notasAluno.Length;

            //Console.WriteLine($"\n\nMédia final do aluno {mediaFinal}");

            decimal[] notasAluno = new decimal[4];

            //for (inicialização; condição; incremento/decremento)
            for (int contador = 0; contador < notasAluno.Length; contador++)
            {
                Console.WriteLine($"Valor contador: {contador}");
                Console.WriteLine("Digite a nota do aluno");
                decimal.TryParse(Console.ReadLine(), out notasAluno[contador]);
            }

            foreach (decimal nota in notasAluno)
            {
                Console.WriteLine($"Nota do aluno {nota}");
            }

        }
    }
}
