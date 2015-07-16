using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "The New Gradebook";
        }

        static void IncrementNumber(out int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            Arrays();

            //Immutable();
            //PassByValueAndRef();

            //GradeBook book = new GradeBook();
            //book.AddGrade(91f);
            //book.AddGrade(89.5f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average grade: {0}", stats.AverageGrade);
            //Console.WriteLine("Highest grade: {0}", stats.HighestGrade);
            //Console.WriteLine("Lowest grade: {0}", stats.LowestGrade);

        }

        private static void Arrays()
        {
            float[] grades;
            grades = new float[4];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 4)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
                grades[3] = 0f;
            }
        }

        private static void Immutable()
        {
            string name = " Charles ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 07, 16);
            date = date.AddHours(25);

            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            //g1 = new GradeBook();
            g1.Name = "Scott's Book";
            Console.WriteLine(g2.Name);

            int x1;
            IncrementNumber(out x1);
            Console.WriteLine(x1);
        }
    }
}
