using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolProgram
{
    public class Teacher : Person 
    {


        //Creates int variable called "instances" and assigns value to 0
        //Used to count the number of times Student() constructor is used
       private static int instances = 0;


        //Constructor inherited from Person abstract class
        public Teacher(string name, int age, string status) : base (name, age, status)
        {
            instances++;
        }

        //Method to get the value of instances, thus numbers of Teachers objects created
        public static int countStudents()
        {
            return instances;
        }


        //Override method
        public override string Test()
        {
            return "Students grade scores: ";
        }


    }
}
