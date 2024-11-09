using NUnit.Framework;

namespace StudentGrades.nUnitTests

{
    public class GradeCalculatorTests
    {
        private GradeCalculator GradeCalculator { get; set; }

        [SetUp]
        public void Setup()
        {
            GradeCalculator = new GradeCalculator();
        }


        [TestCase(56)]
        [TestCase(12)]
        [TestCase(87)]
        [TestCase(43)]
        [TestCase(15)]
        [TestCase(78)]
        [TestCase(21)]
        [TestCase(99)]
        [TestCase(34)]
        [TestCase(65)]
        [TestCase(4)]
        [TestCase(53)]
        [TestCase(11)]
        [TestCase(80)]
        [TestCase(28)]
        [TestCase(71)]
        [TestCase(7)]
        [TestCase(91)]
        [TestCase(62)]
        [TestCase(38)]
        [TestCase(53)]
        [TestCase(17)]
        [TestCase(88)]
        [TestCase(92)]
        [TestCase(46)]
        [TestCase(10)]
        [TestCase(29)]
        [TestCase(41)]
        [TestCase(68)]
        [TestCase(77)]
        [TestCase(60)]
        [TestCase(16)]
        [TestCase(73)]
        [TestCase(55)]
        [TestCase(84)]
        [TestCase(13)]
        [TestCase(39)]
        [TestCase(90)]
        [TestCase(23)]
        [TestCase(63)]
        [TestCase(49)]
        [TestCase(86)]
        [TestCase(73)]
        [TestCase(53)]
        [TestCase(83)]
        [TestCase(80)]
        [TestCase(55)]
        [TestCase(38)]
        [TestCase(94)]
        [TestCase(98)]
        [TestCase(36)]
        [TestCase(21)]
        [TestCase(24)]
        [TestCase(95)]
        [TestCase(12)]
        [TestCase(28)]
        [TestCase(14)]
        [TestCase(42)]
        [TestCase(33)]
        [TestCase(48)]
        public void GetGradePercentage_EqualTest(int percentage)
        {
            // Assign
            //var percentage = 99;

            // Act
            string grade = GradeCalculator.GetGradePercentage(percentage);
            // Assert
            if (percentage >= 90)
                Assert.That(grade, Is.EqualTo("A"));
            else if (percentage >= 80)
                Assert.That(grade, Is.EqualTo("B"));
            else if (percentage >= 70)
                Assert.That(grade, Is.EqualTo("C"));
            else if (percentage >= 60)
                Assert.That(grade, Is.EqualTo("D"));
            else
                Assert.That(grade, Is.EqualTo("F"));
        }


 
    }
}