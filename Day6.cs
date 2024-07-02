using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_B1_207
{
    public class Day6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number :");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int fetch1 = num1 % 10; // it will be giving us last digit
            int fetch2 = num2 % 10;

            Console.WriteLine("Your Sum Of the Last digits is : " + (fetch1+fetch2)); //

        }
    }
}
