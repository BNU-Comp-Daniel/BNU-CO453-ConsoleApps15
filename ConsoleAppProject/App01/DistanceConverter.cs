using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The main feature of this application is to be able to select a 
    /// distance measurement and be ablt to convert that to another distance measurement of the the user's choice
    /// and get an accurate calculation of the converted measurement.
    /// </summary>
    /// <author>
    /// Daniel Hale version 0.4
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
            fromUnit = METRES;
            toUnit = MILES;
            fromUnit = FEET;
            toUnit = METRES;
        }


        /// <summary>
        /// This allows the user to be able to select the measurements they would like to use in their calculation.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();
            
            OutputDistance();
        }

        /// <summary>
        /// This allows the program to be able to calculate the measurment convertion to give an accurate output.
        /// </summary>
        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if(fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// This allows the user to be able to select a distance measurment.
        /// </summary>
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
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

        /// <summary>
        /// This allows the program to display all the choices to the user.
        /// </summary>
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

        /// <summary>
        /// Allows the program to display this heading.
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Distance Converter App       ");
            Console.WriteLine("          by Daniel Hale          ");
            Console.WriteLine("----------------------------------\n");
        }

        /// <summary>
        /// Allows the user to enter the number of a distance measurement as a double.
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
            Console.WriteLine($"\n {fromDistance}  {fromUnit}" +
                $" is {toDistance}  {toUnit}!\n");
        }
    }
}
