int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
{
    int [,] array=new int [rows,cols];
    for(int i=0; i<rows; i++)
        for(int j=0; j<cols; j++)
            array[i,j]=new Random().Next(min,max+1);
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

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int [,] Reverse2dArray(int[,] array)
// {
//     int temp = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = i + 1; j < array.GetLength(1); j++)
//         {
//             temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
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
// if(array.GetLength(0) == array.GetLength(1))
// {
//     int[,] array2 = Reverse2dArray(array);
//     Show2dArray(array2);
// }
// else Console.WriteLine("Матрица не квадратная!");



//Задайте двумерный массив из целых чисел. 
//Напишите программу, которая заменит на "0" все элементы в строке и столбце, на пересечении которых расположен наименьший элемент массива.
// int[,] ChangeColsRows(int[,] array)
// {
//     int iMin = 0;
//     int jMin = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 1; j < array.GetLength(1); j++)          //ЗАДАЧА РЕШЕНА НЕ ВЕРНО!!! Т.К. КООРДИНАТЫ [i,0] НЕ ОБРАБАТЫВАЮТСЯ 
//         {
//             if(array[i,j] < array[iMin,jMin])
//             {
//                 iMin = i;
//                 jMin = j;
//             }
//         }
//     }
//     // for(int i = 0; i < array.GetLength(0); i++) array[i, jMin] = 0;
//     // for(int j = 0; j < array.GetLength(1); j++) array[iMin, j] = 0;
//     //ИЛИ ВОТ ТАК
//     for(int i=0;i<array.GetLength(0);i++)
//     {
//         for(int j=0;j<array.GetLength(1);j++)
//         {
//             if(i==iMin || j==jMin) array[i,j]=0;
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
// Show2dArray(ChangeColsRows(array));


//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. 
int[,] ChangeRows(int[,] array)
{
    int temp = 0;
    int i=0;
    int iMax=array.GetLength(0)-1;
        for(int j=0; j<array.GetLength(1); j++)
        {
            temp = array[i,j];
            array[i,j] = array[iMax,j];
            array[iMax,j] = temp;
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
Show2dArray(ChangeRows(array));
