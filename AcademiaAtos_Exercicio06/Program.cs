namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.

            Random random = new Random();
            int[,] matrix = new int[4, 4];

            // Preenche a matriz com valores aleatórios
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            // Imprime a matriz
            Console.WriteLine("Matriz gerada:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Determina o maior número da matriz
            int maxNumber = matrix[0, 0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] > maxNumber)
                    {
                        maxNumber = matrix[i, j];
                    }
                }
            }

            // Imprime o maior número da matriz
            Console.WriteLine("O maior número da matriz é: " + maxNumber);
        }
    }
}