// //Создать двумерный массив из рандомных чисел и вывести на экран
// //Найти сумму элементов, находящихся на главной диагонали (с индексами [0,0], [1,1], [2,2] и тд.)
// int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
// {
//     int [,] array=new int [rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j]=new Random().Next(min,max+1);
//     return array;    
// }

// void Show2dArray(int[,] array)
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

// int CalcSumDiag(int[,] array)
// {
//     int sum=0;
//     if(array.GetLength(0)==array.GetLength(1))
//     {
//         for(int i=0; i<array.GetLength(0);i++)
//         {
//             for(int j=0; j<array.GetLength(1);j++)
//             {
//                 if(i==j) sum +=array[i,j];
//             }
//         }
//    }
//    return sum;
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение рандомайзера: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение рандомайзера: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2dArray(rows, cols, min, max);
// Show2dArray(array);
// int sum = CalcSumDiag(array);
// Console.WriteLine("Сумма элементов главной диагонали: " + sum);



// //Задайте двумерный массив M x N. Каждый элемент массива находится по формуле: A(MN)=M+N. Выведете полученный массив на экран.
// int[,] Create2dArray(int rows, int cols)
// {
//     int [,] array=new int [rows,cols];
//     for(int i=0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j]=i+j;
//     return array;    
// }

// void Show2dArray(int[,] array)
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

// Console.Write("Введите количество строк (M): ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов(N): ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2dArray(rows, cols);
// Show2dArray(array);



//Задайте двумерный массив, найдите элементы, в которых оба индекса четные и замените эти элементы на квадраты.
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

int[,] ChangeElemInChetniy(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
        {
            for(int j=0; j<array.GetLength(1);j++)
            {
                if(i%2==0 && j%2==0) array[i,j] = array[i,j]*array[i,j];
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

int [,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
ChangeElemInChetniy(array);
Console.WriteLine();
Show2dArray(array);

