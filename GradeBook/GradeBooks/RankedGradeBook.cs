using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public static Student student;


        public RankedGradeBook(String name,bool RankedGradebook):base(name,RankedGradebook)
        {
            this.Name = name;
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int allstudentpoints1 = 0;

            foreach (var student in Students)
            {
                allstudentpoints1 = (int)+ student.AverageGrade;
            }

            int averageofallstudents = allstudentpoints1 / Students.Count;


            if (averageGrade >= averageofallstudents + 10)
                return 'A';   




            else if (averageGrade >= averageofallstudents)
                return 'B';
            else if (averageGrade >= averageofallstudents - 10)
                return 'C';
            else if (averageGrade >= averageofallstudents - 20)
                return 'D';
            else
                return 'F';

            //else
            //{
            //    if (averageGrade >= 90)
            //        return 'A';
            //    else if (averageGrade >= 80)
            //        return 'B';
            //    else if (averageGrade >= 70)
            //        return 'C';
            //    else if (averageGrade >= 60)
            //        return 'D';
            //    else
            //        return 'F';
            //}

            //List<double> AverageGrades = new List<double>();

            //// ile jest wszystkich studentow 
            //int x = Students.Count;

            ////lista srednich wszystkich studentow posortawana
            //if (x < 5)
            //{
            //    throw new InvalidOperationException();
            //}
            //else
            //{
            //    foreach (Student item in Students)
            //    {
            //        AverageGrades.Add(item.AverageGrade);

            //    }
            //}



           
        }

        public override void CalculateStatistics()
        {
            int y = Students.Count;
            if (y<5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (y >= 5)
            {
                base.CalculateStatistics();
            }
           
        }

        public override void CalculateStudentStatistics(string name)
        {
            int b = Students.Count;
            if (b < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else if (b >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
            
        }

    }
}
