using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class TestBox
    {
        static void Main(string[] args)
        {
            Box b1= new Box(5);
            Box b2 = new Box(10,15);
            Box b3 = new Box(10,20,30);

            //Note:we can also display output using constructor other than ToString() method 
            Console.ReadLine();       
        }
    }
}
