//Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и тд.)

// int [] ReverseMass(int[] array)
//  {
//     int temp=0;
 
 //ВАРИАНТ 1
    // for(int i=0; i<array.Length/2;i++)
    // {
    //     temp = array[i];
    //     array[i]=array[array.Length-1-i];    //-1 нужен для того, чтобы  попасть на последний индекс в массиве,т.к. индексы в массиве начинаются с 0, метод Lenght возвращает кол-во элементов. Если 6 элементов, то индексы с 0 по 5
    //     array[array.Length-1-i]=temp;
    // }

// ВАРИАНТ 2
//   for(int i=0, j=array.Length-1; i<j;i++, j--)
//     {
//         temp = array[i];
//         array[i]=array[j]; 
//         array[j]=temp;
//     }

// ВАРИАНТ 3
//     int i=0;
//     int j=array.Length-1;
//     while(i<j)
//     {
//         temp = array[i];
//         array[i]=array[j]; 
//         array[j]=temp;
//         i++;
//         j--;
//     }
//     return array;
// }

// int[] array={1,3,6,7,2,0};
// int[] revMas=ReverseMass(array);
// for(int i=0;i<revMas.Length;i++) Console.Write(revMas[i]+" ");



//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 19/2 9 ост 1
// 9/2  4 ост 1
// 4/2  2 ост 0
// 2/2  1 ост 0
// 1/2  0 ост 1
// 19 -> 10011

//МОЙ ВАРИАНТ
// void PrintArray(int[] col){
//     int count = col.Length-1;
//     while (count >=0){
//         Console.WriteLine(col[count]);
//         count--;
//     }
// }

// Console.Write("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count2 = 0;
// int x=num;

// for(int i=0; x>0; i++)
// {
    
//     x/=2;
//     count2++;
// } 

// int[] array = new int[count2];
// for(int i=0; num>0; i++)
// {
//     array[i]=num%2;
//     num/=2;
// } 

// PrintArray(array);

//ВАРИАНТ ПРЕПОДАВАТЕЛЯ

// string ChangeDigitSystem(int n)
// {
//     string result=string.Empty;
//     while(n>0)
//     {
//         result=n%2+result;
//         n/=2;
//     }
//     return result;
// }

// Console.Write("Enter number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string res=ChangeDigitSystem(num);
// Console.WriteLine(res);


//Напишите программу, которая принимает на вход числа и проверяет может ли существовать треугольник со сторонами такой длины
//Каждая сторона треугольника меньше суммы двух других сторон (теорема о неравенстве треугольника)
// void CheckTriangle(int a, int b, int c)
// {
//     if(a<b+c && b<a+c && c<a+b) Console.WriteLine("Triangle exists");
//     else Console.WriteLine("Triangle doesn't exists");
// }

// Console.Write("Enter number 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number 3: ");
// int c = Convert.ToInt32(Console.ReadLine());

// CheckTriangle(a,b,c);



//Не использую рекурсию выведите первые N чисел Фибоначчи. Первые два числа Ф. 0 и 1

void ShowArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] FibNum(int n)
{
    int[] array = new int[n];
    array[0]=0;
    array[1]=1;

    for(int i=2;i<n;i++)
    {
        array[i]=array[i-1]+array[i-2];
    }
    return array;
}

Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
ShowArray(FibNum(a));


