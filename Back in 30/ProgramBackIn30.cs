var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());

var time = new TimeSpan(a, b + 30, 0);
Console.WriteLine($"{time:h\\:mm}");

