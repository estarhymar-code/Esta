using System;
using System.ComponentModel.Design;

namespace Flight_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int id = 1;
            string from = "";
            string to = "";
            bool hasFlight = false;

            while(true)
            {
                Console.WriteLine("\n1 Add Flight");
                Console.WriteLine("\n2 View Flight");
                Console.WriteLine("\n3 Update Flight");
                Console.WriteLine("\n4 Delete Flight");
                Console.WriteLine("\n5 Search Flight");
                Console.WriteLine("\n6 Exit");

                Console.Write("Choose:");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("From:");
                    from = Console.ReadLine();

                    Console.WriteLine("To:");
                    to = Console.ReadLine();

                    hasFlight = true;

                    Console.WriteLine("Flight Added");
                }
                else if (choice == "2")
                {
                    if (hasFlight)
                        Console.WriteLine(id + ":" + from + "->" + to);
                    else
                        Console.WriteLine("No Flight Stored.");
                }
                else if (choice == "3")
                {
                    if (hasFlight)

                    Console.WriteLine("New Form:");
                    from = Console.ReadLine();
                    Console.WriteLine("New To:");
                    to = Console.ReadLine();

                    Console.WriteLine("Flight Updated");

                    else
                        Console.WriteLine("No flight to update");
                }
                else if (choice == "4")
                {

                }
            }

        }
        
    }
    
}
