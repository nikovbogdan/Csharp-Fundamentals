int peopleCount = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();
double total = 0;


switch (type)
{
    
    case "Students":
        
        switch (day)
        {
            case "Friday":
                total = peopleCount * 8.45;
                if (peopleCount >= 30)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
            case "Saturday":
                total = peopleCount * 9.80;
                if (peopleCount >= 30)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break ;
            case "Sunday":
                total = peopleCount * 10.46;
                if (peopleCount >= 30)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
        }
       
        break;
    case "Business":
        switch (day)
        {
            case "Friday":
                total = peopleCount * 10.90;
                if (peopleCount > 100)
                {
                    total *= 0.90;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
            case "Saturday":
                total = peopleCount * 15.66;
                if (peopleCount > 100)
                {
                    total *= 0.90;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
            case "Sunday":
                total = peopleCount * 16;
                if (peopleCount > 100)
                {
                    total *= 0.90;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
        }
      
        break;
    case "Regular":
        switch (day)
        {
            case "Friday":
                total = peopleCount * 15;
                if (peopleCount >= 10 && peopleCount <=20)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
            case "Saturday":
                total = peopleCount * 20;
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
            case "Sunday":
                total = peopleCount * 22.50;
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    total *= 0.85;
                }
                Math.Round(total, 2);
                Console.WriteLine("Total price: " + total);
                break;
        }
        
        break;

      



}
