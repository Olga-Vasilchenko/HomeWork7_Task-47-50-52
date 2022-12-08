// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] RandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}"); 
            else Console.Write($"{matrix[i, j], 4} ");
        }                                    
        Console.WriteLine("|");
    }
}

double[] ArithmeticElements(int[,] matrix, int columns)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double sum = 0;
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                sum += matrix[k, i];
                array[i] = Math.Round(sum / matrix.GetLength(0), 1);
            }
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],  4}");
        else Console.Write($"{array[i],  4} ");
    }
    Console.WriteLine("|");
}

int[,] array2D = RandomMatrix(4, 3, 1, 10);
PrintMatrix(array2D, "|", "", " |");
double[] array1 = ArithmeticElements(array2D, 4);
PrintArray(array1);