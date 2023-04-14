namespace AcademiaAtos_Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12) Escreva um programa que leia os valores de uma matriz 4x3,
            // e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

            int[,] matriz = new int[4, 3];
            Console.WriteLine("Digite os valores da matriz:");

            // Leitura dos valores da matriz
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nValores com soma dos índices par:");
            // Impressão dos valores com soma dos índices par
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}