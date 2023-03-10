using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constants

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
        /// 
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
        public void InputMarks()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void OutputMarks() 
        {
        }
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }
        public void CalculateStats()
        {

        }
        public void CalculateGradeProfile()
        {

        }
    }

}
