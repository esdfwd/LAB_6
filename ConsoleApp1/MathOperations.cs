using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class MathOperations
    {
        //Чисел +
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Масив +
        public static int[] Add(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }
            return result;
        }

        // Матриць +
        public static int[,] Add(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;

        }

        // Число -
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Масив  -
        public static int[] Subtract(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] - array2[i];
            }
            return result;
        }

        // Матриця -
        public static int[,] Subtract(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
                throw new ArgumentException("Matrices must have the same dimensions.");

            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }


        // Число *
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Масив * 
        public static int[] Multiply(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                throw new ArgumentException("Arrays must have the same length.");

            int[] result = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] * array2[i];
            }
            return result;
        }

        //матриць *
        public static int[,] Multiply(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");

            int rows = matrix1.GetLength(0);
            int cols = matrix2.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }
    }
}