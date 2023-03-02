﻿

using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Muhammad Munir version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Ask user to enter distance in miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles");
            String Value = Console.ReadLine();
            miles = Convert.ToDouble(Value);

        }
        private void CalculateFeet()
        {

        }
        private void OutputFeet()
        {

        }
        private void OutputHeading()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("  App01: Distance Converter  ");
            Console.WriteLine("         By Muhammad Munir   ");
            Console.WriteLine("=============================");
        }

    }

}
