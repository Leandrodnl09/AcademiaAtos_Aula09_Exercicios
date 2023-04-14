namespace AcademiaAtos_Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos
            // da diagonal principal (da esquerda para a direita) são os mesmos da diagonal
            // secundária (direita pra esquerda).

            // Declarando uma matriz de ordem 5
            int[,] matriz = new int[5, 5];

            // Pedindo ao usuário para digitar os valores da matriz
            Console.WriteLine("Digite os valores da matriz:");

            // Loop para ler os valores da matriz
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Pedindo ao usuário para digitar o valor da posição (i,j)
                    Console.Write($"M[{i},{j}] = ");

                    // Lendo o valor da posição (i,j) e armazenando na matriz
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Variável para indicar se os elementos das diagonais são iguais
            bool diagonaisIguais = true;

            // Loop para comparar os elementos das diagonais principal e secundária
            for (int i = 0; i < 5; i++)
            {
                if (matriz[i, i] != matriz[4 - i, i])
                {
                    // Se algum elemento for diferente, as diagonais não são iguais
                    diagonaisIguais = false;
                    break;
                }
            }

            // Exibindo a matriz digitada pelo usuário
            Console.WriteLine("A matriz digitada foi:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            // Exibindo o resultado da comparação das diagonais
            if (diagonaisIguais)
            {
                Console.WriteLine("Os elementos das diagonais são iguais.");
            }
            else
            {
                Console.WriteLine("Os elementos das diagonais são diferentes.");
            }
        }
    }
}