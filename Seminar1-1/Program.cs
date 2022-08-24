int num;

//Ввод данных
Console.Write("Enter number: ");

num = Convert.ToInt32(Console.ReadLine());

//Вычисление квадрата
int square = num * num;

//Вывод ответа на экран
if(square >= 100){
    Console.WriteLine("Ого, какой большой квадрат: " + square);
}
else{
    Console.WriteLine("Квадрат введенного числа: " + square);
}

