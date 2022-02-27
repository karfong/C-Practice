using System;
using System.Collections.Generic;
using System.Text;

namespace IT207N_Week_4
{
    class TestPizza
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            p.Toppings = "pepperoni";//refers to set method(value)
            p.Diameter = 12;
            p.Price = 13.99;

            Console.WriteLine("p.Toppings");
            Console.WriteLine("p.Diameter");
            Console.WriteLine("p.Price");

            Console.ReadLine();
        }
        
    }
}
