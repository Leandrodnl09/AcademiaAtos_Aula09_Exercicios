namespace AcademiaAtos_Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas
            // e escreva o elemento mini e max, ou seja, o menor elemento da linha onde se encontra o 
            // maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            // declaração das variaveis
            int[,] matriz = new int[10, 10];
            int maximo = int.MinValue;
            int linhaDoMaximo = 0;
            int minimo = int.MaxValue;
            int linhaDoMinimo = 0;

            // leitura da matriz
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Digite o elemento [{0}, {1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    // atualiza o máximo e a linha onde foi encontrado
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                        linhaDoMaximo = i;
                    }

                    // atualiza o mínimo e a linha onde foi encontrado
                    if (matriz[i, j] < minimo)
                    {
                        minimo = matriz[i, j];
                        linhaDoMinimo = i;
                    }
                }
            }

            // encontra o menor elemento da linha do máximo
            int minimoDaLinhaDoMaximo = int.MaxValue;
            int colunaDoMinimoDaLinhaDoMaximo = 0;
            for (int j = 0; j < 10; j++)
            {
                if (matriz[linhaDoMaximo, j] < minimoDaLinhaDoMaximo)
                {
                    minimoDaLinhaDoMaximo = matriz[linhaDoMaximo, j];
                    colunaDoMinimoDaLinhaDoMaximo = j;
                }
            }

            // exibe os resultados
            Console.WriteLine("Máximo: {0}, encontrado na linha {1}, coluna {2}", maximo, linhaDoMaximo, colunaDoMinimoDaLinhaDoMaximo);
            Console.WriteLine("Mínimo: {0}, encontrado na linha {1}, coluna {2}", minimoDaLinhaDoMaximo, linhaDoMaximo, colunaDoMinimoDaLinhaDoMaximo);
        }
    }
}