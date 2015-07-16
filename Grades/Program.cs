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

        static void IncrementNumber(ref int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            //g1 = new GradeBook();
            g1.Name = "Scott's Book";
            Console.WriteLine(g2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);

            //GradeBook book = new GradeBook();
            //book.AddGrade(91f);
            //book.AddGrade(89.5f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine("Average grade: {0}", stats.AverageGrade);
            //Console.WriteLine("Highest grade: {0}", stats.HighestGrade);
            //Console.WriteLine("Lowest grade: {0}", stats.LowestGrade);

        }
    }
}
