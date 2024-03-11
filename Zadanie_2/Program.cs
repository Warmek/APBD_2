// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");


static float Average(int[] input)
{
    int sum = 0;
    int i = 0;
    foreach (int item in input)
    {
        sum += item;
        i++;
    }
    return sum/i;
}

static float Max(int[] input)
{
    int max = input[0];
    foreach (var item in input)
    {
        if (item > max)
            max = item;
    }
    return max;
}