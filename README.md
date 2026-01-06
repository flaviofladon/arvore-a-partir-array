# Construção de Árvore a partir de Array (C#)

Solução em C# organizada em camadas (Domain, Application, Infrastructure),
focada em clareza, separação de responsabilidades e preparo para entrevistas técnicas.

## Arquitetura

- **Domain**: modelo da árvore
- **Application**: lógica de construção
- **Infrastructure**: visualização / saída
- **Program**: ponto de entrada

## Regras

- Raiz = maior valor do array
- Galho esquerdo: valores à esquerda da raiz (ordem decrescente)
- Galho direito: valores à direita da raiz (ordem decrescente)

## Execução

https://dotnetfiddle.net/jY6p1n

```bash
dotnet run
