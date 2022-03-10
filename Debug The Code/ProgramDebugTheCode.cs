using System.Globalization;

var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
var endDate = DateTime.ParseExact(Console.ReadLine(),
    "d.M.yyyy", CultureInfo.InvariantCulture);
var holidaysCount = 0;
for (var date = startDate; date <= endDate; date = date.AddDays(1))
    if (date.DayOfWeek == DayOfWeek.Saturday ||
        date.DayOfWeek == DayOfWeek.Sunday)
    {
        holidaysCount++;
    }

Console.WriteLine(holidaysCount);

/*
 * d.M.yyyy instead of dd.m.yyy
 * in if statemeng needs to be || instead of &&
 * date = date.AddDays(1)
 * holidaysCount++ in {} 
 */
