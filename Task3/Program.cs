int n = int.Parse(Console.ReadLine());
Console.WriteLine(CalculateSum(n));

int CalculateSum(int num)
{
    int result = 0;

    for (int i = 1; i <= num; i++)
    {
        result += i;
    }

    return result;
}
