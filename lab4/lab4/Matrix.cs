using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Matrix
    {
        public static int[,] createMatrix(int SIZE)
        {
            int[,] matrix = new int[SIZE, SIZE];


            Random random = new Random();

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matrix[i, j] = random.Next(1, 999);
                }

            }

            return matrix;
        }

        public static void sortMat(int[,] mat, int n)
        {
            
            int[] temp = new int[n * n];
            int k = 0;
         
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    temp[k++] = mat[i, j];

            Array.Sort(temp);

           
            k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    mat[i, j] = temp[k++];
        }

        
        public static void printMat(int[,] mat, int n)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[,] modifyMatrix(int[,] matrixI, int SIZE)
        {

            int[,] modifiedChoiceMatrix = new int[SIZE - 1, SIZE - 1];


            for (int i = 0; i < SIZE - 1; i++)
            {
                for (int j = 0; j < SIZE - 1; j++)
                {
                    modifiedChoiceMatrix[i, j] = matrixI[i + 1, j + 1];
                }
            }


            return modifiedChoiceMatrix;
        }
    }
}
