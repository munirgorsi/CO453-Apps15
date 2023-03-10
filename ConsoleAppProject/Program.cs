using System;

using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;
using ConsoleAppProject.App02;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Muhammad Munir 05/02/2023
    /// </summary>
    public static class Program
    {
        private static int choice;
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            string[] choices = new string[]
        {
            "Distance Converter",
            "BMI calculator"
        };
            ConsoleHelper.OutputTitle("Please select you choice of app which you wish to use ");
            choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choice = = 2)
            {
                BMI calculator = new BMI();
                calculator.Run();

            }
           
         

          
           

        }
    }
}
