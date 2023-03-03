

using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The App will prompt the user to input a distance 
    /// measured in miles and it will calculate and the output 
    /// the equivalent distance in feet.
    /// </summary>
    /// <author>
    /// Muhammad Munir version 0.2
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Ask user to enter distance in miles as a double number
        /// </summary>
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }
        /// <summary>
        /// prompt the user to enter the distance in miles
        /// input miles in double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            String Value = Console.ReadLine();
            miles = Convert.ToDouble(Value);

        }
        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            String Value = Console.ReadLine();
            metres = Convert.ToDouble(Value);

        }
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            String Value = Console.ReadLine();
            feet = Convert.ToDouble(Value);

        }
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;

        }
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;

        }
        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;

        }
        private void OutputFeet()
        {
            Console.WriteLine( miles + "miles is " + feet + "feet!");
        }
        private void OutputMiles()
        {
            Console.WriteLine(feet + "feet is " + miles + "miles!");
        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + "miles is " + metres + "metres!");
        }
        private void OutputHeading(String prompt)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("                Distance Converter                ");
            Console.WriteLine("                By Muhammad Munir                 ");
            Console.WriteLine("==================================================");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

    }

}
