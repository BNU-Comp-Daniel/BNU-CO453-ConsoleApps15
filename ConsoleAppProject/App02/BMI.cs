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

        public double weight;
        public double height;

        public string SelectedUnit;

        public double bmiResult;

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

        public double GetWeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the weight in KGs: ");
            }
            else
            {
                Console.WriteLine("Please enter the weight in Stones: ");
                Console.WriteLine("Please enter the weight in Pounds: ");
            }
            return Convert.ToDouble(Console.ReadLine());
        }

        public double GetHeight()
        {
            if (SelectedUnit == METRIC)
            {
                Console.WriteLine("Please enter the weight in CMs: ");
            }
            else
            {
                Console.WriteLine("Please enter the weight in Feet: ");
                Console.WriteLine("Please enter the weight in Inches: ");
            }
            return Convert.ToDouble(Console.ReadLine());
        }

        public void CalculateBMI()
        {
            if(SelectedUnit == METRIC)
            {
                bmiResult = weight / (height * height);
            }
        }

        public void OutputResult()
        {
            Console.WriteLine(SelectedUnit + " " + bmiResult);
        }
    }
}
