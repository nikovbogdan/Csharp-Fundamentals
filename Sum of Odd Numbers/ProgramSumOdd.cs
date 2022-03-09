var n = int.Parse(Console.ReadLine());
var counter = 0;
var result = 0;

for (int i = 1; i < int.MaxValue; i++)
{
    if (counter == n)
    {
        break;
    }
    if (i % 2 != 0)
    {
        counter++;
        result += i;
        Console.WriteLine(i);
    }
}
Console.WriteLine($"Sum: {result}");
