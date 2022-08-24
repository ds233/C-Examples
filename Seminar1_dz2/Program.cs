//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine("Большее: " + num1);
    Console.WriteLine("Меньшее: " + num2);
}
else if(num1 < num2){
    Console.WriteLine("Большее: " + num2);
    Console.WriteLine("Меньшее: " + num1);
}
else{
    Console.WriteLine("Числа равны");
}