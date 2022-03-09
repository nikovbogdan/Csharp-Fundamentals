string input = Console.ReadLine();
double result = 0;

switch (input)
{
    case "square":
        double a = double.Parse(Console.ReadLine());
        result = a * a;
        Console.WriteLine("{0:F3}", result);
        break;
    case "rectangle":
        double b1 = double.Parse((Console.ReadLine()));
        double b2 = double.Parse((Console.ReadLine()));
        result = b1 * b2;
        Console.WriteLine("{0:F3}",result);
        break;
    case "circle":
        double r = double.Parse((Console.ReadLine()));
        result = Math.PI * r * r;
        Console.WriteLine("{0:F3}", result);
        break;
    case "triangle":
        double v = double.Parse((Console.ReadLine()));
        double h = double.Parse((Console.ReadLine()));
        result = v * h /2;
        Console.WriteLine("{0:F3}", result);
        break;

}
