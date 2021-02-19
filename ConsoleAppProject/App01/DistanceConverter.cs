using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Daniel Hale version 0.1
    /// </author>
    public class DistanceConverter 
    { 
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;
        
        private double feet;

        public double metres;


        /// <summary>
        /// Allows the user to run the program.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");
            
            CalculateFeet();
            
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }

       public void FeetToMiles()
       {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");
            
            CalculateMiles();
            
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
       }

       public void MilesToMetres()
       {
            OutputHeading("Converting Miles to Metres");

            miles = InputDistance("Please enter the number of miles > ");
            
            CalculateMetres();
            
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
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
        /// Allows the program to calculate the miles and convert them into feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// Allows the program to calculate the feet and convert them into miles.
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Allows the program to calculate the miles and convert them into metres.
        /// </summary>
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        /// <summary>
        /// Allows the program to give the output of the miles converted into feet as a double.
        /// </summary>
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance}  {fromUnit}" +
                $" is {toDistance}  {toUnit}!");
        }
    }
}
