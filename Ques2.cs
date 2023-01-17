
Console.WriteLine("Enter the booking time : ");
double time = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the flight fare : ");
double fare = Convert.ToDouble(Console.ReadLine());

//If booking time from 6am to 9am, apply 10% fare increase 

if (time > 6 && time < 9)
{
    fare = fare + (fare * 0.1);
    Console.WriteLine(fare);
}
//If booking time from 6am to 9am, apply 20% fare increase 
else if (time > 9 & time <= 17)
{
    fare = fare + (fare * 0.2);
    Console.WriteLine(fare);
}
//If booking time from 6am to 9am, apply 7% fare increase 
else if (time > 17 & time <= 23)
{
    fare = fare + (fare * 0.07);
    Console.WriteLine(fare);
}
else if (time > 24)
{
    Console.WriteLine("Not Valid!");
}
else
{
    fare = fare + (fare * 0.05);
    Console.WriteLine(fare);
}