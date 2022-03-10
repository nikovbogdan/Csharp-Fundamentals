//1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes

var input = double.Parse(Console.ReadLine());

var centuries = input;
var years = Math.Floor(100 * centuries);
var days = Math.Floor(365.2422 * years);
var hours = Math.Floor(24 * days);
var minutes = Math.Floor(60 * hours);
Console.WriteLine( $" {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");