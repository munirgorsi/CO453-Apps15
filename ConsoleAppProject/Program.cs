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
        
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            string[] choices = new string[2];

            choices[0] = "Distance Converter";
            choices[1] = "BMI calculator";

            //int choice = ConsoleHelper.SelectChoice(choices);


            ConsoleHelper.OutputHeading("Please select you choice of app which you wish to use ");
            //ConsoleHelper.SelectChoice(choices);

           // if (choices == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                //converter.Run();
            }
            //else if (choices == 2)
            {
                //BMI bmi = new BMI();
                BMI calculator = new BMI();
                //calculator.Run();

            }
           
         

          
           

        }
    }
}
