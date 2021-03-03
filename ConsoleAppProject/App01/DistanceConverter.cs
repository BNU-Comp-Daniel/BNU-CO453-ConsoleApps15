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

        public double FromDistance { get; set; }
        public double ToDistance { get; set; }

        public string FromUnit { get; set; }
        public string ToUnit { get; set; }

        public DistanceConverter()
        {
            FromUnit = MILES;
            ToUnit = FEET;
            FromUnit = METRES;
            ToUnit = MILES;
            FromUnit = FEET;
            ToUnit = METRES;
        }


        /// <summary>
        /// This allows the user to be able to select the measurements they would like to use in their calculation.
        /// </summary>
        public void ConvertDistance()
        {

            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();
            
            OutputDistance();
        }

        /// <summary>
        /// This allows the program to be able to calculate the measurment convertion to give an accurate output.
        /// </summary>
        public void CalculateDistance()
        {
            if(FromUnit == MILES && ToUnit == FEET)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if(FromUnit == FEET && ToUnit == MILES)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if(FromUnit == METRES && ToUnit == MILES)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == MILES && ToUnit == METRES)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == FEET && ToUnit == METRES)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == METRES && ToUnit == FEET)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// This allows the user to be able to select a distance measurment.
        /// </summary>
        public string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        public static string ExecuteChoice(string choice)
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
        public static string DisplayChoices(string prompt)
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
        /// Allows the user to enter the number of a distance measurement as a double.
        /// </summary>
        public double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Allows the program to give the output as a double.
        /// </summary>
        public void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance}  {FromUnit}" +
                $" is {ToDistance}  {ToUnit}!\n");
        }
    }
}
