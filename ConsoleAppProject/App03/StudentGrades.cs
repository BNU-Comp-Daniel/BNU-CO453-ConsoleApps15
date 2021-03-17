using System;
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
        public double InputMarks(int mark)
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
        /// Convert the marks to a letter grade.
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB)
            {
                return Grades.B;
            }
            else return Grades.A;
        }

        /// <summary>
        /// Calculate and show the mean, minimum, maximum marks
        /// for the students.
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach(int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;

            }
        }

        public void OutputGradeProfile()
        {
            CalculateGradeProfile();

            Grades grade = Grades.X;
            Console.WriteLine();
            
            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
        }
    }
}
