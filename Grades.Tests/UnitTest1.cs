﻿using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        private readonly GradeStatistics _stats;

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
            // In other words, they refer to the same object.
            first.Append(" world");
            Assert.AreSame(first, second);

            // The AreSame assertion tests that the objects are the same.
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

        [TestMethod]
        public void TestValueTypes()
        {
            // We create a new IntHolder struct (a value type) and assign
            // the integer value of 5. Then we create a second IntHolder
            // and assign it with the value of first. This *copies*
            // the value into second - it doesn't create a reference.
            // Therefore, when we change first to 6, the second variable
            // remains with the value of 5 we copied into it.
            IntHolder first = new IntHolder();
            first.i = 5;
            IntHolder second = first;
            first.i = 6;
            Assert.AreEqual(second, new IntHolder { i = 5 });
        }

        private struct IntHolder
        {
            public int i;
        }

        [TestMethod]
        public void PassByValue()
        {
            // We create a new Gradebook called book and set it to "not set". Then we call
            // the SetName() method and pass it the * value * book Because book is a
            // *reference * to an object, a copy of the reference gets passed in to the
            // SetName() method.Thus, altering the object that is the subject of the
            // reference, will change the object for all other variables that reference it.
            GradeBook book = new GradeBook();
            book.Name = "Not set";
            SetName(book);

            Assert.AreEqual("Name set", book.Name);
        }

        void SetName(GradeBook passedBookByValue)
        {
            // passedBookByValue is now a copy of the *reference* to the 
            // instance of the GradeBook object called "book". Changing the 
            // data using the passedBookByValue reference will also change
            // the object for any other reference to that object; e.g., the book instance
            passedBookByValue.Name = "Name set";
        }

        [TestMethod]
        public void PassByReference()
        {
            GradeBook book = new GradeBook();
            book.Name = "Not set";

            Assert.AreEqual("Name set", book.Name);
        }

        void SetNameByRef(GradeBook passedBookByRef)
        {
            
        }
    }
}
