using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    public class Degree
    {

        //Defining properties of Degree()
        //This Course class has 2 properties
        public string degreeName { get; set; }
        public Course[] Course_A;

        //####Constructors
        //This constructor instantiates a Degree() object.
        //PS: The size of Array must be especified manually
        public Degree(string degree)
        {
            this.degreeName = degree;
            Course_A = new Course[1];
        }


    }
}
