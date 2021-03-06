﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
            IsWeighted = isWeighted;
        }
        public char GetLetterGrade(double averageGrade)
        {
            if (averageGrade < 5) throw new InvalidOperationException();
            if (averageGrade == (int)Math.Ceiling(Students.Count * 0.2))
            {
                return 'A';
            }
            else if (averageGrade > (int)Math.Ceiling(Students.Count * 0.2) && averageGrade < (int)Math.Ceiling(Students.Count * 0.4))
            {
                return 'B';
            }
            else if (averageGrade > (int)Math.Ceiling(Students.Count * 0.4) && averageGrade < (int)Math.Ceiling(Students.Count * 0.6))
            {
                return 'C';
            }
            else if (averageGrade > (int)Math.Ceiling(Students.Count * 0.6) && averageGrade < (int)Math.Ceiling(Students.Count * 0.8))
            {
                return 'D';
            }

            return 'F';
        }
        override public void CalculateStatistics()
        {
            if (Students.Count < 5) Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else base.CalculateStatistics();
        }
        override public void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5 ) Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            else base.CalculateStudentStatistics(name);
        }
    }
}
