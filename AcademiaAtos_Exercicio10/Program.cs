namespace AcademiaAtos_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
            // em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            int[,] matrizA = new int[4, 4]; // Declaração da matriz A
            int[,] matrizB = new int[4, 4]; // Declaração da matriz B

            // Leitura da matriz A
            Console.WriteLine("Digite os elementos da matriz A:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine()); // Leitura dos elementos da matriz A
                }
            }

            // Leitura da matriz B
            Console.WriteLine("Digite os elementos da matriz B:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine()); // Leitura dos elementos da matriz B
                }
            }

            // Cálculo da média dos elementos das matrizes
            int soma = 0; // Variável para armazenar a soma dos elementos
            int quantidade = 0; // Variável para armazenar a quantidade de elementos
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += matrizA[i, j] + matrizB[i, j]; // Soma dos elementos das matrizes
                    quantidade += 2; // Incremento da quantidade de elementos
                }
            }
            double media = (double)soma / quantidade; // Cálculo da média
            Console.WriteLine($"Média dos elementos: {media:F2}"); // Exibição da média com duas casas decimais

            // Contagem de elementos abaixo, acima e na média
            int abaixo = 0; // Variável para armazenar a quantidade de elementos abaixo da média
            int acima = 0; // Variável para armazenar a quantidade de elementos acima da média
            int igual = 0; // Variável para armazenar a quantidade de elementos iguais à média
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrizA[i, j] + matrizB[i, j] < media * 2) // Verifica se o elemento está abaixo da média
                    {
                        abaixo++;
                    }
                    else if (matrizA[i, j] + matrizB[i, j] > media * 2) // Verifica se o elemento está acima da média
                    {
                        acima++;
                    }
                    else // O elemento está na média
                    {
                        igual++;
                    }
                }
            }
            Console.WriteLine($"Abaixo da média: {abaixo}"); // Exibição da quantidade de elementos abaixo da média
            Console.WriteLine($"Acima da média: {acima}"); // Exibição da quantidade de elementos acima da média
        }
    }
}