using System;
using MyNewApp.Utilites; // alternatively the namespace can be resolved with the "using" statement

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";

            string reversedValue = Reverse(value); // method from same class
            string reversedValue2 = Utility.Reverse(value); // method from different class
            string reversedValue3 = Utilites.Utility.Reverse(value); // method from different namespace
            // if the method was in a completely different namespace (not MyNewApp) then the new namespace name would be appended to the start

            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }

    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

namespace MyNewApp.Utilites
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}