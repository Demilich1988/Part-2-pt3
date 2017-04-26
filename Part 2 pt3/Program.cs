using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_2_pt3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *Chapter 10 Bool Try it out 
             * 
             */

            //Create Variable and gather input from user
            int score;
            Console.Write("Pleae enter score");
            string userInput = Console.ReadLine();
            score = Convert.ToInt32(userInput);

            int remainder = score % 2;

            //If else statement to see if even or odd
            if (remainder == 0) {
                Console.WriteLine("Number is even");
            }
            else
            {

                Console.WriteLine("Number is odd");
            }
            

            /*
             * Chapter 10 Positive or Negative Try it out
             * 
             */

            //Create Variable and gather input from user
            int testNumOne;
            int testNumTwo;
            Console.WriteLine("Pleae enter 2 numbers :");
            string userInputOne = Console.ReadLine();
            testNumOne = Convert.ToInt32(userInputOne);
            string userInputTwo = Console.ReadLine();
            testNumTwo = Convert.ToInt32(userInputTwo);

            //If elseif statement to check if both numbers are positive or negative. 
            if (testNumOne < 0 && testNumTwo < 0)
            {
                Console.WriteLine("Results should be positive");
            }
            else if (testNumOne > 0 && testNumTwo > 0)
            {
                Console.WriteLine("Results should be positive");
            }
            else
            {
                Console.WriteLine("Results should be negative");
            }




        }
    }
}
