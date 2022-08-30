// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//  void Numbers(int num1, int num2){
//     int result = num1;
//     if(num2 == 0) Console.WriteLine($"Число {num1} в степени {num2} равно: 1");
//     else{
//         for(int curr = 1; curr < num2; curr++){
//             result *= num1;
//         }
//         Console.WriteLine($"Число {num1} в степени {num2} равно: {result}");
//     }
//  }

// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Numbers(num1, num2);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// //метод вычисляет количество цифр в числе и возвращает это значение
//  int Numbers(int num){
//     int a = 1;

//     for(int curr = 10; curr <= num; curr *= 10){
//         a = curr;  //в переменную "а" положим значение соотв.количеству цифр в числе, пример 3 цифры, а = 100; 4 цифры, а = 1000 и тд.
//     }
//     return a;
// }

// void SumOfDigits (int number, int nDig){
//     int sum = 0;
//     int c = nDig;
//     int d = number;

//     for(int i = 1; i<=nDig; i*=10){
//         int b = d/c;    //получим первое число (возьмем самую левую цифру)
//         sum = sum + b;  
//         d %= c;         //получим следующее число, от которого будем брать самую левую цифру для суммирования 
//         c /= 10;        //уменьшим разрядность на один знак
//     }
// Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// SumOfDigits(number, Numbers(number));



// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray(int size){
    int [] array = new int[size];
    for(int i = 0; i < size; i++){
       Console.Write($"Введите {i} элемент массива: ");
       array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}
Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateArray(size));

