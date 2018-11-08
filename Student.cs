using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{

    public class Student : Person
    {


        //Creates int variable called "instances" and assigns value to 0
        //Used to count the number of times Student() constructor is used
        private static int instances = 0;

        //Inherited constructors
        public Student(string name, int age, string status) : base( name,  age, status)
        {
            instances++;
        }

        public Student(string name,  string status) : base(name, status)
        {
            instances++;
        }


        //Method to get the value of instances, thus numbers of Students objects created
        public static int countStudents()
        {
            return instances;
        }

        //Override method
        public override string Test()
        {
            return "Students check scores: ";
        }



    }
}
