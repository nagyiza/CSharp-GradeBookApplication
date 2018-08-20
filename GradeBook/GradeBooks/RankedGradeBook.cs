using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
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
    }
}
