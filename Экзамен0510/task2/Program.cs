int M, N;
int sum = 0;

Console.Write("введите значение M: ");
M = Convert.ToInt32(Console.ReadLine());

Console.Write("введите значение N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i <= N; i++)
{
    sum += i;
}

Console.WriteLine("сумма элементов от " + M + " до " + N + " равна " + sum);
