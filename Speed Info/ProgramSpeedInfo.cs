int i = int.Parse(Console.ReadLine());

if (i <= 10)
{
    Console.WriteLine("slow");
}
else if (i <= 50)
{
    Console.WriteLine("average");
}
else if (i <= 150)
{
    Console.WriteLine("fast");
}
else if (i <= 1000)
{
    Console.WriteLine("ultra fast");
}
else { Console.WriteLine("extremely fast"); }
