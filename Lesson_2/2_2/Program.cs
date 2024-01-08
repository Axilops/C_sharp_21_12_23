Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine()!);
int a2 = a % 100 / 10;
int a3 = a % 10;
double result = Math.Pow(a2,a3);
Console.WriteLine("Корень равен");
Console.WriteLine(result);