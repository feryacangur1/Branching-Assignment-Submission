using System;

namespace ShippingQuoteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the initial greeting message for the shipping application
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Asks the user to input the weight of their package
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            // Validates if the package exceeds the maximum weight limit
            if (weight > 50)
            {
                // Informs user that the package cannot be shipped due to weight restrictions
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Terminates the program execution
            }

            // Collects the width dimension from the user
            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());

            // Collects the height dimension from the user
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());

            // Collects the length dimension from the user
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());

            // Checks if the combined dimensions are within acceptable limits
            if (width + height + length > 50)
            {
                // Notifies the user that the package dimensions are too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exits the program
            }

            // Performs the shipping cost calculation based on package specifications
            float quote = (height * width * length * weight) / 100;

            // Shows the calculated shipping cost to the user formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Pauses the program until the user presses any key
            Console.ReadKey();
        }
    }
}