// // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// // M = 4; N = 8. -> ""4, 6, 7, 8""
// // //Метод запроса данных у пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }
// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }
// //Выводим числа в заданном диапазоне 
// string NumMN(int m, int n)
// {
//     if (m >= n) return n.ToString();
//     else return m.ToString() + ", " + (NumMN(m + 1, n)).ToString();
// }

// int m = ReadData("Введите число m:");
// int n = ReadData("Введите число n:");
// string res = (m < n) ? (NumMN(m, n)) : (NumMN(n, m));
// PrintData("Числа в промежутке от " + m + " до " + n + " : ", res);


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30
// //Метод запроса данных у пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }
// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }
// //Вычислим сумму элементов
// int SumMN(int m, int n)
// {
//     if(n <= m) return n;
//     else return n + SumMN(m, n-1);
// }

// int m = ReadData("Введите число m:");
// int n = ReadData("Введите число n:");
// int res = (m < n) ? (SumMN(m, n)) : (SumMN(n, m));
// PrintData("Сумма чисел в промежутке от " + m + " до " + n + " : ", res.ToString());


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// //Метод запроса данных у пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}
//Вычисление функции Аккермана
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

int m = ReadData("Введите число m:");
int n = ReadData("Введите число n:");
int res = Akkerman(n,m);
PrintData("Результат вычисления функции Аккермана: ", res.ToString());
