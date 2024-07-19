using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_B1_207
{
    public class Day17
    {
        static void Main(string[] args)
        {



            // Check A Number is Perfect Number or Not

            Console.WriteLine("Enter Your Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            int sumOfFactors = 0;

            for (int i = 1; i < number1; i++)
            {
                if (number1 % i == 0)
                {
                    sumOfFactors += i; //sumOfFactors=sumOfFactors+i
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sumOfFactors);

            if (sumOfFactors == number1)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not A Perfect Number ");
            }




            // Print all digits of a Number

            Console.WriteLine("Enter Your Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            while (number2 > 0)
            {
                Console.WriteLine(number2 % 10);
                number2 = number2 / 10;
            }




            // Print sum of the digits

            Console.WriteLine("Enter Your Number : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int sumOfDigits = 0;

            while (number3 > 0)
            {
                sumOfDigits = sumOfDigits + (number3 % 10);
                number3 = number3 / 10;
            }

            Console.WriteLine(sumOfDigits);
        }
    }
}
