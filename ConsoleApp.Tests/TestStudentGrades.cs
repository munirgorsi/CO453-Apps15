using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades convert = new StudentGrades();
        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;
            // Act
            Grades actualGrade = convert.ConvertToGrade(0);
            
            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);

        }
        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            // Arrange
            Grades expectedGrade = Grades.F;
            // Act
            Grades actualGrade = convert.ConvertToGrade(39);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);

        }

    }
}
