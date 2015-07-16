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
            string name1 = "Charlie";
            string name2 = "charlie";

            // F12 on StringComparison to get the metadata view of the enum
            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine("name1 and name2 are equal? {0}", areEqual);

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
