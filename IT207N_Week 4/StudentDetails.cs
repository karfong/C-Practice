using System;
using System.Collections.Generic;
using System.Text;

namespace IT207N_Week_4
{
    class StudentDetails
    {
        static void Main(string[] args)
        {
            //create object which belongs to Student class

            //refers to default constructor-"Grace","DIIT",1144
            Student stu = new Student();
            
            //refers to constructor with two parameters(firstname,course)
            Student stuOne = new Student("Jason","DIIT");

            //refers to constrcutor with three parameters(firstname,course,studentID)
            Student stuTwo = new Student("Grace","DICA",1122);

            /*use object to retrieve or to get the value
            -if the object is created in annother class,it has to access using the get method
            -no longer be able to access private attributes or data members
            -that's why we need to use get and set method(public)
            */

            //use get and set methods-1st method
            stu.Course = "DIBA";//set value
            Console.WriteLine("the course is"+stu.Course);

            //use get and set methods-2nd method
            Console.WriteLine("The student name is"+stu.getFirstName());//"Grace"
            Console.WriteLine("The other student name is"+stuOne.getFirstName());//"Jason"
            
            
            
            Console.ReadLine();
        }
    }
}
