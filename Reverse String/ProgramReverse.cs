string input = Console.ReadLine();

string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
Console.WriteLine(Reverse(input));

