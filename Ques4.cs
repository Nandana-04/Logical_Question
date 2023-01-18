Console.WriteLine("Enter the Date of Birth :");
var dob = DateTime.Parse(Console.ReadLine());


var year = dob.Year;
if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year");
}



TimeSpan day = DateTime.Now - dob;
Console.WriteLine("Age in Years :" + day.Days / 365);
Console.WriteLine("age in Months :" + (day.Days / 365) * 12);
Console.WriteLine("age in weeks : " + day.Days / 7);
Console.WriteLine("age in Days : " + day.Days);
Console.WriteLine("age in Hours : " + day.Days * 24);




