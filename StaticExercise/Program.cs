using System.Security.Principal;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to convert Celsius to Fahrenheit or Fahrenheit to Celsius?");
            Console.WriteLine("Enter 1 for Celsius to Fahrenheit and 2 for Fahrenheit to Celsius");
            bool validInput = int.TryParse(Console.ReadLine(), out int userInput);

            while (userInput != 1 && userInput != 2 || validInput == false)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Type 1 for Yes and 2 for No");
                validInput = int.TryParse(Console.ReadLine(), out userInput);
            }

            if (userInput == 1)
            {
                Console.WriteLine("Enter your value in Celsius to convert to Fahrenheit");
                validInput = double.TryParse(Console.ReadLine(), out double userTemp);

                while (validInput == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Enter your value in Celsius to convert to Fahrenheit");
                    validInput = double.TryParse(Console.ReadLine(), out userTemp);
                }

                double newTemp = TempConverter.CelsiusToFahrenheit(userTemp);
                Console.WriteLine($"{userTemp} degrees Celsius is {newTemp} degrees Fahrenheit");

            }
            else if (userInput == 2)
            {
                Console.WriteLine("Enter your value in Fahrenheit to convert to Celsius");
                validInput = double.TryParse(Console.ReadLine(), out double userTemp);

                while (validInput == false)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Enter your value in Fahrenheit to convert to Celsius");
                    validInput = double.TryParse(Console.ReadLine(), out userTemp);
                }

                double newTemp = TempConverter.FahrenheitToCelsius(userTemp);
                Console.WriteLine($"{userTemp} degrees Fahrenheit is {newTemp} degrees Celsius");
            }
            else
            {

            }
        }
    }
}

