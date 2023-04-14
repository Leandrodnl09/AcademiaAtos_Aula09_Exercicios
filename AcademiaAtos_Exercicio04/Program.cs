using System.Reflection;

namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    4) Popule uma matriz 5x5 e informe:
            //    - Quantos números são pares
            //    - Quantos números são impares
            //    - Quantos números são positivos
            //    - Quantos números são negativos
            //    - Quantos zeros existem!

            // Declarar a matriz
            int[,] matriz = new int[5, 5];
            // declaração de variaveis
            int numerosPares = 0, numerosImpares = 0, numerosPositivos = 0, numerosNegativos = 0, numerosZeros = 0;

            Console.WriteLine("Preencha os valores da matriz: ");
            
            // preenchendo a matriz
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Valores [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] % 2 == 0)
                    {
                        numerosPares++;
                    }
                    else
                        numerosImpares++;
                    
                    if (matriz[i, j] > 0)
                    {
                        numerosPositivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        numerosNegativos++;
                    }
                    else
                    {
                        numerosZeros++;
                    }
                }
            }
            // Escrever na tela
            Console.WriteLine($"A quantidade de numeros pares são: {numerosPares}!");
            Console.WriteLine($"A quantidade de numeros impares são: {numerosImpares}!");
            Console.WriteLine($"A quantidade de numeros negativos são: {numerosNegativos}!");
            Console.WriteLine($"A quantidade de numeros positivos são: {numerosPositivos}!");
            Console.WriteLine($"A quantidade de numeros 0 são: {numerosZeros}!");
        }
    }
}