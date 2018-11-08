using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiantion of object UProgram()
            var UProgram1 = new UProgram("Information technology");

            // Instantiantion of object Degree()
            var Degree1 = new Degree("Bachelor");

            //Instantiantion of object Course()
            var Course1 = new Course("Programming with C#");

            //Instantiantion of objects Student()
            Student Student1 = new Student("Marina", 12, "Student");
            Student Student2 = new Student("Anastasia", "Student");
            Student Student3 = new Student("Natalia", "Student");
            Student Student4 = new Student("Nastya", 23, "Student");

            //Instantiantion of object Teacher()
            var Teacher1 = new Teacher("Kseniya", 45, "Teacher");
            var Teacher2 = new Teacher("Natalia", 38, "Teacher");
                 
            //Adding students objects to Course.Students_A array object
            Course1.Students_A[0] = Student1;
            Course1.Students_A[1] = Student2;
            Course1.Students_A[2] = Student3;
            
            //Adding teacher objects to Course.Teacher_A array object
            Course1.Teachers_A[0] = Teacher1;
            Course1.Teachers_A[1] = Teacher2;

            //Adding course objects to Degree.Course_A array object
            Degree1.Course_A[0] = Course1;

            //Adding course objects to UProgram.Degree_A array object
            UProgram1.Degree_A[0] = Degree1;

            //Displays in console the name of the program and  degree's name 
            //from UProgram object.
            Console.WriteLine(UProgram1.UPName, UProgram1.Degree_A[0].degreeName);
            Console.WriteLine(Degree1.Course_A[0].CourseName);
       
            //More sofisticated way of displaying the above using Composite Formating and loops.
                                          
            Console.WriteLine("{0},{1},{2}", UProgram1.UPName, UProgram1.Degree_A[0].degreeName, Degree1.Course_A[0].CourseName);
            
            for (int i = 0;i< UProgram1.Degree_A[0].Course_A[0].Students_A.Length; i++ )
            {
                Console.WriteLine(
                    
                    "{0},{1},{2}", 
                    UProgram1.Degree_A[0].Course_A[0].Students_A[i].getName(),
                    UProgram1.Degree_A[0].Course_A[0].Students_A[i].getAge(),
                    UProgram1.Degree_A[0].Course_A[0].Students_A[i].getStatus()
                    
                    );
            }

            for (int i = 0; i < UProgram1.Degree_A[0].Course_A[0].Teachers_A.Length; i++)
            {
                Console.WriteLine(

                "{0},{1},{2}",
                UProgram1.Degree_A[0].Course_A[0].Teachers_A[i].getName(),
                UProgram1.Degree_A[0].Course_A[0].Teachers_A[i].getAge(),
                UProgram1.Degree_A[0].Course_A[0].Teachers_A[i].getStatus()

                );
            }

            //Using the methods from the classes Student and Teacher
            Console.WriteLine("Number of students " +Student.countStudents() );
            Console.WriteLine("Number of teachers " + Teacher.countStudents());

            //Using the inherited methods from abstract class Person
            Console.WriteLine(Student1.Test());
            Console.WriteLine(Teacher1.Test());

            //Using the method WriteFile() and ReadFile() to write and read the information above 
            //in a text file.
            UProgram1.Degree_A[0].Course_A[0].Students_A[0].WriteFile("Person.txt");
            Student1.ReadFile("Person.txt");
            Console.ReadKey();
            
        }
    }
}
