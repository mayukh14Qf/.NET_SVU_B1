using System;

namespace BCA_B1_207
{
    public class Day3
    {
        static void Main(string[] args)
        {

            // Implicit Type Conversion

            double number1 = 45.89;
            double number2 = 89.69F;
            double number3 = 78;
            double number4 = '#';


            int number5 = 'A';


            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);

            // Explicit Conversion ( Type casting)

            int number6 =(int) 89.56;
            int number7 =(int) 96.58F;

            float number8  =(float) 96.78;

            char number9 = (char)110;

            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            Console.WriteLine(number9);


            char number10= Convert.ToChar(61);
            Console.WriteLine(number10);


            string string1 = Convert.ToString(1234);
            Console.WriteLine(string1);
            Console.WriteLine(string1.GetType());
            Console.WriteLine(1324.GetType());


            int number11 = Convert.ToInt32(23.47);
            Console.WriteLine(number11);

            // Operators

            Console.WriteLine(8965/10); // it will give you all the digits except the last one
            Console.WriteLine(8965 % 10); // it will give you the last digit only


            Console.WriteLine(13 % 2);


            number6 = number6 + 11;
            Console.WriteLine(number6);

            number6 += 10;
            Console.WriteLine(number6);

            number6++; // number6 += 1

            Console.WriteLine(number6);

            number6 *= 10;
            Console.WriteLine(number6);


        }
    }
}
