using System;

namespace HelloWorld_Holbrook_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {   // Ask user for First Name
            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine();

            // Ask user for Last Name
            Console.WriteLine("What is your Last Name?");
            String lastName = Console.ReadLine();

            // Makes Joke hehe.HaHa
            Console.WriteLine("What is your SSN for !!security reasons only!!");
            String SSN = Console.ReadLine();

            // Responds to user
            Console.WriteLine($"Hello, {firstName} {lastName} {SSN}!");
        }
    }
}
