using System;

class Aula1
{
    static void MainAula1()
    {
        Console.WriteLine("Hello, World");

        //tipo nome = valor;

        int valorInteiro = 15;

        Console.WriteLine(valorInteiro);

        valorInteiro = 20;

        Console.WriteLine("Variavel alterada: ");
        Console.WriteLine(valorInteiro);

        long valorLong = 10L;

        //VALORES DECIMAIS
        float valorFloat = 10.4F;

        double valorDouble = 11.78D;

        double valorDouble2 = 12.20;

        decimal valorDecimal = 15.84M;

        valorFloat = 99.99F;

        valorDouble = 10;

        //VALOR TEXTO
        char valorChar = 'A';

        string valorString = "Frase completa e quase infinita";

        //VALOR LOGICO
        bool valorBoolean = false;

        Console.WriteLine(valorBoolean);
    }
}