//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

// int CountPositive(int [] array)
// {
//     int counter=0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>0) counter++;
//     }
//     return counter;
// }

// Console.Write("Необходимо ввести несколько чисел, сколько чисел будете вводить: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [a];
// for(int i=0;i<a;i++)
// {
//    Console.Write($"Введите число {i}: ");
//    array[i] = Convert.ToInt32(Console.ReadLine());
// }

// int counter=CountPositive(array);
// Console.WriteLine($"Введено {array.Length} чисел, из которых {counter} положительные");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем. 
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите число b1 -> ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1 -> ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 -> ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 -> ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.Write($"Точка пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2 имеет координаты: x={x}, y={y}");
