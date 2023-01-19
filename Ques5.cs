Console.WriteLine("Enter the number of passenger: ");
int pass = Convert.ToInt32(Console.ReadLine());
decimal[] fare = new decimal[pass * 2];

int eindex = 0; 
int oindex = 1;

Console.WriteLine("Enter the passenger :");
for (int i = 0; i < pass; i++)
{
    decimal value = Convert.ToDecimal(Console.ReadLine());
    if (value % 2 == 0)
    {
        fare[eindex] = value;
        eindex += 2;
    }
    else
    {
        fare[oindex] = value;
        oindex += 2;

    }

}

foreach (var item in fare)
{
    Console.WriteLine("Array at even or odd positions :" );
    Console.WriteLine(item);
}




