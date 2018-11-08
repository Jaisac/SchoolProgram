using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SchoolProgram
{
    public class UProgram 
    {
        //###Defining properties of UProgram()
        //This UProgram has 1 property
        public string UPName { get; set; }
        public Degree[] Degree_A;

        //####Constructors
        //This constructor instantiates a UProgrma()
        //PS: The size of Array must be especified manually
        public UProgram (string upname)
        {
            this.UPName = upname;
            Degree_A = new Degree[1];
        }



 

        

        
    }
}
