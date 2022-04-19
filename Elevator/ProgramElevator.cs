int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

if (p > n)
{
    Console.WriteLine("All the persons fit inside in the elevator.\nOnly one course is needed.");
}
else
{
    int courses = (int)Math.Ceiling((double)n / p);
    Console.WriteLine(courses);
}


