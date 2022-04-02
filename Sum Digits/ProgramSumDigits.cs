int n = int.Parse(Console.ReadLine());
int result = n.ToString().Sum(c => c - '0');
Console.WriteLine(result);
