﻿string countryName = Console.ReadLine();

switch (countryName)
{
    case "USA":
    case "England":
        Console.WriteLine("English"); break;
    case "Mexico":
    case "Argentina":
    case "Spain":
        Console.WriteLine("Spanish"); break;
    default:
        Console.WriteLine("unknown"); break;
}
