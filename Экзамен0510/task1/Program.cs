Console.Write("введите значение n: ");
int N = int.Parse(Console.ReadLine());

Console.Write("числа от " + N + " до 1: ");

for (int i = N; i >= 1; i--)
{
    Console.Write(i);

    if (i > 1)
    {
        Console.Write(", ");
    }
}
