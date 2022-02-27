using System;
using System.Collections.Generic;
using System.Text;

namespace IT207N_Week3
{
    class MathClassExample
    {
        static void Main(string[] args)
        {
            //Math class-built in function
            int valueOne = 20;
            int valueTwo = 50;
            //find maximum value
            Console.WriteLine("The maximum value is"+Math.Max(valueOne,valueTwo));

            //find minimum value
            Console.WriteLine("The minimum value is" +Math.Min(valueOne,valueTwo));

            //round up the number
            double number = 12.99;
            Console.WriteLine("The value after round up is"+Math.Round(number));

            //square root
            double num = 80;
            Console.WriteLine(Math.Sqrt(num));

            //Power of
            double pw_num = Math.Pow(6,2);
            Console.WriteLine(pw_num);//36
        }
       
    }
}
