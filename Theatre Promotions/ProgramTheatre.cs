var day = Console.ReadLine().ToLower();
var age = int.Parse(Console.ReadLine());
var price = 0;

switch (day)
{
    case "weekday":
        if ((age >= 0 && age <= 18) || (age >= 65 && age <= 122))
        {
            price = 12;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 18;
        }
        break;
    case "weekend":
        if ((age >= 0 && age <= 18) || (age >= 65 && age <= 122))
        {
            price = 15;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 20;
        }
        break;
    case "holiday":
        if (age >= 0 && age <= 18)
        {
            price = 5;
        }
        else if (age >= 19 && age <= 64)
        {
            price = 12;
        }
        else if (age >= 65 && age <= 122)
        {
            price = 10;
        }
        break;
}
if (price != 0)
{
    Console.WriteLine(price + "$");
}
else
{
    Console.WriteLine("Error!");
}
