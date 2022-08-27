//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

// void Func(int a)
// {
//     if(a == 1) Console.WriteLine("Координаты +х, +у");
//     else if(a == 2) Console.WriteLine("Координаты -х, +у");
//     else if(a == 3) Console.WriteLine("Координаты -х, -у");
//     else if(a == 4) Console.WriteLine("Координаты +х, -у");
//     else Console.Write("Ошибка. Введите число от 1 до 4");
// }

// Console.Write("Для определения координат, введите номер четврти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Func(num);


//Напишите программу, которая принимает на вход координаты точки (x и y),
//причем Х != 0 и У != 0 и выдает номер четверти плоскости, в которой находится эта точка.

// void Func(int x, int y)
// {
//     if(x > 0 && y > 0) Console.WriteLine("Координаты соответствуют 1 четверти");
//     else if(x < 0 && y > 0) Console.WriteLine("Координаты соответствуют 2 четверти");
//     else if(x < 0 && y < 0) Console.WriteLine("Координаты соответствуют 3 четверти");
//     else if(x > 0 && y < 0) Console.WriteLine("Координаты соответствуют 4 четверти");
// }

// Console.Write("Введите координату Х: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату У: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x == 0 || y == 0) Console.WriteLine("Введенные значения не соответствуют условию задачи");
// else Func(x, y);


//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

// void Square(int a){
//         for(int i=1; i<=a; i++){
//         int result = i*i;
//         Console.Write(result + " ");
//         // while(a >= 1){
//         //     int result = a*a;
//         //     a--;
//         //     Console.Write(result + " ");
//         // }
//     }
// }

// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// if(x <= 0) Console.WriteLine("Некорректный ввод");
// else Square(x);


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
//....не вижу чат, там какая то формула....