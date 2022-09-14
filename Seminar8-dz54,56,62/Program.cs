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

// int[,] SortRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int iteration = 1;
//         while (iteration != 0)
//         {
//             iteration = 0;
//             int temp = 0;
//             for (int j = 1; j < array.GetLength(1); j++)
//             {
//                 if (array[i, j] > array[i, j - 1])
//                 {
//                     temp = array[i, j - 1];
//                     array[i, j - 1] = array[i, j];
//                     array[i, j] = temp;
//                     iteration += 1;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение рандомайзера: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение рандомайзера: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows, cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// Show2dArray(SortRows(array));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// void MinSumRowFind(int[,] array)
// {
//     int minSum = 0;
//     int temp = 0;
//     int numRow = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp += array[i,j];
//         }
//         if (i == 0 || temp < minSum) 
//         {
//             minSum = temp;
//             numRow = i;
//         }
//         temp = 0;
//     }
//     Console.WriteLine($"Наименьшая сумма элементов в {numRow + 1} ряду");
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// if(rows != cols)
// { 
// Console.Write("Введите минимальное значение рандомайзера: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение рандомайзера: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows, cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// MinSumRowFind(array);
// }
// else Console.WriteLine("Задан не прямоугольный массив!");


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int[,] FillSpiralArray(int row, int col)
// {
//     int[,] array = new int[row, col];

//     for (int i = 1; i - 1 < array.GetLength(1); i++) array[0, i - 1] = i;
//     for (int i = 1; i < array.GetLength(0); i++) array[i, array.GetLength(1) - 1] = array[i - 1, array.GetLength(1) - 1] + 1;
//     for (int i = 1; i < array.GetLength(1); i++) array[array.GetLength(0) - 1, array.GetLength(1) - i - 1] = array[array.GetLength(0) - 1, array.GetLength(1) - i] + 1;
//     for (int i = 1; i < array.GetLength(0) - 1; i++) array[array.GetLength(0) - i - 1, 0] = array[array.GetLength(0) - i, 0] + 1;
//     for (int i = 1; i < array.GetLength(1) - 1; i++) array[1, i] = array[1, i - 1] + 1;
//     for (int i = 2; i < array.GetLength(0) - 1; i++) array[i, array.GetLength(1) - 2] = array[i - 1, array.GetLength(1) - 2] + 1;
//     for (int i = 2; i < array.GetLength(1) - 1; i++) array[array.GetLength(0) - 2, array.GetLength(1) - i - 1] = array[array.GetLength(0) - 2, array.GetLength(1) - i] + 1;
//     return array;
// }

// Show2dArray(FillSpiralArray(4, 4));

//ДОРАБОТАННАЯ ВЕРСИЯ, СТРОИТ СПИРАЛЬ ДЛЯ ЛЮБОГО МАССИВА (КРОМЕ 3Х3??)
int[,] FillSpiralArray(int row, int col)
{
    int[,] array = new int[row, col];
    array[0,0] = 1;
    for (int k = 1; k < row-1; k++)
    {
        for (int i = 1; i < array.GetLength(1); i++) if (array[k - 1, i] == 0) array[k - 1, i] = array[k - 1, i - 1] + 1;
        for (int i = 1; i < array.GetLength(0); i++) if (array[i, array.GetLength(1) - k] == 0) array[i, array.GetLength(1) - k] = array[i - 1, array.GetLength(1) - k] + 1;
        for (int i = 1; i < array.GetLength(1)-k+1; i++) if (array[array.GetLength(0) - k, array.GetLength(1) - i - k] == 0) array[array.GetLength(0) - k, array.GetLength(1) - i - k] = array[array.GetLength(0) - k, array.GetLength(1) - i - k + 1] + 1;
        for (int i = 1; i < array.GetLength(0) - k; i++) if (array[array.GetLength(0) - i - k, k - 1] == 0) array[array.GetLength(0) - i - k, k - 1] = array[array.GetLength(0) - i - k + 1, k - 1] + 1;
    }
    return array;
}
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Show2dArray(FillSpiralArray(row, col));
