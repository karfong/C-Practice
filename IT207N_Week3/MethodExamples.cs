using System;
using System.Collections.Generic;
using System.Text;

namespace IT207N_Week3
{
    class MethodExamples
    {
        //function with no parameters and no return value
        public void DisplayDetails()
        {

        }
       //function with parameters and return value
       //non-static method or instance method
        public int FindMaximum(int num1,int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
        //static or class method
        /*example: a car has 4 wheels-general information
         * if you dont need to know any other information about car,then you cn create static method
         */

        public static int FindMin(int val1, int val2)
        {
            int output;
            if (val1 > val2)
                output=val1;
            else
                output=val2;
            return output;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 80;

            int res;
            //call a non-static or instance method-have to create a class object /instance to call method
            MethodExamples exam = new MethodExamples();

            //use object to call non-static method
            res = exam.FindMaximum(a, b);

            //use class name to call static method
            MethodExamples.FindMin(a,b);
            Console.ReadLine();
     
        }
    }
}
