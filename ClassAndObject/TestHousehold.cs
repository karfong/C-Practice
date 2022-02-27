using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObject
{
    class TestHousehold
    {
        static void Main1(string[] args)
        {
            //create an object or instance which refers to default constructor
            Household house = new Household();

            //refers to overloaded constructor that return one int arguments(q2a)
            Household hse = new Household(20);

            //refers to overloaded constructor that return two integer arguments(q2b)
            Household h = new Household(30,5000);
            Console.WriteLine("House Details:{0}",house);
            Console.WriteLine("Second house details: {0}",hse);
           
            Console.ReadLine();
        }
    }
}
