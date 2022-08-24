// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке -N до N

int num;

Console.Write("Введите целое положительное число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}

