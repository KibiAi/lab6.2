using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._2
{
    public class MathOperations
    {
        // Додавання
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Додавання масивів
        public static double[] Add(double[] arr1, double[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Розмірності масивів не співпадають.");
            }

            double[] result = new double[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            return result;
        }

        // Перевантаження додавання матриць
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                throw new ArgumentException("Розмірності матриць не співпадають.");
            }

            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);

            double[,] result = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        // Перевантаження тензорів
        public static double[,,] Add(double[,,] tensor1, double[,,] tensor2)
        {
            if (tensor1.GetLength(0) != tensor2.GetLength(0) ||
                tensor1.GetLength(1) != tensor2.GetLength(1) ||
                tensor1.GetLength(2) != tensor2.GetLength(2))
            {
                throw new ArgumentException("Розмірності тензорів не співпадають.");
            }

            int depth = tensor1.GetLength(0);
            int rows = tensor1.GetLength(1);
            int columns = tensor1.GetLength(2);

            double[,,] result = new double[depth, rows, columns];
            for (int d = 0; d < depth; d++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        result[d, i, j] = tensor1[d, i, j] + tensor2[d, i, j];
                    }
                }
            }
            return result;
        }

        // Перевантаження віднімання
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Перевантаження множення
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}

