using System;
using Domain;

namespace Infrastructure
{
    public static class ArvorePrinter
    {
        public static void Imprimir(Node no, int nivel = 0, string lado = "Raiz")
        {
            if (no == null) return;

            Console.WriteLine($"{new string(' ', nivel * 2)}{lado}: {no.Valor}");
            Imprimir(no.Esquerda, nivel + 1, "E");
            Imprimir(no.Direita, nivel + 1, "D");
        }
    }
}
