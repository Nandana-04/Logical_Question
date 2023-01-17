using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fare
{
    internal class Class1
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter flight fares in decimal format of 10 passenger: ");
            decimal[] fare = new decimal[10];
            for (int i = 0; i < fare.Length; i++)
            {
                fare[i] = Convert.ToDecimal(Console.ReadLine());
            }

            //----------------Ascending order----------

            Console.WriteLine("Array in ascending order :");
            Array.Sort(fare);
            foreach (decimal i in fare)
            {
                Console.WriteLine(i);
            }

            //------------Descending order---------

            Console.WriteLine("Array in descending order :");
            Array.Reverse(fare);
            foreach (decimal i in fare)
            {
                Console.WriteLine(i);
            }

            //----------Input a fare and search in array----------

            bool flag = false;
            Console.WriteLine("enter the fare to search");
            decimal num = Convert.ToDecimal(Console.ReadLine());
            for (int i = 0; i < fare.Length; i++)
            {
                if (num == fare[i])
                {
                    Console.WriteLine("fare has been found");
                    flag = true;

                }
            }
            if (flag != true)
            {
                Console.WriteLine("fare not found");

            }

            //----------max and min fares--------

            decimal max = fare[0];
            decimal min = fare[0];
            for ( int i = 1; i < fare.Length; i++)
            {
                if (fare[i] > max)
                {
                    max = fare[i];
                }
                else if (fare[i] < min) 
                {
                    min = fare[i];
                }
            }
            Console.WriteLine("Maximum element = {0}", max);
      
            Console.WriteLine("Minimum element = {0}", min);

            //--------duplicate elements------


            Console.WriteLine("Duplicate element :");
            for (int i = 0; i < fare.Length; i++)
            {
                for (int j = i + 1; j < fare.Length; j++)
                {
                    if (fare[i] == fare[j])
                        Console.WriteLine(fare[j]);
                }
            }

        }
    }
}
