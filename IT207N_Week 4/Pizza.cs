using System;
using System.Collections.Generic;
using System.Text;

namespace IT207N_Week_4
{
    class Pizza
    {
        private string toppings;
        private int diameter;
        private double price;

        //get and set methods
        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price= value;
            }
        }
    }
}
