﻿//Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
int num;

Console.Write("Введите целое число: ");
num = Convert.ToInt32(Console.ReadLine());

//выполним проверку вхождения введенного числа в диапазон 1 ... N 
if(num < 2){
    Console.WriteLine("Ошибка! Введенное число вне допустимого диапазона");
}

//Посчитаем четные числа в диапазоне 1..N 
//Схитрим, установим доп.переменную на первое четное число 2 и будем прибавлять по 2 до достижения верхней границы диапазона
else{
    int current = 2;

    while(current <= num)
    {
        Console.Write(current + " ");
        current++;
        current++;
    }
}
