using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_B1_207
{
    public class Day18
    {
        static void Main(string[] args)
        {


            // 1-2+3-4+5-6......

            Console.WriteLine("Enter Your Range : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= number1; i++)
            {
                if (i % 2 == 0)
                {
                    result = result - i;
                }
                else
                {
                    result = result + i;
                }
            }

            Console.WriteLine("Your answer is : " + result);



            /*  print the pattern given below :
             
             * 
             * *
             * * *
             * * * *
             * * * * *
             

             */


            Console.WriteLine("Enter Your no of Rows : ");
            int rows1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            /*  print the pattern given below :
             
             * * * * * 
             * * * *
             * * *
             * * 
             * 
             

             */


            Console.WriteLine("Enter Your no of Rows : ");
            int rows2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows2; i++)
            {
                for (int j = i; j <= rows2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            //

            for (int i = 1; i <= rows2; i++)
            {
                for (int j = rows2; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //or 

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < rows2 - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            /*  print the pattern given below :
             
             * * * * * 
             * * * * *
             * * * * *
             * * * * *
             
             */


            Console.WriteLine("Enter Your no of Rows : ");
            int rows3 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows3; i++) // no of rows 
            {
                for (int j = 1; j <= 5; j++) // printing the elements in each row
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Square Pattern

            Console.WriteLine("Enter Your no of Rows : ");
            int rows4 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows4; i++) 
            {
                for (int j = 1; j <= rows4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
