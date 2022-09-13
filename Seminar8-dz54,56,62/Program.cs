// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int iteration = 1;
        while (iteration != 0)
        {
            iteration = 0;
            int temp = 0;
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] > array[i, j - 1])
                {
                    temp = array[i, j - 1];
                    array[i, j - 1] = array[i, j];
                    array[i, j] = temp;
                    iteration += 1;
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомайзера: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомайзера: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
Show2dArray(SortRows(array));



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07