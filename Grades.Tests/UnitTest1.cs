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
        public void CalculatesAveragaGrade()
        {
            Assert.AreEqual(100f, _stats.HighestGrade);
        }
    }
}
