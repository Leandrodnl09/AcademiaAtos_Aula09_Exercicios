namespace AcademiaAtos_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            // Criando a matriz
            int[,] matriz = new int[4, 4];

            // Leitura dos valores da matriz
            Console.WriteLine("Digite os valores da matriz: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Digite a posição [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Mostrar a matriz
            Console.Write("  MATRIZ: ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"  {matriz[i,j]}   ");
                }

            }

            // Percorrer e escrever na tela a diagonal 
            Console.Write("\nOs valores da diagonal são: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{matriz[i, i]}   ");

            }
        }
    }
}