using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This application will allow a tutor to enter a single mark of each of a list of 
    /// students and it will convert that mark into a grade. The application will 
    /// then be able to calculate simple statistics 
    /// and also calculate and display a student grade profile.
    /// </summary>
    
    /// <author>
    /// Muhammad Munir
    /// </author>
    public class StudentGrades
    {
        // Constants (Grade Boundaries)

        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark  = 100;


        // Properties 
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        
        // Attributes
        /// <summary>
        /// Class Constructor & set up array for students
        /// </summary>

        public StudentGrades() 
        {
            Students = new string[]
            {
                "Luke","Euan","Munir","Qasim","David",
                "Alan","Muhammad","Shaun","Mike","Saad",

            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }
        /// <summary>
        /// Marks Input for each student between 0 to 100
        /// </summary>
        private void DisplayMenue()
        {
            throw new NotImplementedException();
        }
        private void InputMarks()
        {
            ConsoleHelper.OutputHeading ("Please Enter Mark for Each Student");
            for (int i = 0; i < Students.Length; i++)
            {
                Marks[i] = (int) ConsoleHelper.InputNumber($"Enter{Students[i]} marks: ", LowestMark, HighestMark);
            }
            Console.WriteLine();
            ConsoleHelper.OutputHeading("Students Marks System");
            DisplayMenue("Please enter your choice > ");

        }
        /// <summary>
        /// 
        /// </summary>
        private void OutputMarks() 
        {

        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD &&mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if(mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }
        /// <summary>
        /// 
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            Minimum = HighestMark;
            Maximum = 0;
            foreach (int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;

        }
        /// <summary>
        /// 
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

        }
    }

}
