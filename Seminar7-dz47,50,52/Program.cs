// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
//8 7,8 -7,1 9
// double[,] CreateRandom2dArray(int rows, int cols)
// {
//     double[,] array=new double [rows,cols];
//     for(int i=0; i<rows; i++){
//         for(int j=0; j<cols; j++){
//             int flag = -1;                                                          //флаг нужен для создания отрицательного или положительного числа, пока установлен в значение -1. Положительное, если 0 и отрицательное, если 1.
//             flag = new Random().Next(0,2);                                          //здесь будем щелкать flag в 0 или 1
//             if(flag == 0) array[i,j] = new Random().Next() * new Random().NextDouble();      //создать вещественное число оказалось не так просто, этот метод описан в оффициальном руководстве к С#
//             else array[i,j] = -1 * new Random().Next() * new Random().NextDouble();
//         }
//     }
//     return array;    
// }

// void Show2dArray(double[,] array)
// {
//     for(int i=0; i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// double [,] array = CreateRandom2dArray(rows, cols);
// Show2dArray(array);



// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1,7 -> такого числа в массиве нет
// // 1,2 -> 2
// int[,] CreateRandom2dArray(int rows, int cols)
// {
//     int [,] array=new int [rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j]=new Random().Next(1,20);
//     return array;    
// }

// void FindElem(int[,] array, int i, int j)
// {
//     if(i>=array.GetLength(0) || j>=array.GetLength(1)) Console.WriteLine("Такого элемента нет");    //знак ">=" поскольку мы уменьшаем значение i,j на единицу
//     else Console.WriteLine($"Значение элемента с координатами i={i+1} и j={j+1} равно: {array[i,j]}");
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию i: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию j: ");
// int j = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows, cols);
// FindElem(array, i-1, j-1);              //уменьшаем на единицу оба значения, т.к. элементы расположены с 0, грубо говоря переводим на "человеческие координаты"



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateRandom2dArray(int rows, int cols)
{
    int [,] array=new int [rows,cols];
    for(int i=0; i<rows; i++)
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(1,20);
    return array;    
}

void Show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}

void ShowArray(double[] array)
{
    for(int i=0; i<array.Length;i++)
    {
        Console.Write(array[i]+ " ");
    }
}


void ColsAvgFnd(int[,] array)
{
    double[] avgResult = new double[array.GetLength(1)];
    double avgCol=0;
    for(int i=0; i<array.GetLength(1);i++)
        {
            for(int j=0; j<array.GetLength(0);j++)
            {
                avgCol+=array[j,i];
            }
        avgResult[i]=Math.Round((avgCol/array.GetLength(0)),2);
        avgCol=0;            
        }
    Console.WriteLine("Средние по столбцам ниже");
    ShowArray(avgResult);
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2dArray(rows, cols);
Show2dArray(array);
ColsAvgFnd(array);

