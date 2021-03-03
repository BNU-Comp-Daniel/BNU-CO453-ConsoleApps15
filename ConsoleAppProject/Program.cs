using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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

            ConsoleHelper.OutputHeading("\tBMI Calculator\n\tDaniel Hale");
            ConsoleHelper.OutputIntroduction("Insert BMI introduction here");

            BMI Calculator = new BMI();
            Calculator.OutputUnit();
            Calculator.GetUnit();
            Calculator.OutputResult();
        }
    }
}
