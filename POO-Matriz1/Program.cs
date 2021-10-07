﻿using System;

namespace POO_Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the order of the Square Matrix:");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Console.WriteLine("Now insert each value, by row (separate each number by ',' and press enter for each row:)");
            for (int i = 0; i<n; i++)
            {
                string[] values = Console.ReadLine().Split(",");
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i<n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine("");

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
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
