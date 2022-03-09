string username = Console.ReadLine();
string password = Console.ReadLine();
int counter = 0;

string ReverseString(string srtVarable)
{
    return new string(srtVarable.Reverse().ToArray());
}

while (!password.Equals(ReverseString(username)))
{
    counter++;
    if (counter == 4)
    {
        Console.WriteLine($"User {username} is blocked!");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
    password = Console.ReadLine();
}
if (counter < 4)
{
    Console.WriteLine($"User {username} logged in.");
}

