using System;
using System.Collections.Generic;
using System.Linq;

// =====================================================
// Estrutura do nó da árvore
// =====================================================
public class Node
{
    public int Valor { get; set; }
    public Node Esquerda { get; set; }
    public Node Direita { get; set; }

    public Node(int valor)
    {
        Valor = valor;
    }
}

// =====================================================
// Classe responsável pela construção da árvore
// =====================================================
public class ArvoreBuilder
{
    public static Node ConstruirArvore(int[] array)
    {
        // Raiz = maior valor do array
        int raizValor = array.Max();
        int raizIndex = Array.IndexOf(array, raizValor);
        Node raiz = new Node(raizValor);

        // Elementos à esquerda e à direita da raiz
        var esquerda = array.Take(raizIndex).OrderByDescending(x => x);
        var direita = array.Skip(raizIndex + 1).OrderByDescending(x => x);

        // Construção do galho esquerdo
        Node atual = raiz;
        foreach (int valor in esquerda)
        {
            atual.Esquerda = new Node(valor);
            atual = atual.Esquerda;
        }

        // Construção do galho direito
        atual = raiz;
        foreach (int valor in direita)
        {
            atual.Direita = new Node(valor);
            atual = atual.Direita;
        }

        return raiz;
    }
}

// =====================================================
// Classe para impressão da árvore
// =====================================================
public class ArvorePrinter
{
    public static void Imprimir(Node no, int nivel = 0, string lado = "Raiz")
    {
        if (no == null) return;

        Console.WriteLine($"{new string(' ', nivel * 2)}{lado}: {no.Valor}");
        Imprimir(no.Esquerda, nivel + 1, "E");
        Imprimir(no.Direita, nivel + 1, "D");
    }
}

// =====================================================
// Programa principal
// =====================================================
public class Program
{
    public static void Main()
    {
        int[] array1 = { 3, 2, 1, 6, 0, 5 };
        Console.WriteLine("Cenário 1:");
        var arvore1 = ArvoreBuilder.ConstruirArvore(array1);
        ArvorePrinter.Imprimir(arvore1);

        Console.WriteLine();

        int[] array2 = { 7, 5, 13, 9, 1, 6, 4 };
        Console.WriteLine("Cenário 2:");
        var arvore2 = ArvoreBuilder.ConstruirArvore(array2);
        ArvorePrinter.Imprimir(arvore2);
    }
}
