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
        public const string METRIC = "METRIC";
        public const string IMPERIAL = "IMPERIAL";

        public string SelectedUnit;

        public string[] MenuChoices = { METRIC, IMPERIAL };
        
        public void OutputUnit()
        {
            Console.WriteLine("Please choose between: ");
            ConsoleHelper.OutputMenu(MenuChoices);
        }

        public string GetUnit()
        {
            SelectedUnit = Console.ReadLine().ToUpper();
            return SelectedUnit;
        }

        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit);
        }
    }
}
