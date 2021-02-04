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
        private double miles;
        
        private double feet;

        /// <summary>
        /// Allows the user to run the program.
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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
        /// Allows the program to calculate the miles and conver them into feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Allows the program to give the output of the miles converted into feet as a double.
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
    }
}
