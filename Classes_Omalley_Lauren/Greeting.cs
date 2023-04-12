using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Omalley_Lauren
{
    class Greeting
    {

        public void Welcome()

        {
            // Welcomes the user
            Console.WriteLine("Hello Traveler, welcome!");
        }

        public void Hello(string name)
        {
            // Tells the user thank you for joining us today
            Console.WriteLine($"{name}, thank you for joining us today!");
        }

    }
}
