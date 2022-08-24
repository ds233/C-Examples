//Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
int num1, num2, num3;
int max;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

//Установим максимум на первое число
max = num1;

//Проверим не больше ли максимума второе и третье число и если больше, то установим новый максимум
if(num2 > max){max = num2;}
if(num3 > max){max = num3;}

Console.WriteLine("Максимальное число: " + max);

