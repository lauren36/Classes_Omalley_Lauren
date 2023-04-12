using System;

namespace Classes_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the greeting object and calls the Welcome method
            Greeting greeting = new Greeting();
            greeting.Welcome();

            // Askes the user for their name and has a string for the response
            Console.WriteLine("What is your name squire?");
            string userName = Console.ReadLine();

            // Passes the users name as an argument
            greeting.Hello(userName);
        }
    }
}
