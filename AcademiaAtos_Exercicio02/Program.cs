namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2) Solicite ao usuário, preencher uma Matriz 3x3

            //     Informe ao usuário:
            //  *A soma dos elementos de cada linha

            //    -Ex: Linha 1: 30

            //         Linha 2: 17
            // * A soma dos elementos de cada coluna

            //    -Ex: Coluna 1: 23

            //         Coluna 2: 36

            int[,] matriz = new int[3, 3];

            // Solicita ao usuário preencher a matriz
            Console.WriteLine("Por favor, preencha a matriz 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Digite o valor para a posição [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Soma dos elementos de cada linha
            Console.WriteLine("\nSoma dos elementos de cada linha:");
            for (int i = 0; i < 3; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < 3; j++)
                {
                    somaLinha += matriz[i, j];
                }
                Console.WriteLine("Linha {0}: {1}", i + 1, somaLinha);
            }

            // Soma dos elementos de cada coluna
            Console.WriteLine("\nSoma dos elementos de cada coluna:");
            for (int j = 0; j < 3; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < 3; i++)
                {
                    somaColuna += matriz[i, j];
                }
                Console.WriteLine("Coluna {0}: {1}", j + 1, somaColuna);
            }
        }
    }
}