int input = int.Parse(Console.ReadLine());
long result = 0;
for (int i = 1; i <= input; i++)
{
    string[] numbers = Console.ReadLine().Split(" ");

    long a = long.Parse(numbers[0]);
    long b = long.Parse(numbers[1]);


    if (a > b)
    {
        result = 0;
        while (a != 0)
        {
            result += a % 10;
            a /= 10;
        }
        Console.WriteLine(result);
    }
    else
    {
        result = 0;
        while (b != 0)
        {
            result += b % 10;
            b /= 10;
        }
        Console.WriteLine(result);
    }




}
