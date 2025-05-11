namespace Test_TeamCity_Tests
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
            Assert.That(true, Is.True);
            Assert.Pass();
        }
    }
}