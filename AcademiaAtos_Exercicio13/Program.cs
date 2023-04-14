namespace AcademiaAtos_Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5)
            // e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
            // diagonal secundária.

            // Criação de uma matriz de ordem 5 (5x5) para armazenar os elementos digitados pelo usuário.
            int[,] matriz = new int[5, 5];
            Random numerosRandom = new Random();

            // Variáveis para armazenar a soma dos elementos da diagonal principal e diagonal secundária.
            int somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;

            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Leitura dos elementos da matriz e soma dos elementos das diagonais.
                    matriz[i, j] = numerosRandom.Next(1, 50); // comando para pacilitar o preenchimento com numeros randomicos
                    Console.WriteLine(matriz[i,j]);
                    // matriz[i, j] = int.Parse(Console.ReadLine()); // comando pro usuario digitar

                    if (i == j) // Diagonal principal
                    {
                        somaDiagonalPrincipal += matriz[i, j];
                    }
                    if (i + j == matriz.GetLength(0) - 1) // Diagonal secundária
                    {
                        somaDiagonalSecundaria += matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");

            // Comparação das somas das diagonais e exibição do resultado.
            if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é igual" +
                    " à soma dos elementos da diagonal secundária.");
            }
            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal é diferente" +
                    " da soma dos elementos da diagonal secundária.");
            }
        }
    }
}