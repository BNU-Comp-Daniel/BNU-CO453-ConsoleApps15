﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        //Constants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //Properties
        public string [] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// This constructor sets up the array of students.
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Daniel", "Josh", "John",
                "Kimberly", "Sophie", "Bob",
                "Skye", "Alex", "Robert",
                "George"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

       /// <summary>
       /// Enter in the marks of the students.
       /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all of the student's current marks.
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Convert the marks to a grade.
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else return Grades.D;
        }

        /// <summary>
        /// Calculate and show the mean, minimum, maximum marks
        /// for the students.
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }
    }
}
