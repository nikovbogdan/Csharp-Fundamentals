int n = int.Parse(Console.ReadLine());

string SMS = "";
for (int i = 0; i < n; i++)
{
    string number = Console.ReadLine();
    if (number[0] == '0')
    {
        SMS += " ";
    }
    int k = 2;
    for (int j = 'a'; j <= 'z';)
    {
        if (k == number[0] - '0')
        {
            j += number.Length - 1;
            SMS += (char)j;
        }

        if (k == 7 || k == 9)
        {
            j += 4;
        }
        else
        {
            j += 3;
        }
        k++;
    }

}
Console.WriteLine(SMS);
