using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        private GradeStatistics _stats;

        public GradeBookTests()
        {
            var book = new GradeBook();

            book.AddGrade(90f);
            book.AddGrade(100f);
            book.AddGrade(50f);

            _stats = book.ComputeStatistics();
        }

        [TestMethod]
        public void CalculatesHighestGrade()
        {
            Assert.AreEqual(100f, _stats.HighestGrade);
        }

        [TestMethod]
        public void CalculatesLowestGrade()
        {
            Assert.AreEqual(100f, _stats.HighestGrade);
        }

        [TestMethod]
        public void CalculatesAverageGrade()
        {
            Assert.AreEqual(100f, _stats.HighestGrade);
        }

        [TestMethod]
        public void TestReferenceTypes()
        {
            // Test based on Jon Skeet's article: http://www.yoda.arachsys.com/csharp/parameters.html

            // We build a string then assign it to the "second" variable;
            // "first" and "second" now refer (point) to the same object.
            StringBuilder first = new StringBuilder();
            first.Append("hello");
            StringBuilder second = first;
            Assert.AreSame(first, second);

            // Now we append another string onto "first"; because first 
            // and second refer to the same object, they both remain equal.
            // In other words, the refer to the same object.
            first.Append(" world");
            Assert.AreSame(first, second);

            // The AreEqual method tests that the objects are the same.
            // We need to convert to a string representation to check
            // that the strings inside the objects are really the equal
            // See: http://stackoverflow.com/questions/11844803/implicit-vs-explicit-stringbuilder-tostring-cethod-call
            Assert.AreEqual(first.ToString(), second.ToString());

            // Assigning first to a new reference doesn't destroy second's link
            // with its original reference.
            first = new StringBuilder();
            first.Append("goodbye");
            Assert.AreEqual(first.ToString(), "goodbye");
            Assert.AreEqual(second.ToString(), "hello world");
        }
    }
}
