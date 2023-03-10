

using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The App will prompt the user to input a distance 
    /// measured in one unit miles and it will calculate and the output 
    /// the equivalent distance in another unit.
    /// </summary>
    /// <author>
    /// Muhammad Munir version 0.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";

        public const string METRES = "metres";

        public const string MILES = "miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;

            toUnit = FEET;
        }
        public void ConvertDistance()
        {
           //OutputHeading();

            fromUnit = SelectUnit(" Please select from the distance unit > ");
            toUnit   = SelectUnit(" Please select the distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
            fromDistance= InputDistance($" Please Enter the number of {fromUnit} > ");
            CalculateDistance();
            OutputDistance();
        }

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
            if(fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            Console.WriteLine( $" \n you have chosen {unit}");
            return unit;
        }
        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == ("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }
            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private double InputDistance(String prompt)
        {
            Console.Write(prompt);
            String Value = Console.ReadLine();
            return Convert.ToDouble(Value);

        }
     
        
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit}" + $" is {toDistance}{toUnit}!\n");
        }
     private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("        Distance converter      ");
            Console.WriteLine("        By Muhammad Munir       ");
            Console.WriteLine("===============================\n");
            Console.WriteLine(prompt);
            Console.WriteLine();
        }
     
    }

}
