﻿using System;
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
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public StudentGrades() 
        {
            Students = new string[]
            {
                "Luke","Euan","Munir","Qasim","David",
                "Alan","Muhammad"

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

        }
        public void CalculateStats()
        {

        }
        public void CalculateGradeProfile()
        {

        }
    }

}
