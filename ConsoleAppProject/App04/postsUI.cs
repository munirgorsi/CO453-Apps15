using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This Class wil be te user interface which alloed 
    /// </summary>
    internal class postsUI
    {
        public void Run()
            {
            string[] choices()
                "Distance Converter",
                "BMI Calculator",
                "Student Grades",
                "Network App",
                "another choice",
                "Quit"
            };
        bool quit = false;

            while (quit != true)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMessage(); break;
                    case 2: AddPhoto(); break;
                    case 3: DisplayAllPosts(); break;
                    case 4: break;
                    case 5: quit = true; break;
                }
}
        }
    }
}

    }
}
