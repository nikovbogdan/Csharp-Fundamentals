int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = 0;

for (int i = a; i <= b; i++)
{
    Console.Write(i + " ");
    result += i;
}
Console.Write("\b\n");
Console.WriteLine("Sum :"  + result);