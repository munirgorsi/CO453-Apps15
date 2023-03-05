using System;

namespace ConsoleAppProject.App02
{
    public enum UnitSystem
    {
        Matric,
        Imperial 
    }
    public class BMI
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.5;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundInStones = 14;

        private double index;
        private double kilograms;
        private double metres;
        private double pounds;
        private double inches;

        public void CalculateIndex()
        {
            ConsoleHelper OutputHeading("Body Mass Index Calculater");
            UnitSystem unitSystem = selectUnits();
            if (unitSystem == unitSystem.Metric)
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }
            else
            {
                InputImperialDetails();
                CalculateImperailBMI();
            }
            OutputHealthMessage();
        }
        public void CalculateMetricBMI()
        {
            index = kilograms / (metres * metres);
        }
        public void CalculateImperialBMI()
        {
            index = pounds * 703 / (inches * inches);
        }
        private UnitSystem SelectUnits()
    }
   
}