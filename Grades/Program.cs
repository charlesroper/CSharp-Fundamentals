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
            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);

            GradeBook book2 = book;
            book2.AddGrade(75);
        }
    }
}
