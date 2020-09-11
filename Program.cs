using System;
using estudos;

class Program
{
    static void Main(string[] args)
    {

        int valor1 = 10;
        int valor2 = 100;

        String palavra1 = "Hello";
        String palavra2 = "World!"; 

        Matematica profMatematica = new Matematica();        
        Console.WriteLine(profMatematica.trabalha(valor1, valor2));

        Portugues profPortugues = new Portugues();
        Console.WriteLine(profPortugues.trabalha(palavra1, palavra2));

        Historia profHistoria = new Historia();
        Console.WriteLine(profHistoria.trabalha(palavra1, palavra2));
        
    }
}
