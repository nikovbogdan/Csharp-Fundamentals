int num = int.Parse(Console.ReadLine());

if (num % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (num % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (num % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (num % 2 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else
{
    Console.WriteLine("Not divisible");
}
