using System;
using LibraryExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class TeacherUnitTest
    {
        private Teacher teacher1;

        [TestInitialize]
        public void InitTest()
        {
            teacher1 = new Teacher(
                "Johan",
                "Wowlane 1",
                3,
                Gender.Male);
        }

        [TestMethod]
        public void TestName()
        {
            bool result = teacher1.CheckName(teacher1.Name);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void TestNameException()
        {
            teacher1.Name = "I";
            Assert.IsFalse(teacher1.CheckName(teacher1.Name));
        }

        [TestMethod]
        public void TestAddress()
        {
            Assert.IsTrue(teacher1.CheckAddress(teacher1.Address));
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(NullReferenceException))]
        public void TestAddressException()
        {
            teacher1.Address = null;
            teacher1.CheckAddress(teacher1.Address);
        }

        [TestMethod]
        public void TestSalary()
        {
            Assert.IsTrue(teacher1.CheckSalary(teacher1.Salary));
        }

        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterException()
        {
            teacher1.Salary = -1;
            teacher1.CheckSalary(teacher1.Salary);
        }
    }
}
