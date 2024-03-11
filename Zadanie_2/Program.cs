// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");


static float Average(int[] input)
{
    int sum = 0;
    int i = 0;
    foreach (var item in input)
    {
        sum += item;
        i++;
    }
    return sum/i;
}