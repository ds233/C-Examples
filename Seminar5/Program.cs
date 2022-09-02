// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// //Найти сумму отрицательных и положительных элементов массива.
// int [] CreateRandomeArray(int size, int min, int max){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int CountPosEl(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i]>0) count+=array[i];
//     }
//     return count;
// }

// int CountNegEl(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i]<0) count+=array[i];
//     }
//     return count;
// }

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomeArray(size, min, max);
// ShowArray(array);

// int pos = CountPosEl(array);
// int neg = CountNegEl(array);
// Console.WriteLine($"Сумма положительных значений массива: {pos}");
// Console.WriteLine($"Сумма отрицательных значений массива: {neg}");

//Напишите программу, которая заменит в массиве положительные на отрицательные, а отрицательные на положительные (изменит знак)

// int [] CreateRandomeArray(int size, int min, int max){
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int [] InvertEl(int[] array){
//     for(int i = 0; i < array.Length; i++){
//         array[i] *= -1;
//         }
//     return array;
// }

// Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomeArray(size, min, max);
// ShowArray(array);

// int [] inverted = InvertEl(array);
// ShowArray(inverted);

//Задать одномерный массив из произвольного количества случайных чисел. Найти количество элементов массива, значения которых лежат в диапазоне от 10 до 99. 

// int [] CreateRandomeArray(){
//     int size = new Random().Next(1,10000);
//     int a = new Random().Next();
//     int b = new Random().Next();
//     int max = 0;
//     int min = 0;
//     int [] array = new int[size];
//     if(a > b){
//         max = a;
//         min = b;
//     } 
//     else{
//         max = b;
//         min = a;
//     } 
    
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void FindEl(int[] array){
//     int counter = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] >= 10 && array[i] <= 99) counter++;
//     }
//     Console.WriteLine($"Количество элементов массива, значения которых лежат в диапазоне от 10 до 99 составляет {counter}");
// }

// int[] array = CreateRandomeArray();
// //ShowArray(array);
// FindEl(array);

//Написать программу, которая определяет присутствует ли заданное число в массиве.

int [] CreateRandomeArray(){
    int size = new Random().Next(1,100);
    int a = new Random().Next(1,100);
    int b = new Random().Next(1,100);
    int max = 0;
    int min = 0;
    int [] array = new int[size];
    if(a > b){
        max = a;
        min = b;
    } 
    else{
        max = b;
        min = a;
    } 
    
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array){
     for(int i = 0; i < array.Length; i++){
         Console.Write($"{array[i]} ");
     }
     Console.WriteLine();
}

void FindEl(int[] array, int num){
    bool flag = false;
    for(int i = 0; i < array.Length; i++){
        if(array[i] == num) flag = true; 
        }
    if(flag == true) Console.WriteLine("Заданное число в массиве есть");
    else Console.WriteLine("Заданного числа в массиве нет");
}

int[] array = CreateRandomeArray();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(array);
FindEl(array, num);
