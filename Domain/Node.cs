namespace Domain
{
    public class Node
    {
        public int Valor { get; }
        public Node Esquerda { get; set; }
        public Node Direita { get; set; }

        public Node(int valor)
        {
            Valor = valor;
        }
    }
}
