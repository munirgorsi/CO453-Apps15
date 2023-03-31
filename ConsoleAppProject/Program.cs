using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine("                by Muhammad Munir");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            SelectApp();
        }

        public static void SelectApp()
        {
            DistanceConverter converter = new DistanceConverter();
            PostsUI app04 = new PostsUI();

            string[] choices =
            {
                "App01: Distance Converter",
                "App02: BMI Calculator",
                "App03: Student Grades",
                "App04: Network App",
                "Quit"
            };

            bool quit = false;

            while (quit != true)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    //case 1: converter.Run(); break;
                    case 2: break;
                    case 3: break;
                    case 4: app04.DisplayMenue(); break;
                    case 5: quit = true; break;
                }
            }
        }
    }
}