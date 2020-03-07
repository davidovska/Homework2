using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            string firstName = "Petko";
            string lastName = "Petkovski";

            string fullName = firstName + " " + lastName;


            Console.WriteLine(fullName);

            string nine = "9";
            string three = "3";

            string together = nine + three;

            Console.WriteLine(together);
            Console.ReadLine();

            #endregion

            #region Part 2

            int number = 200;
            string text = "stars";

            var concat  = number + " " + text;
            Console.WriteLine(concat);
            Console.ReadLine();


            #endregion

            #region Part 3
            int n = 102;
            int m = 5;

            var result = n / m;

            Console.WriteLine(result);
            Console.ReadLine();


            #endregion

            #region Bonus

            Console.WriteLine("Please insert a number:");

            var input = Console.ReadLine();

            int value;

            bool parsingNr = int.TryParse(input, out value);

            if(parsingNr) 
            {
                var evenOdd = value % 2 == 0 ? "even" : "odd";
                Console.WriteLine(evenOdd);

            }
            else
            {

                Console.WriteLine("Invalid input!");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
