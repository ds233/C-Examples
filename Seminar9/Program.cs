// //Задайте натуральное число N. Напишите программу, которая выдает все числа в промежутке от 1 до N.
// //метод запроса данных у пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }
// //Рекурсия числа от 1 до N
// string Recurs(int num)
// {
//     if (num <= 1) return "1";
//     else
//     {
//         string outLine = Recurs(num - 1) + " " + num; 
//         return outLine;
//     }
// }
// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int inputNumber = ReadData("Введите число N:");
// string outLine = Recurs(inputNumber);
// PrintData("Числа от 1 до N: ", outLine);


// //Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// // //метод запроса данных у пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }
// //Рекурентно считает сумму цифр числа N
// int Recurs(int num)
// {
//     if (num == 0) return 0;
//     else return num % 10 + Recurs(num / 10);
// }
// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }
// //Сумма чисел не рекурреннтная
// int SumWhile(int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }
//     return sum;
// }


// int inputNumber = ReadData("Введите число N:");
// DateTime d1 = DateTime.Now;
// int outLine1 = Recurs(inputNumber);
// PrintData("Время работы рекурсии: ", (DateTime.Now - d1).ToString());

// DateTime d2 = DateTime.Now;
// int outLine2 = SumWhile(inputNumber);
// PrintData("Время работы while: ", (DateTime.Now - d2).ToString());

// PrintData("Сумма цифр в числе N: ", outLine1.ToString());
// PrintData("Сумма цифр в числе N: ", outLine2.ToString());




//Напишите программу, которая на вход принимает два числа a и b. Возводит число а в степень в
// //метод запроса данных у пользователя
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
//Рекурентно возводит а в степень в
long PowRec(int a, int b)
{
    if (b <= 0) return 1;

    else return a * PowRec(a, b - 1);
}
//Рекурентно возводит а в степень в c разбиением
long MyPowRec(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;
    if (b % 2 == 0) return PowRec(a, b / 2) * PowRec(a, b / 2);
    else return PowRec(a, b / 2) * PowRec(a, b / 2 + 1);
}
//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int a = ReadData("Введите число a:");
int b = ReadData("Введите число b:");

DateTime d1 = DateTime.Now;
long resPow1 = PowRec(a,b);
PrintData("Время работы PowRec: ", (DateTime.Now - d1).ToString());

DateTime d2 = DateTime.Now;
long resPow2 = MyPowRec(a,b);
PrintData("Время работы MyPowRec: ", (DateTime.Now - d2).ToString());

DateTime d3 = DateTime.Now;
long resPow3 = (long)Math.Pow(a,b);
PrintData("Время работы Math.Pow: ", (DateTime.Now - d3).ToString());

PrintData("Число " + a + " в степени " + b + ": ", resPow1.ToString());
PrintData("Число " + a + " в степени " + b + ": ", resPow2.ToString());
PrintData("Число " + a + " в степени " + b + ": ", resPow2.ToString());
