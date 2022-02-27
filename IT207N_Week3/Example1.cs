using System;

namespace IT207N_Week3
{
    class Example1
    {
        //private-only be able to access within its own class
        //always declare as private variable/data members or attributes
        private string name;
        private string loc;

        //internal -accessible within same assembly or package
        internal string firstName;
        internal int age;

        //protected -only be able to access with in the same class or child class(inheritance)
        protected string address;
        
        
    }
class Example: Example1
    {
    //must create a class object in Main() function
    //<access modifier><return type><method name><parameters list>
    static void Main(string[] args) {
        //create object that belongs to the class example1
        Example1 user = new Example1();

        //create an object that belongs to class Example
        Example exam = new Example();

        exam.address = "Penang";
        }
    }
}
