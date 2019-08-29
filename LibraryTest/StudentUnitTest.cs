using System;
using LibraryExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class StudentUnitTest
    {
        private Student student1;

        [TestInitialize]
        public void InitTest()
        {
            student1 = new Student(
                "Johan",
                "Wowlane 1",
                3,
                Gender.Male);
        }

        [TestMethod]
        public void TestName()
        {
            bool result = student1.CheckName(student1.Name);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void TestNameException()
        {
            student1.Name = "I";
            Assert.IsFalse(student1.CheckName(student1.Name));
        }

        [TestMethod]
        public void TestAddress()
        {
            Assert.IsTrue(student1.CheckAddress(student1.Address));
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(NullReferenceException))]
        public void TestAddressException()
        {
            student1.Address = null;
        }

        [TestMethod]
        public void TestSemester()
        {
            Assert.IsTrue(student1.CheckSemester(student1.Semester));
            Assert.IsTrue(student1.CheckSemester(1));
            Assert.IsTrue(student1.CheckSemester(8));


        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterException()
        {
            student1.Semester = 0;
            student1.CheckSemester(student1.Semester);

            student1.Semester = 9;
            student1.CheckSemester(student1.Semester);
        }
    }
}
