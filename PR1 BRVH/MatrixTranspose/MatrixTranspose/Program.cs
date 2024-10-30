using System;

namespace MatrixTranspose
{
    class Program
    {
        /// <summary>
        /// Генерирует матрицу размерности n x m с случайными целыми числами.
        /// </summary>
        /// <param name="n">Количество строк.</param>
        /// <param name="m">Количество столбцов.</param>
        /// <param name="minValue">Минимальное значение для случайных чисел.</param>
        /// <param name="maxValue">Максимальное значение для случайных чисел.</param>
        /// <returns>Двумерный массив (матрица) размерности n x m.</returns>
        static int[,] GenerateRandomMatrix(int n, int m, int minValue, int maxValue)
        {
            Random random = new Random();
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue); // Генерация случайного целого числа
                }
            }

            return matrix;
        }

        /// <summary>
        /// Выводит матрицу по столбцам.
        /// </summary>
        /// <param name="matrix">Двумерный массив (матрица).</param>
        static void PrintMatrixByColumns(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество строк (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов (m): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите минимальное значение для случайных чисел: ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальное значение для случайных чисел: ");
            int maxValue = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateRandomMatrix(n, m, minValue, maxValue);
            Console.WriteLine("Сгенерированная матрица по столбцам:");
            PrintMatrixByColumns(matrix);
        }
    }
}
