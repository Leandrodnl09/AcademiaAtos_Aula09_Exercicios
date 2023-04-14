namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
            // A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matriz = new int[5, 3];

            // pede para o usuário preencher a primeira coluna da matriz
            Console.WriteLine("Preencha a primeira coluna da matriz:");
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }

            // executa um loop para percorrer a matriz e realizar as operações
            for (int i = 0; i < 5; i++)
            {
                // soma 10 à primeira coluna e armazena na segunda coluna
                matriz[i, 1] = matriz[i, 0] + 10;
                // armazena o dobro da primeira coluna na terceira coluna
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            // imprime a matriz resultante na tela
            Console.WriteLine("\nMatriz resultante:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}