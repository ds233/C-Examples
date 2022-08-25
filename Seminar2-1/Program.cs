//Напишите программу, которая выводит случайное трех значное число и удаляет вторую цифру этого числа
// int CutNumber(){
//     int num = new Random().Next(100, 1000);
//     Console.WriteLine("Number is: " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     return result;
// }

// int number = CutNumber();
// Console.WriteLine("Cutted number: " + number);


//Программа для перемножения двух факториалов чисел
// int Factorial (int num){
//     int current=1;
//     int fact=1;

//     while(current <= num){
//         fact *= current; //fact = fact * current;
//         current++;
//     }
//     return fact;
// }

// int result = Factorial(12) * Factorial(10);
// Console.WriteLine("Your result is: " + result);


//Написать программу, которая выводит случайное число из диапазона [10, 99], а затем показывает максимальное число в выведенном
// int MaxNum(){
//     int num = new Random().Next(10, 100);
//     Console.WriteLine("Your number is " + num);
//     int dec = num / 10;
//     int ed = num % 10;
//     if(dec > ed){
//         return dec;
//     }
//     else{
//         return ed;
//     }
// }

// Console.WriteLine("Max number is " + MaxNum());


//Напишите программу, которая на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23
// void Crat(int num){
//     if(num % 7 == 0 && num % 23 == 0) Console.WriteLine("WoW! your number KRATNOE 7 & 23");
//     else Console.WriteLine("Your number ne KRATNOE");
// }

// Console.Write("Enter your number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Crat(num1);


//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// void CheckQuad(int num1, int num2){ //Функция проверяет является ли первое число квадратом второго
// if(num1 == num2*num2) Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
// else Console.WriteLine("Число " + num1 + " не является квадратом числа " + num2);
// }

// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// CheckQuad(num1, num2);
// CheckQuad(num2, num1);


//Напишите программу, которая принимает на вход два числа и проверяет, является ли второе число кратно первому. 
//Если число 2 не кратно 1, то выводит остаток от деления
int Check(int num1, int num2){ 
    if(num2 % num1 != 0){
        int result = num2 % num1;
        return result;
    }
    else return 0;
}

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == 0 || num2 == 0) Console.WriteLine("На ноль делить нельзя");
else{
    int result = Check(num1, num2);
    if(result == 0) Console.WriteLine("Второе число кратно первому");
    else Console.WriteLine("Второе число не кратно первому. Остаток от деления: " + result);
}


