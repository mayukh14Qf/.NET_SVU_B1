using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_B1_207
{
    public class Day7
    {
        static void Main(string[] args)
        {

            // Conditional Statement
            // If and Else

            // print max between two numbers (user input)

            Console.WriteLine("Enter your 1st Number");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 2nd Number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Your Two Inputs should be Different");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("Your Greater number is " + number1);
            }
            else {
                Console.WriteLine("Your Greater number is " + number2);
            }









        }
    }
}
