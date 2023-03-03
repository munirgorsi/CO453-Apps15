

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
            miles = InputDistance("Please Enter the number of miles > ");
            CalculateFeet();
            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }
        /// <summary>
        /// Ask user to enter distance in miles as a double number
        /// </summary>
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");
            feet = InputDistance("Please Enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        /// <summary>
        /// prompt user to enter distance in feet 
        /// </summary>
        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres");
            miles = InputDistance("Please Enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
        }
        /// <summary>
        /// prompt the user to enter the distance in miles
        /// input miles in double number.
        /// </summary>
        private double InputDistance(String prompt)
        {
            Console.Write(prompt);
            String Value = Console.ReadLine();
            return Convert.ToDouble(Value);

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
        private void OutputDistance(double fromDistance, string fromUnit, double toDistance,
            string toUnit)
        {
            Console.WriteLine($"{fromDistance} {fromUnit}" + $" is {toDistance}{toUnit}!");
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
