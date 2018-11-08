using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    public class Course
    {   

        //###Defining properties of Course()
        //This Course class has 1 property
        public string CourseName { get; set; }
        public Student[] Students_A;
        public Teacher[] Teachers_A;

        //####Constructors
        //This constructor instantiates a Course() object while only having Name, Age and Gender information available.
        //####Constructors
        //PS: The size of Array must be especified manually. In this case for 3 Students and one Teacher.
        public Course(string course)
        {
            this.CourseName = course;
            Students_A = new Student[3];
            Teachers_A = new Teacher[2];
            
        }         
    }
}
