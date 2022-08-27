// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int a){
//         int oldNum = a;
//         int dig1 = a/10000;
//         int dig2 = a%10000; dig2 = dig2/1000;
//         int dig3 = a%1000; dig3 = dig3/100;
//         int dig4 = a%100; dig4 = dig4/10;
//         int dig5 = a%10;
//         int newNum = dig5*10000 + dig4*1000 + dig3*100 + dig2*10 + dig1;

//         if(newNum == oldNum) Console.WriteLine("Это палиндром");
//         else Console.WriteLine("Это не палиндром");
// }

// Console.Write("Введите 5-ти значное число: ");
// int x = Convert.ToInt32(Console.ReadLine());

// if(x < 9999 || x > 99999) Console.WriteLine("Некорректный ввод");
// else Palindrom(x);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние определяется по формуле: D=sqrt((x2-x1)^2 + (y2-y1)^2 + (z2 - z1)^2).

// void Distance(int x1, int y1, int z1, int x2, int y2, int z2){
//     double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)); 
//     Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно: {result}");
// }

// Console.Write("Введите координату x точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату z точки А: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату x точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату y точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату z точки B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Distance(x1, y1, z1, x2, y2, z2);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void KubCounter(int a){
    for(int i=1; i<=a; i++){
        int result = i*i*i;
        Console.Write(result + " ");       
    }   
}

Console.Write("Введите целое число больше 0: ");
int x = Convert.ToInt32(Console.ReadLine());

if(x <= 0) Console.WriteLine("Некорректный ввод");
else KubCounter(x);

