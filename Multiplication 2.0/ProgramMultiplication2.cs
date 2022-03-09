var n = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());


if (b > 10)
{
    Console.WriteLine($"{n} X {b} = {n*b}");
}
else
{
    for (int i = b; i < 11; i++)
    {
        Console.WriteLine($"{n} X {i} = {n * i}");
    }
}

