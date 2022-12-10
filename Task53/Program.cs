// Задайте двумерный массив
// Напишите программу, которая 
// поменяет местами первую и последнюю строку массива

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max - 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

void ReplaceRows(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temporaryVariable = matrix[0, j]; // присваиваем временной переменной первый элемент первой строки
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j]; // в первый элемент записываем значение из последней строки
        matrix[matrix.GetLength(0) - 1, j] = temporaryVariable; // в последний элемент присваем значение из временной переменной
    }
}

Console.WriteLine();
ReplaceRows(array2D);
PrintMatrix(array2D);