using System;
using System.Collections.Generic;
using System.Threading;




namespace Prime_Numbers_Genereator
{
    class Program
    {

        public static List<int> Primes()
        {

            //Program introduction
            Console.WriteLine("Welcome to the prime numbers");
            Console.WriteLine("");

            // Asking for user input for value a
            Console.WriteLine("Please enter number of primes you want to see ");
            Console.WriteLine("");

            string a_string = Console.ReadLine();
            int user;
            // Validating user input
            while (!int.TryParse(a_string, out user))
            {
                Console.WriteLine("Not a valid number, please try to enter desired amount of primes again");
                a_string = Console.ReadLine();
            };

            Console.WriteLine("Analysing result...");

            // Creating list for the results
            List<int> even_nums = new List<int>();

            //Staring the main loop
            while (even_nums.Count != user)
            {
                //Starting nested loop analysing possible combinations
                for (int a = 2; a < user * 10; a++)
                {
                    for (int b = 2; b < user * 10; b++)
                    {
                        if (a != b && a % b == 0)
                        {
                            Console.WriteLine("Number " + a + "is not prime");
                            Thread.Sleep(500);
                            break;
                        }
                        else if (a != b && b % a == 0)
                        {
                            even_nums.Add(a);
                            Console.WriteLine("Number " + a + "is prime");
                            Thread.Sleep(500);
                            break;
                        }
                    }
                    


                    {
                        if (even_nums.Count == user)
                            break;
                    }
                }

            }
            //returning list of results
            return even_nums;

        }

        static void Main(string[] args)
        {
            //running 'Primes' method and displaying results
            Console.WriteLine("The numbers you asked for are: " + String.Join(",", Primes()));
        }


    }
}


