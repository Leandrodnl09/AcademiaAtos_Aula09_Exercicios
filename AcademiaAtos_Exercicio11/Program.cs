namespace AcademiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11) Leia uma matriz A de tipo double de dimenção 3x3,
            // crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            // Criação das matrizes A e B
            double[,] A = new double[3, 3];
            double[,] B = new double[3, 3];
            double sumIndices = 0.0;

            Console.WriteLine("Digite os elementos da matriz A:");

            // Loop para leitura dos elementos da matriz A
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    A[i, j] = double.Parse(Console.ReadLine());
                    sumIndices += i + j; // Cálculo da soma dos índices
                }
            }

            Console.WriteLine("\nMatriz A:");

            // Loop para exibir a matriz A
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSoma dos índices: " + sumIndices);

            Console.WriteLine("\nMatriz B:");

            // Loop para calcular e exibir a matriz B
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = A[i, j] / sumIndices; // Cálculo da matriz B
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}