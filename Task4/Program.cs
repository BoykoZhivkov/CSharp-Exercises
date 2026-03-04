int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i * 2 - 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
