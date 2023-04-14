namespace AcademiaAtos_Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matrizSoma = new int[4, 4];

            //Lendo os valores da primeira matriz
            Console.WriteLine("Digite os valores da primeira matriz:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i}][{j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Lendo os valores da segunda matriz
            Console.WriteLine("\nDigite os valores da segunda matriz:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento: [{i}][{j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Somando as matrizes
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            //Mostrando a matriz resultante
            Console.WriteLine("\nMatriz resultante:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizSoma[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}