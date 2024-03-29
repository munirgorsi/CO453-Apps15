﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading;
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
        public const int HighestMark = 100;
        // Properties 
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public object StudentClass { get; private set; }
        public int MAXN_STUDENTS { get; private set; }

        // Attributes
        /// <summary>
        /// Class Constructor & set up array for students
        /// </summary>

        public void Run()
        {
            DisplayMenu();


        }
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
        public void DisplayMenu()
        {
            string[] choices = new string[5]
            {
                "Input Marks",
                "Ouput Marks",
                "Output Stats",
                "Ouput Grade Profile",
                "Quit"
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            GradeIndex(choiceNo);

        }
        public void GradeIndex(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    InputMarks();
                    break;
                case 2:
                    OutputMarks();
                    break;
                case 3:
                    CalculateStats();
                    break;
                case 4:
                    OutputGradeProfile();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.WriteLine("Please enter your choice > ");
                    Console.ReadLine();
                    break;
            }
        }

        public void CalculateStats()
        {
            double total = 0;
            Minimum = Marks[0];
            Maximum = Marks[0];
            foreach (int mark in Marks)
            {
                total += mark;
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }
            }
            Mean = total / Marks.Length;
            ConsoleHelper.OutputHeading(" Mean Mark");

            Console.WriteLine("Mean mark is " + Mean);
            Console.WriteLine();
            ConsoleHelper.OutputHeading("Student Marks System");
            DisplayMenu();
        }

        /// <summary>
        /// Marks Input for each student between 0 to 100
        /// </summary>

        public void InputMarks()
        {
            ConsoleHelper.OutputHeading("Please Enter Mark for Each Student");
            for (int i = 0; i < Students.Length; i++)
            {
                Marks[i] = (int)ConsoleHelper.InputNumber($"Enter{Students[i]} marks: ", LowestMark, HighestMark);
            }
            Console.WriteLine();
            ConsoleHelper.OutputHeading("Students Marks System");
            DisplayMenu();

        }

        /// <summary>
        /// OutPut of Marks with Grades and Class for all students 
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputHeading("The each Student Marks");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Student Name: {Students[i]} \tStudent Mark: {Marks[i]}\t" +
                    $"Student Grade: {ConvertToGrade(Marks[i])}\tStudent Class: {StudentClass}\t");
            }
            Console.WriteLine();
            ConsoleHelper.OutputHeading("Student Marks System");
            DisplayMenu();
        }
        /// <summary>
        /// Converstion of marks to Grades 
        /// </summary>
        
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                StudentClass = "Refered";
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                StudentClass = "Third Class";
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                StudentClass = "Lower Second";
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                StudentClass = "Upper Class";
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                StudentClass = "First Class";
                return Grades.A;
            }
            return Grades.F;
        }
        /// <summary>
        /// Grades Profile calculation 
        /// </summary>
        public void CalculateGradeProfile()
        {
            ConsoleHelper.OutputTitle("Grade Profile:");
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }
        /// <summary>
        /// Grades profile output with all Grades.
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.None;
            Console.WriteLine();
            ConsoleHelper.OutputHeading("The Student Grade Profile");
            int[] counts = new int[5];

            foreach (int mark in Marks)
            {
                if (mark >= 70)
                {
                    counts[4]++;
                }
               else if (mark >=60)
                {
                    counts[3]++;
                }
                else if (mark >= 50)
                {
                    counts[2]++;
                }
                else if (mark >= 40)
                {
                    counts[1]++;
                }
                else
                {
                    counts[0]++;
                }
            }
            int total =Marks.Length;
            Console.WriteLine($"A Grade: {((double)counts[4] / total)*100:F2}%");
            Console.WriteLine($"B Grade: {((double)counts[3] / total) * 100:F2}%");
            Console.WriteLine($"C Grade: {((double)counts[2] / total) * 100:F2}%");
            Console.WriteLine($"D Grade: {((double)counts[1] / total) * 100:F2}%");
            Console.WriteLine($"F Grade: {((double)counts[0] / total) * 100:F2}%");
            Console.WriteLine();
            ConsoleHelper.OutputHeading("Student Marks System");
            DisplayMenu();
        }
        /// <summary>
        /// exit command
        /// </summary>
        public void quit()
        {
            Environment.Exit(0);   
        } 
    }   
}





       
    


