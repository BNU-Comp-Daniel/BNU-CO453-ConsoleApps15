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
            OutputHeading();
            Console.WriteLine("Converting Miles to Feet");
            Console.WriteLine();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

       public void FeetToMiles()
       {
            OutputHeading();
            Console.WriteLine("Converting Feet to Miles");
            Console.WriteLine();
            InputFeet();
            CalculateMiles();
            OutputMiles();
       }

       public void MilesToMetres()
       {
            OutputHeading();
            Console.WriteLine("Converting Miles to Metres");
            Console.WriteLine();
            InputMiles();
            CalculateMetres();
            OutputMetres();
       }

        private void OutputHeading()
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("      Distance Converter App       ");
            Console.WriteLine("          by Daniel Hale          ");
            Console.WriteLine("----------------------------------\n");
        }

        /// <summary>
        /// Allows the user to enter the distance in miles as a double.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Allows the user to enter the distance in feet as a double.
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// Allows the user to enter the distance in metres as a double.
        /// </summary>
        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
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
            miles = feet * FEET_IN_MILES;
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
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }

        /// <summary>
        /// Allows the program to give the output of the feet converted into miles as a double.
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }

        /// <summary>
        /// Allows the program to give the output of the miles converted into metres as a double.
        /// </summary>
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres!");
        }
    }
}
