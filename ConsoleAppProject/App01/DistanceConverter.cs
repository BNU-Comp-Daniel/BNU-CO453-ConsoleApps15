using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Daniel Hale version 0.3
    /// </author>
    public class DistanceConverter 
    { 
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }


        /// <summary>
        /// Allows the user to run the program.
        /// </summary>
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            
            //CalculateFeet();
            
            OutputDistance();
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoice(choice);
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Distance Converter App       ");
            Console.WriteLine("          by Daniel Hale          ");
            Console.WriteLine("----------------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

        /// <summary>
        /// Allows the user to enter the distance in miles as a double.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Allows the program to give the output as a double.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance}  {toUnit}!");
        }
    }
}
