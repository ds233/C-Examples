int num;

Console.Write("Введите число, соответствующее дню недели: ");
num = Convert.ToInt32(Console.ReadLine());

if(num == 1){
    Console.WriteLine("Понедельник");
}
else if(num == 2){
    Console.WriteLine("Вторник");
}
else if(num == 3){
    Console.WriteLine("Среда");
}
else if(num == 4){
    Console.WriteLine("Четверг");
}
else if(num == 5){
    Console.WriteLine("Пятница");
}
else if(num == 6){
    Console.WriteLine("Суббота");
}
else if(num == 7){
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Число не соответствует дню недели");
}


//if(num == 1){Console.WriteLine("Понедельник");}
//if(num == 2){Console.WriteLine("Вторник");}
//if(num == 3){Console.WriteLine("Среда");}
//if(num == 4){Console.WriteLine("Четверг");}
//if(num == 5){Console.WriteLine("Пятница");}
//if(num == 6){Console.WriteLine("Суббота");}
//if(num == 7){Console.WriteLine("Воскресенье");}

