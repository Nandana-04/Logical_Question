Console.WriteLine("Enter the name of the passenger : ");
string names=Console.ReadLine();

Console.WriteLine("Enter total miles travelled : ");
double total_miles = Convert.ToDouble(Console.ReadLine());

if (total_miles > 10000 && total_miles < 20000)
{
    Console.WriteLine("{0} travelled {1} miles and Award 10 frequent flyer points " , names,total_miles );
}
else if (total_miles > 20000 && total_miles < 50000)
{
    Console.WriteLine("{0} travelled {1} miles and Award 20 frequent flyer points ", names, total_miles);
}
else if (total_miles > 50000 && total_miles < 100000)
{
    Console.WriteLine("{0} travelled {1} miles and Award 30 frequent flyer points ", names, total_miles);
}
else if(total_miles > 100000)
{
    Console.WriteLine("{0} travelled {1} miles and Award 50 frequent flyer points ", names, total_miles);
}
else
{
    Console.WriteLine("{0} travelled {1} miles and Nooo flyer points ", names, total_miles);
}
