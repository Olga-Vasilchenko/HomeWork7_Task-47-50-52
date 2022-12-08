// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{     
    Random rnd = new Random();                      
    int[,] matrix = new int[rows, columns];
   
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

int ElemsNumbersMatrix(int[,] matrix, int rowsI, int columnsI)
{
    int position = matrix[rowsI, columnsI];
    return position;
}

int rowSize = 0;
int columnSize = 0;
int rowIndex = 0;
int columnIndex = 0;
while (rowSize <= 0 || columnSize <= 0 || rowIndex < 0 || columnIndex < 0)
{
    Console.WriteLine($"Введите количество строк массива");
    rowSize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите количество столбцов массива");
    columnSize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите индекс строки");
    rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите индекс столбца");
    columnIndex = Convert.ToInt32(Console.ReadLine());
    if (rowSize <= 0 || columnSize <= 0 || rowIndex < 0 || columnIndex < 0)
    Console.WriteLine($"Введены неверные данные");
}

int[,] array2D = CreateMatrixRndInt(rowSize, columnSize, 0, 10);
PrintMatrix(array2D, "|", "", "  |");
Console.WriteLine(rowIndex <= rowSize && columnIndex <= columnSize ? 
$"Элемент массива c заданными индексами -> {ElemsNumbersMatrix(array2D, rowIndex, columnIndex)}" :
"Такого элемента в массиве нет");