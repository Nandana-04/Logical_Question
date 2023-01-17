using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgms
{
    internal class Class1
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter the names of 10 passenger: ");
            string[] arr = new string[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            //---------Print alphabetic order-------

            Console.WriteLine("Array in alphabetic order :");
            Array.Sort(arr);
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }

            //----Print reverse order-------

            Console.WriteLine("Array in reverse order :");
            Array.Reverse(arr);
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }

            //------Print the length of names in each element-------

            Console.WriteLine("Length of names in each element :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Length of elements in array: ");
                Console.WriteLine(arr[i].Length);
            }

            //------Input a name and search in array and display-----

            bool flag = false;
            Console.WriteLine("enter the name to search");
            var name = Console.ReadLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if (name == arr[i])
                {
                    Console.WriteLine("name has been found");
                    Console.WriteLine("position of the name");
                    Console.WriteLine(i);
                    flag = true;

                }
            }
            if (flag != true)
            {
                Console.WriteLine("name not found");

            }


            //---------Split the names at space and print for each element----------

            Console.WriteLine("Split the names at space and print for each element :");
            for (int i = 0; i < arr.Length; i++)
            {
                var arrayList = arr[i].Split(" ");
                Array.ForEach(arrayList, s => Console.WriteLine(s));
            }



            //------Print duplicate entries-------



            Console.WriteLine("Duplicate element :");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                }
            }

           
            



        }


    }
}
