using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            //g1 = new GradeBook();
            g1.Name = "Scott's Book";
            Console.WriteLine(g2.Name);
     

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
