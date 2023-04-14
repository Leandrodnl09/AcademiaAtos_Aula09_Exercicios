namespace AcademiaAtos_Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            // Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

            int[,] matriz = new int[3, 3];
            int numero;

            // Lendo a matriz do usuário
            Console.WriteLine("Digite os valores da matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Matriz[{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Solicitando o número ao usuário
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            // Verificando se o número existe na matriz
            bool existe = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    break;
                }
            }

            // Imprimindo o resultado
            if (existe)
            {
                Console.WriteLine("O número existe no vetor");
            }
            else
            {
                Console.WriteLine("Número inexistente");
            }
        }
    }
}