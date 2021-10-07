using System;

namespace POO_Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the order of the Square Matrix:");
            //Inserção do usuário da ordem da matriz, que no caso desse código, sempre será quadrada.
            int n = int.Parse(Console.ReadLine());
            //Declaração do array mat, que servirá como matriz.
            int[,] mat = new int[n, n];
            Console.WriteLine("Now insert each integer value, by row (separate each number by ',' and press enter for each row:)");

            //Inserção da matriz por coluna e separada por vírgula pelo usuário. A quantidade de linhas e colunas inseridas dependem do valor inserido anteriormente na linha 11.
            for (int i = 0; i<n; i++)
            {
                string[] values = Console.ReadLine().Split(",");
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            //Parte do código que encontra a diagonal principal da matriz, que é composto pelos valores de linha e coluna iguais.
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i<n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine("");

            //Contagem de números negativos encontrados na matriz.
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] <0)
                    {
                        count++;
                    }
                }
            }

            //Menção da quantidade de números negativos encontrados na matriz ao usuário.
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
