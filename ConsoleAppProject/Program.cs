using System;

using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
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
        public static StudentGrades StudentGrades
        {
            get => default;
            set
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                   By Muhammad Munir              ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            string[] choices = new string[3];

            choices[0] = "Distance Converter";
            choices[1] = "BMI calculator";
            choices[2] = "Students Grades Menu";

            int choice = ConsoleHelper.SelectChoice(choices);


            /*ConsoleHelper.OutputHeading("Please select you choice of app which you wish to use ");
            ConsoleHelper.SelectChoice(choices);*/

            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
               // converter.Run();
            }
            else if (choice == 2)
            {
                //BMI bmi = new BMI();
                BMI calculator = new BMI();
                //calculator.Run();

            }
            else if (choice == 3)
            {
                
                StudentGrades stu = new StudentGrades();
                stu.Run();

            }






        }
    }
}
