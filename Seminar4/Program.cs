//Написать программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

// void Numbers(int num){
//     int result=0;
//     for(int curr = 1; curr<=num; curr++){
//         result += curr;
//     }
//     Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);


//Напишите программу, которая принимает на вход число (А) и выдает произведение чисел от 1 до А

//  void Numbers(int num){
//     int result = 1;
//     for(int curr = 1; curr <= num; curr++){
//         result *= curr;
//     }
//     Console.WriteLine($"Произведение чисел от 1 до {num} равна {result}");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);

//Напишите программу, которая принимает на вход число и выдает количество цифр в числе

//  void Numbers(int num){
//     int result = 1;
    
//     for(int curr = 10; curr <= num; curr *= 10){
//         result++;
//     }
//     Console.WriteLine($"Количество цифр в числе {num} равно {result}");
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);


//Напишите программу, которая находит в последовательности от 1 до N все нечетные числа

// void Numbers(int number){
//     for(int i=1;i<=number;i+=2){
//         Console.Write(i+" ");
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Numbers(number);


//Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
//[1,0,1,1,0,1,0,0]

int [] CreateRandomArray(int size){
    int [] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0,2);
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
ShowArray(CreateRandomArray(size));


