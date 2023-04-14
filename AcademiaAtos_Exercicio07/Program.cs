namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C,
            // onde cada elemento de C é a subtração do elemento correspondente de A com B.

            // Declaração das matrizes A, B e C com tamanho 3x3
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];

            // Leitura dos valores da matriz A
            Console.WriteLine("Digite os valores da matriz A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("A[{0},{1}]: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Leitura dos valores da matriz B
            Console.WriteLine("\nDigite os valores da matriz B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("B[{0},{1}]: ", i, j);
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Cálculo da matriz C, subtraindo os elementos correspondentes de A e B
            Console.WriteLine("\nMatriz C:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                    Console.Write("{0} ", C[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}