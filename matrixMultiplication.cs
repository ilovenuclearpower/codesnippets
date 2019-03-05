/*
 * C# Program to Perform Matrix Multiplication
 */
 //This is the Naive Implementation.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace matrix_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,m,n;
            Console.WriteLine("Enter the Number of Rows and Columns : ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Console.WriteLine("Enter the First Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Takes in the values of the original Matrix 1.
            Console.WriteLine("First matrix is:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Writes out the value entered.
            int[,] b = new int[m, n];
            Console.WriteLine("Enter the Second Matrix");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Parses the input for the second matrix.
            Console.WriteLine("Second Matrix is :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Outputs the value for the first matrix.
            Console.WriteLine("Matrix Multiplication is :");
            int[,] c = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            //Iterates over every row, column in the matrix and then computes the dot product
            //Placing them in the output matrix.
            
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                    //Outputs the result matrix.
                }
                Console.WriteLine();
            }
 
            Console.ReadKey();
        }
    }
}
