using System;
using Application;
using Infrastructure;

class Program
{
    static void Main()
    {
        var builder = new ArvoreBuilder();

        Console.WriteLine("Cenário 1:");
        int[] array1 = { 3, 2, 1, 6, 0, 5 };
        var arvore1 = builder.Construir(array1);
        ArvorePrinter.Imprimir(arvore1);

        Console.WriteLine();

        Console.WriteLine("Cenário 2:");
        int[] array2 = { 7, 5, 13, 9, 1, 6, 4 };
        var arvore2 = builder.Construir(array2);
        ArvorePrinter.Imprimir(arvore2);
    }
}
