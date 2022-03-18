while (true)
{
    string input = Console.ReadLine();

    if (input == "END")
    {
        break;
    }

    bool integerChek = int.TryParse(input, out int integer);
    bool doubleCheck = double.TryParse(input, out double floating);
    bool charCheck = char.TryParse(input, out char mychar);
    bool booleanCheck = bool.TryParse(input, out bool boolean);

    if (integerChek)
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (doubleCheck)
    {
        Console.WriteLine($"{input} is double type");
    }
    else if (charCheck)
    {
        Console.WriteLine($"{input} is char type");
    }
    else if (booleanCheck)
    {
        Console.WriteLine($"{ input} is boolean type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }


}
