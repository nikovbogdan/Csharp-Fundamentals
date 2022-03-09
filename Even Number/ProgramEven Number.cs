var i = int.Parse(Console.ReadLine());

while(true)
{
    if (Math.Abs(i) % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(i)}");
        break;
    }
    else
    {
        Console.WriteLine("Please write even number.");
    }
    i = int.Parse(Console.ReadLine());
}
