using System;
using System.Linq;
using Domain;

namespace Application
{
    public class ArvoreBuilder
    {
        public Node Construir(int[] array)
        {
            int raizValor = array.Max();
            int raizIndex = Array.IndexOf(array, raizValor);

            var raiz = new Node(raizValor);

            var esquerda = array
                .Take(raizIndex)
                .OrderByDescending(x => x);

            var direita = array
                .Skip(raizIndex + 1)
                .OrderByDescending(x => x);

            ConstruirGalhoEsquerdo(raiz, esquerda);
            ConstruirGalhoDireito(raiz, direita);

            return raiz;
        }

        private void ConstruirGalhoEsquerdo(Node raiz, IEnumerable<int> valores)
        {
            var atual = raiz;

            foreach (var valor in valores)
            {
                atual.Esquerda = new Node(valor);
                atual = atual.Esquerda;
            }
        }

        private void ConstruirGalhoDireito(Node raiz, IEnumerable<int> valores)
        {
            var atual = raiz;

            foreach (var valor in valores)
            {
                atual.Direita = new Node(valor);
                atual = atual.Direita;
            }
        }
    }
}
