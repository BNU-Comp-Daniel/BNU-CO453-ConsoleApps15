using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Daniel Hale version 0.1
    /// </author>
    public class BMI
    {
        public const string METRIC = "Metric";
        public const string IMPERIAL = "Imperial";

        public string SelectedUnit;
        
        public void OutputUnit()
        {
            Console.WriteLine("Please choose between: ");
            Console.WriteLine("1. " + METRIC);
            Console.WriteLine("2. " + IMPERIAL);

            string input = Console.ReadLine().ToUpper();
        }

        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }
    }
}
