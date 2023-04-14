namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5) Leia duas matrizes 2x3 de números double. 
            // Imprima a soma destas duas matrizes.

            // Define as duas matrizes 2x3
            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];

            // Lê os valores da primeira matriz
            Console.WriteLine("Digite os valores da primeira matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Matriz 1 [{i},{j}]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Lê os valores da segunda matriz
            Console.WriteLine("Digite os valores da segunda matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Matriz 2 [{i},{j}]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Soma as duas matrizes
            double[,] matrizSoma = new double[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Imprime a matriz soma
            Console.WriteLine("Matriz soma:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrizSoma[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}