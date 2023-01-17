using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fare
{
    internal class Class2
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the Date of Birth  of 10 passenger: ");
            DateTime [] DoB = new DateTime[10];
            for (int i = 0; i < DoB.Length; i++)
            {
                
                DoB[i] =Convert.ToDateTime( Console.ReadLine());
                
            }

            

            for (int i = 0; i < DoB.Length; i++)
            {
                var today = DateTime.Today;
                var age = today.Year - DoB[i].Year;

                //--------Age < 10, print as Kid---------

                if (age < 10)
                {
                    Console.WriteLine("The age is {0} Kid",age);
                }

                //----------Age > 10 and age<30 print as Youth---------

                else if (age > 10  & age < 30)
                {
                    Console.WriteLine("The age is {0} Youth",age);
                   
                }

                //--------Age > 30 and age<60 print Adult----------

                else if (age > 30 & age < 60)
                {
                    Console.WriteLine("The age is {0} Adult", age);
                    
                }

                //-----------Age > 60 print Older---------

                else
                {
                    Console.WriteLine("The age is {0} Older", age);
                   
                }
            }

            
                
            

        }
    }
}
