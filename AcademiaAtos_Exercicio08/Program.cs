namespace AcademiaAtos_Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

            int[,] matriz = new int[4, 4];

            // Lê os valores da matriz
            Console.WriteLine("Digite os valores da matriz:");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Matriz[{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Exibe os valores na ordem direta
            Console.WriteLine("\nValores da matriz na ordem direta:");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            // Exibe os valores na ordem inversa
            Console.WriteLine("\nValores da matriz na ordem inversa:");

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}