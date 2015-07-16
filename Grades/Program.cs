using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(GradeBook book)
        {
            book.Name = "The Gradebook";
        }

        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(g1);
            Console.WriteLine(g2.Name);

            //g1 = new GradeBook();
            g1.Name = "Scott's Book";
            Console.WriteLine(g2.Name);

            int x1 = 4;
            int x2 = x1;

            x1 = 100;
            Console.WriteLine(x2);

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
