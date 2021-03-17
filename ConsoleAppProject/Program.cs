using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using System;
using System.Runtime;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Daniel Hale 09/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();
            DistanceConverter converter = new DistanceConverter();
            converter.ConvertDistance();

            ConsoleHelper.OutputHeading("\tBMI Calculator\n\tDaniel Hale");
            ConsoleHelper.OutputIntroduction("Thank you for using my BMI calculator. Please select either Metric or Imperial and type in your measurements.");

            BMI Calculator = new BMI();
            Calculator.OutputUnit();
            Calculator.GetUnit();
            Calculator.GetWeight();
            Calculator.GetHeight();
            Calculator.CalculateBMI();
            Calculator.OutputResult();
        }
    }
}
