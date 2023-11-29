namespace Task_2
{
    class Program
    {
        static void Main()
        {
            int result1 = MathOperations.Add(5, 10);
            Console.WriteLine($"Addition of numbers: {result1}");

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };
            int[] result2 = MathOperations.Add(array1, array2);
            Console.WriteLine($"Addition of arrays: [{string.Join(", ", result2)}]");

            int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            int[,] result3 = MathOperations.Add(matrix1, matrix2);
            Console.WriteLine("Addition of matrices:");
            for (int i = 0; i < result3.GetLength(0); i++)
            {
                for (int j = 0; j < result3.GetLength(1); j++)
                {
                    Console.Write(result3[i, j] + " ");
                }
                Console.WriteLine();
            }

            int result4 = MathOperations.Subtract(10, 5);
            Console.WriteLine($"Subtraction of numbers: {result4}");

            int[] array3 = { 4, 5, 6 };
            int[] array4 = { 1, 2, 3 };
            int[] result5 = MathOperations.Subtract(array3, array4);
            Console.WriteLine($"Subtraction of arrays: [{string.Join(", ", result5)}]");

            int[,] matrix3 = { { 5, 6 }, { 7, 8 } };
            int[,] matrix4 = { { 1, 2 }, { 3, 4 } };
            int[,] result6 = MathOperations.Subtract(matrix3, matrix4);
            Console.WriteLine("Subtraction of matrices:");
            for (int i = 0; i < result6.GetLength(0); i++)
            {
                for (int j = 0; j < result6.GetLength(1); j++)
                {
                    Console.Write(result6[i, j] + " ");
                }
                Console.WriteLine();
            }

            int result7 = MathOperations.Multiply(5, 4);
            Console.WriteLine($"Multiplication of numbers: {result7}");

            int[] array5 = { 1, 2, 3 };
            int[] array6 = { 4, 5, 6 };
            int[] result8 = MathOperations.Multiply(array5, array6);
            Console.WriteLine($"Multiplication of arrays: [{string.Join(", ", result8)}]");

            int[,] matrix5 = { { 1, 2 }, { 3, 4 } };
            int[,] matrix6 = { { 5, 6 }, { 7, 8 } };
            int[,] result9 = MathOperations.Multiply(matrix5, matrix6);
            Console.WriteLine("Multiplication of matrices:");
            for (int i = 0; i < result9.GetLength(0); i++)
            {
                for (int j = 0; j < result9.GetLength(1); j++)
                {
                    Console.Write(result9[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}