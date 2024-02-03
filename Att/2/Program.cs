Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int n, int m)
{
    Console.Write(Akkerman(n, m)); 
}

int Akkerman(int m, int n)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return (Akkerman(n - 1, Akkerman(n, m - 1)));
    }
}