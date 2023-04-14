namespace AcademiaAtos_Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            // Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

            // Declaração da matriz original 3x4
            int[,] matrizOriginal = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            // Declaração da matriz transposta 4x3
            int[,] matrizTransposta = new int[4, 3];

            // Loop para percorrer as linhas da matriz original
            for (int i = 0; i < 3; i++)
            {
                // Loop para percorrer as colunas da matriz original
                for (int j = 0; j < 4; j++)
                {
                    // Atribuição dos valores da matriz original para a matriz transposta
                    matrizTransposta[j, i] = matrizOriginal[i, j];
                }
            }

            // Impressão da matriz original
            Console.WriteLine("Matriz Original:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizOriginal[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Impressão da matriz transposta
            Console.WriteLine("Matriz Transposta:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizTransposta[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}