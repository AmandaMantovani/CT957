using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma957
{
    public class Aula2
    {
        static void MainAula2(string[] args)
        {
            //DateTime dataHoje = new DateTime(2022, 11, 23, 19, 11, 30); //01/01/0001

            //Console.WriteLine(dataHoje);

            //DateTime dataAgora = DateTime.Now;

            //Console.WriteLine(dataAgora);

            //Console.WriteLine(dataHoje.Year);
            //dataHoje.ToShortDateString();
            //dataHoje.ToShortTimeString();

            //dataHoje.AddDays(-1);

            //Console.WriteLine(dataHoje.CompareTo(dataAgora));

            //Console.WriteLine("Digite seu nome:");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Digite sua idade");
            //int idade = int.Parse(Console.ReadLine());

            ////Concatenar
            //string frase1 = "Bem-vindo ao curso " + nome + ". Idade: " + idade;
            //Console.WriteLine(frase1);

            ////Format
            //string frase2 = string.Format("Bem-vindo ao curso {0}. Idade: {1}", nome, idade);
            //Console.WriteLine(frase2);

            ////Interpolar
            //string frase3 = $"Bem-vindo ao curso {nome}. Idade: {idade}";
            //Console.WriteLine(frase3);

            //Console.WriteLine("Digite");
            //decimal teste = decimal.Parse(Console.ReadLine());

            //Console.WriteLine(teste);

            //cast implicito
            decimal numero1 = 1;

            //cast explicito
            int numero2 = (int)20.6;
            Console.WriteLine(numero2);

            //convert
            numero2 = Convert.ToInt32("15");
            Console.WriteLine(numero2);

            numero1 = Convert.ToDecimal("15,9");
            Console.WriteLine(numero1);

            //parse
            numero2 = int.Parse("15");
            Console.WriteLine(numero2);

            bool converteu = int.TryParse("35", out numero2);

            Console.WriteLine(numero2);
            Console.WriteLine(converteu);

            bool converte = int.TryParse("-", out int numero3);

            Console.WriteLine(converte);
            Console.WriteLine(numero3);

            bool converteDate = DateTime.TryParse("23/11/2022", out DateTime dataAgora);

            numero1 = Math.Round(numero1, 2);

            Console.WriteLine(numero1.ToString("C"));

            string frase3 = $"Bem-vindo ao curso. Idade: {numero1:F2}";
        }
    }
}
