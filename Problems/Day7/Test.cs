using NUnit.Framework;

namespace AdventOfCode2022.Problems.Day7
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProblemOne()
        {
            var value = Code.ProblemOne();
            Assert.AreEqual(value, 1723892);
        }

        [Test]
        public void TestProblemTwo()
        {
            var value = Code.ProblemTwo();
            Assert.AreEqual(value, 8474158);
        }
    }
}