using OverloadExplore;

namespace Test
{
    [TestClass]
    public class UnitTest
    {
        OverloadExplore.OverloadExplore? OE {  get; set; }

        [TestInitialize]
        public void Setup()
        {
            OE = new OverloadExplore.OverloadExplore();
        }

        public bool Helper1<T>(T value)
        {
            return OE.Method(value);
        }
        public bool Helper2(string value)
        {
            return OE.Method(value);
        }

        [TestMethod]
        public void TestHelper1()
        {
            Assert.IsTrue(Helper1("string"));
        }

        [TestMethod]
        public void TestHelper2()
        {
            Assert.IsTrue(Helper2("string"));
        }
    }
}