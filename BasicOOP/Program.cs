using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //instantiate(when you create an object out of a certain class) a class Car
            //Car = Class
            //Honda = Object
            Car honda = new Car();

            //assign value to the object
            honda.color = "red";
            honda.model = "City";
            honda.price = 850400.50;
            honda.speed = 250.10;
            honda.start();

            //we can create object as many as we want out of a class Car
            Car toyota = new Car();
            toyota.model = "vios";
            toyota.color = "black";
            toyota.price = 700500.50;
            toyota.speed = 280/90;
            */

            //instatiate and create a object

            //superclass - pinagkuhanan ng additional object 
            Person person = new Person(); 

            //derived class - mga kumuha sa super class ng additional object
            Teacher teacher = new Teacher(); 
            Student student = new Student();

            student.name = "John Mathew M. Estedula";
            student.age = 22;
            student.gender = "Male";

            Console.WriteLine(student.name + " " + " " + student.age + " " + student.gender);
            Console.ReadLine();
            

           // student.enroll();
           // student.enroll("John Mathew M. Estedula", "20140871-C");

           // student.payTuition();
           // student.payTuition(5000);


          //  teacher.name = "Esmeralda B. Abenir";
          //  teacher.age = 23;
          //  teacher.gender = "Female";
        }
    }
}
