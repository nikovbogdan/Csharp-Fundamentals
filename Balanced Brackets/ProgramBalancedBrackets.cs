int n = int.Parse(Console.ReadLine());
int counter = 0;
string token = "";

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine().Trim();

    if (input == "(")
    {
        if (token == input)
        {
            Console.WriteLine("UNBALANCED");
            return;
        }
        token = input;
        counter++;
    }

    if (input == ")")
    {
        if (counter == 0)
        {
            Console.WriteLine("UNBALANCED");
            return;
        }
        token = "";
        counter--;
    }
}
if (counter == 0)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}

