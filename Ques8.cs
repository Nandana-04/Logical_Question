

namespace Flightfare
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter flight fares in decimal format of  passenger: ");
            decimal[] fare = new decimal[5];
            for (int i = 0; i < fare.Length; i++)
            {
                fare[i] = Convert.ToDecimal(Console.ReadLine());
            }
            Console.WriteLine("Enter destinations  of passenger: ");
            string[] destination = new string[5];
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the index between 5 :");
            int index = Convert.ToInt32(Console.ReadLine());


            if (index < 5) 
            {
                Console.WriteLine("Destination :" + destination[index]);
                Console.WriteLine("Fare :" + fare[index]);
            
            }
            else
            {
                Console.WriteLine("Not Valid");
            }


        }
    }
}
