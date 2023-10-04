int CalculateAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return CalculateAckermann(m - 1, 1);
    else
        return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
}

Console.Write("введите значение m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("введите значение n: ");
int n = int.Parse(Console.ReadLine());

int result = CalculateAckermann(m, n);
Console.WriteLine("A(" + m + ", " + n + ") = " + result);
