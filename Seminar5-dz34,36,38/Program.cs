//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// int [] CreateRandomeArray(int size){
//      int a = new Random().Next(100, 1000);
//      int b = new Random().Next(100, 1000);
//      int max = 0;
//      int min = 0;
//      int [] array = new int[size];
//      if(a > b){
//          max = a;
//          min = b;
//      } 
//      else{
//          max = b;
//          min = a;
//      } 
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

// int EvenCounter(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         int a = array[i]%2;
//         if(a == 0) count++;
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomeArray(size);
// ShowArray(array);

// int even = EvenCounter(array);
// Console.WriteLine($"Количество четных значений в массиве: {even}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int [] CreateRandomeArray(int size){
//      int a = new Random().Next();
//      int b = new Random().Next();
//      int max = 0;
//      int min = 0;
//      int [] array = new int[size];
//      if(a > b){
//          max = a;
//          min = b;
//      } 
//      else{
//          max = b;
//          min = a;
//      } 
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

// int NotEvenSum(int[] array){
//     int count = 0;
//     for(int i = 1; i < array.Length; i += 2){
//         count += array[i];
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomeArray(size);
// ShowArray(array);

// int even = NotEvenSum(array);
// Console.WriteLine($"Сумма значений массива, расположенных на нечетных позициях: {even}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
double [] CreateRandomeArray(int size){                                         //создадим массив вещественных чисел
    double [] array = new double [size];
    double a = 0;
    for(int i = 0; i < size; i++){
        int flag = -1;                                                          //флаг нужен для создания отрицательного или положительного числа, пока установлен в значение -1. Положительное, если 0 и отрицательное, если 1.
        flag = new Random().Next(0,2);                                          //здесь будем щелкать flag в 0 или 1
        if(flag == 0) a = new Random().Next() * new Random().NextDouble();      //создать вещественное число оказалось не так просто, этот метод описан в оффициальном руководстве к С#
        else a = -1 * new Random().Next() * new Random().NextDouble();

        array[i] = a;
    }
    return array;
}

void ShowArray(double [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double MinElFinder(double [] array){                                            //создадим метод для определения минимального значения
    double min = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] < min){
            min = array[i];
        }
    }
    return min;
}

double MaxElFinder(double [] array){                                            //создадим метод для определения максимального значения
    double max = array[0];
    for(int i = 0; i < array.Length; i++){
        if(array[i] > max){
            max = array[i];
        }
    }
    return max;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = CreateRandomeArray(size);
ShowArray(array);

double raznost = MaxElFinder(array) - MinElFinder(array);
Console.WriteLine($"Разность между Максимальным и Минимальным значениями элементов массива равна: {raznost}");

