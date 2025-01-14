﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public static Student student;

        

        //Creating RankedGradebook class

        public RankedGradeBook(String name,bool RankedGradebook):base(name,RankedGradebook) //Adding bool to the RankedGradeBook Constructor
        {
            this.Name = name;
            Type = Enums.GradeBookType.Ranked;
        }


        //Overiding GetLetterGrade Method
        public override char GetLetterGrade(double averageGrade)
        {
            var liczbastudentow = Students.Count;
            var procentowyprog = Convert.ToInt32(liczbastudentow * 0.2);
            Students.OrderByDescending(e => e.AverageGrade);
            var ocena = Students.Select(b => b.AverageGrade).ToList();

            if (liczbastudentow < 5)
            {
                throw new InvalidOperationException();


            }

            if (ocena[procentowyprog - 1] <= averageGrade)
            {
                return 'A';
            }
            else if (ocena[(procentowyprog * 2) - 1] <= averageGrade)
            {
                return 'B';
            }

            else if (ocena[(procentowyprog * 3) - 1] <= averageGrade)
            {
                return 'C';
            }

            else if (ocena[(procentowyprog * 4) - 1] <= averageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

           




           



        }


        //Overriding CalculateStatistics Method
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


        //Overriding CalculateStudentStatistics Method
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
