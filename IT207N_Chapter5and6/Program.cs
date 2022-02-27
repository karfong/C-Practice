using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT207N_Chapter5and6
{
    class Program
    {
        static void Main(string[] args)
        {
            /********* Chapter 5 *********/

            //TryParse() - convert string to int OR to check error (throw exception)
            bool result;
            int num;
            string myStr = "test";

            result = int.TryParse(myStr, out num);
            Console.WriteLine("The conversion is "+result);

            /***** Ternary Operator (?:) *****/
            int b = 10;
            int res;

            /*
             Compare the condition (expression 1). If the condition is true, return the first section (expression 2).
            If the condition is false, return second section (expression 3)
             */
            res = (b == 3) ? 20 : 40;//similar to if-else statement
            Console.WriteLine("The return value is " +res);//40

            //Nested ternary operator
            string rest;
            int x = 10, y = 20;

            rest = (x > y) ? "x > y" : (x < y) ? "x < y" : "x = y";

            /******** Chapter 6 Unconditional Transfer of Control *********/
            int number = 10;

            //break
            //goto
            switch (number)
            {
                case 1:
                    Console.WriteLine("Number One");
                    break;//termintate or exit case
                case 2:
                    Console.WriteLine("Number Two");
                    goto case 1;//goto - asking the program to execute certain condition
                default:
                    Console.WriteLine("Exit program...");
                    break;
            }

            //continue
            for (int i = 1; i < 11; i++)
            {
                if (i == 5)
                {
                    continue;//skip the current loop or condition and continues
                }

                Console.Write(i);//1234678910
            }

            //throw exception - built in error message
            try
            {
                ThrowExample(error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static string error = null;

        //function that use to identify errors (validation) and throw exception
        static void ThrowExample(string error)
        {
            if (error == null)
                throw new NullReferenceException("Display Error");
        }
    }
}
