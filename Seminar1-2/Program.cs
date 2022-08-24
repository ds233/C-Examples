int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2){
    Console.WriteLine("Поздравляем! Первое число является квадратом второго.");
}
else{
    Console.WriteLine("Увы! Первое число не является квадратом второго.");
}
