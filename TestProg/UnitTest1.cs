namespace TestProg
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(4, Is.EqualTo(4));
        }

        [Test]
        public void Test2()
        {
            Assert.That(4, Is.EqualTo(3));
        }
    }
}