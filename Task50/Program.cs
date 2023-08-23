// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

int[,] CreateMartixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],+5}");

        }
        Console.WriteLine("| ");
    }

}

void SearchElemIndexMatrix(int[,] matrix, int rows, int colums)
{

    if (rows < 0 || colums < 0)
        Console.WriteLine("Ошибка");

    if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1))
    {
        Console.WriteLine($"Вы искали элемент: {matrix[rows, colums]}");
    }
    else Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("Введите номер строки:");
int num_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int num_colums = Convert.ToInt32(Console.ReadLine());
int[,] array_2d = CreateMartixRndInt(5, 6, 10, 99);
PrintMatrix(array_2d);
SearchElemIndexMatrix(array_2d, num_rows, num_colums);
