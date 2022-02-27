using System;

namespace IT207N_Week_4
{
    class Student
    {
        /*Properties*/
        //Data members - by default is private
        private string firstName;
        private string course;
        private int studentID;

        /*1st type of constructor*/
        //Default construct0r-same name as class
        //always be public,no return value
        public Student()//can assign values in default constructor
        {
            firstName = "Grace";
            course = "DIIT";
            studentID = 1144;
        }
        /*2nd type-Constructor with parameters*/
        public Student(string fName,string Course)
        {
            //"this"keyword = refering to the existing class
            this.course = Course;//"DIIT" 
            this.firstName = fName;//"Jason"
        }
        /*3rd type-Overloaded Constructor*/
        public Student(string fName,string Course,int stuID)
        {

        }

        public Student(string fName,int stuID)
        {

        }
        /**Accessor(Get)and Mutator(Set)Methods**/
        //1st method
        public string FirstName
        {
            get
            {//always return the value of the variable declared
                return firstName;
            }
            set
            {//value = assigned value in constructor
                firstName = value;
            }
        }
        public string Course
        {
            get
            {
                return Course;
            }
            set
            {
                course = value;//"DIBA"
            }
        }

        //2nd Method(get and set)
        public string getFirstName()
        {
            return firstName;
        }
        //set method - always void and has one parameter
        public void setFirstName(string name)
        {
            name = firstName;
        }

        //ToString()-format the output which refers to get and set methods
        //display output
        public override string ToString()
        {
            return "The student name is"+this.getFirstName()+"in"+this.Course;
        }
        //this is optional
        static void Main(string[] args)
        {
            Student stu = new Student();

            Console.WriteLine(stu.ToString());
        }
    }
}
