// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8   7,8   -7,1  9

double[,] MatrixRndDouble(int rows, int columns, int min, int max)
{                           
    double[,] matrix = new double[rows, columns]; 
    Random rnd = new Random();
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix, string beginRow, string separatorElems, string endRow)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write(beginRow);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 6}"); 
            else Console.Write($"{matrix[i, j], 6} ");
        }                                    
        Console.WriteLine(endRow);
    }
}

double[,] array2D = MatrixRndDouble(4, 3, -100, 100);
PrintMatrix(array2D, "|", "", " |");
Console.WriteLine();
