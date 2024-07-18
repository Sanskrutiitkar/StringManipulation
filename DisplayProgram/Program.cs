using System;

namespace DisplayProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // Split the input string by the comma delimiter
                string[] parts = args[0].Split(',');

                // Extract the individual values
                string developerName = parts[0];
                string companyName = parts[1];
                string location = parts[2];

                // Display the output
                Console.WriteLine($"Developer name is: {developerName}");
                Console.WriteLine($"Company name is: {companyName}");
                Console.WriteLine($"Location is: {location}");
            }
            else
            {
                Console.WriteLine("Please provide the input string as a command-line argument.");
            }
        }
    }
}
