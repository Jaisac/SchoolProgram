using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;


namespace SchoolProgram
{
    public abstract class Person :IDisposable
    {

        //Defining properties of Person()
        //This Student class has 3 properties. 
        private string Name { get; set; }
        private int Age { get; set; }
        private string Status { get; set; }

       

        //This constructor instantiates a Person() object while only having Name, Age and Status information available.
        public Person(string name, int age, string status)
        {
            this.Name = name;
            this.Age = age;
            this.Status = status;

            if (this._isDisposed)
            {
                throw new ObjectDisposedException("Person object is disposed.");
            }
   
        }

        //This constructor instantiates a Person() object while only having Name and Status information available.
        public Person(string name, string status)
        {
            this.Name = name;
            this.Status = status;
            if (this._isDisposed)
            {
                throw new ObjectDisposedException("Person object is disposed.");
            }

        }

        //This constructor instantiates a Person() object while only having Name and Age information available.
        public Person(string name, int age )
        {
            this.Name = name;
            this.Age = age;
            if (this._isDisposed)
            {
                throw new ObjectDisposedException("Person object is disposed.");
            }


        }



        //Methods
        public string getName()
        {
            return this.Name;
        }

        public int getAge()
        {
            return this.Age;
        }

        public string getStatus()
        {
            return this.Status;
        }

        //Abstract methods for future test
        public abstract string Test();


        //Tracker for the disposal status of an object
        private bool _isDisposed = false;

        //Components to work with files
        StreamReader sr;
        StreamWriter outputFile;


        //Method to read files
        public  void ReadFile (string fileName)
        {
            sr = new StreamReader(fileName);
            try
            {                 
                 //Open the text file using a stream reader.
                using (sr)
                {
                    //Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Closing of StreamReader and implements the dispose method
                sr.Close();
                sr = null;
            }
        }

        //Method to write in files
        public bool WriteFile(string fileName)
        {
            bool result = false;
            outputFile = new StreamWriter(fileName);

            //Create a string array with the lines of text.
            string[] lines = { this.Name, this.Age.ToString(), this.Status };

            try
            {
                using (outputFile)
                {
                    foreach (string line in lines)
                        outputFile.Write(line + ", ");
                }
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine("This file could not be written.");
                Console.WriteLine(e.Message);
                result = false;

            }
            finally
            {
                outputFile.Close();
                outputFile = null;
            }

            return result;
        }

        // Implementing IDisposable method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //Dispose pattern
        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                    if (outputFile != null)
                    {
                        outputFile.Close();
                    }
                }
            }
           _isDisposed = true;
        }

        //Destructor
        ~Person()
        {
            Dispose(false);
        }

    }
}
