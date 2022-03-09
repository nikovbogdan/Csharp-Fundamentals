double budget = double.Parse(Console.ReadLine());
string input = Console.ReadLine();
double price = 0.00;
double spend = 0;

while (input != "Game Time")
{
    if (budget <= 0)
    {
        break;
    }
    switch (input)
    {

        case "OutFall 4":
            price = 39.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought OutFall 4");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        case "CS: OG":
            price = 15.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought CS OG");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        case "Zplinter Zell":
            price = 19.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought Zplinter Zell");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        case "Honored 2":
            price = 59.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought Honnored 2");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        case "RoverWatch":
            price = 29.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought RoverWatch");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        case "RoverWatch Origins Edition":
            price = 39.99;
            if (budget >= price)
            {
                budget -= price;
                spend += price;
                Console.WriteLine("Bought RoverWatch Origins Edition");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            break;
        default:
            Console.WriteLine("Not Found");
            break;
    }
    input = Console.ReadLine();
}
if (budget > 0)
{
    Console.WriteLine($"Total spent ${spend:f2}. Remaining ${budget:f}");
}
else
{
    Console.WriteLine("Out of money!");
}

