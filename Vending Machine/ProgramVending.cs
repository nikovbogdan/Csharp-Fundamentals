string input = Console.ReadLine();
double totalMoney = 0.0;

while (input != "Start")
{
    if (double.Parse(input) == 0.1 || double.Parse(input) == 0.2 || double.Parse(input) == 0.5 || double.Parse(input) == 1 || double.Parse(input) == 2)
    { 
        totalMoney += double.Parse(input);
    }
    else
    {
        Console.WriteLine($"Cannot accept {double.Parse(input)}");
    }
    input = Console.ReadLine();

}

string product = Console.ReadLine();

while (product != "End")
{

    switch (product)
    {
        case "Nuts":
            if (totalMoney >= 2)
            {
                totalMoney -= 2;
                Console.WriteLine($"Purchased {product}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Water":
            if (totalMoney >= 0.7)
            {
                totalMoney -= 0.7;
                Console.WriteLine($"Purchased {product}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Crisps":
            if (totalMoney >= 1.5)
            {
                totalMoney -= 1.5;
                Console.WriteLine($"Purchased {product}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Soda":
            if (totalMoney >= 0.8)
            {
                totalMoney -= 0.8;
                Console.WriteLine($"Purchased {product}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Coke":
            if (totalMoney >= 1)
            {
                totalMoney -= 1;
                Console.WriteLine($"Purchased {product}");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        default:
            Console.WriteLine("Invalid product.");
            break;
    }


    product = Console.ReadLine();
}

Console.WriteLine($"Change: {totalMoney}");
