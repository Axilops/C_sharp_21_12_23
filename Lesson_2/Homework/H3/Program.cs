Console.Write("Введите число из отрезка [10, 99]:");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = a / 10;
int a2 = a % 10;
int max = a1 > a2 ? a1 : a2;
Console.WriteLine(max);