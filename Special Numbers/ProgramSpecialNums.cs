var n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 11 == 0)
    {
        Console.WriteLine(i + " -> True");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine(i + " -> True");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + " -> True");
    }
    else
    {
        Console.WriteLine(i + " -> False");
    }
}
