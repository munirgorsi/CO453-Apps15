using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// A Listing Of WHO Wight classification - Muhammad Munir
    /// </summary>
    public class BMI
    {
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculater");
            InputChoice();
        }
        public void InputChoice()
        {
            string[] choices = new string[]
            {
            "imerial units",
            "Metric Unit"
            };
            /*ConsoleHelper.OutputTitle("Please make your choice");
            return ConsoleHelper.SelectChoice(choices);*/
        }
    }
}
    