using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    //create class
    class Car
    {
        //define properties to class
        public string color { get; set; }
        public double speed { get; set; }
        public double price { get; set; }
        public string model { get; set; }


        //public (can be directly called once the object is created) and private (it is called within a method and it is not visible when object is created) are called class modifiers
        //define a method(create an action) in class
        //void = no return type
        public void start()
        {
            Console.WriteLine("the car started");
            Console.ReadLine();
        }

        public void accelerate()
        {
            Console.WriteLine("the car accelerated");
            Console.ReadLine();
        }

        public void stop()
        {
            Console.WriteLine("the car stop");
            Console.ReadLine();
        }

        public void park()
        {
            Console.WriteLine("the car parked");
            Console.ReadLine();
        }
    }
}
