using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_B1_207
{
    public class Day5
    {
        static void Main(string[] args)
        {
            // Take an user Input 
            // String 
            Console.WriteLine("Enter Your Name : ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Your name is "+name1);

            // Integer User Input 

            Console.WriteLine("Enter your 1st number ");
            int num1= Convert.ToInt32(Console.ReadLine()); // explicit type casting 
            // string to int

            Console.WriteLine("Enter your 2nd number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result=num1 + num2;

            Console.WriteLine("The sum is : "+  result);


            // Character User Input 

            Console.WriteLine("enter your Character");
            char char1=Convert.ToChar(Console.ReadLine()); // explicit type casting

            Console.WriteLine("your char is " + char1);

        }
    }
}
