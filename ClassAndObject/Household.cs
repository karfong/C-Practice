using System;

namespace ClassAndObject
{
    class Household
    {
        //data members
        private int occupants;
        private int income;

        //default constructor
        public Household()
        {
            occupants = 1;
            income = 0;
        }
        //Q2 part(a)-overloaded constructor which returns one integer argument
        public Household(int Occupant)
        {
            occupants = Occupant;
        }

        //Q2 part(b)-overloaded constructor which returns two integer argument
        public Household(int occup,int incm)
        {
            occupants = occup;
            income = incm;
        }
        //get method-have return value
        public int getOccupants()
        {
            return occupants;
        }
        //set method -always void and have parameter
        public void setOccupants(int occu)
        {
            //noOfOccupants is a private data field 
            //pass in as paramater via a public method
            occupants = occu;
        }

        public int getIncome()
        {
            return income;
        }

        public void setIncome(int inc)
        {
            income = inc;
        }
        //format the output
        //when we create object in Testhousehold,output display follow this format
        public override string ToString()
        {
            return "Number of occupants=" + getOccupants() + "and Income is" + getIncome();
        }

    }
}
