﻿Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if(a % b == 0){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
    Console.WriteLine(a % b);
}