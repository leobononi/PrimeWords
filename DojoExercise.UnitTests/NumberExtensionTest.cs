using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoExercise.UnitTests
{
    [TestClass]
    public class NumberExtensionTest
    {
        [TestMethod]
        public void Check_if_Its_a_Prime_Number()
        {
            Assert.IsFalse  (1.IsPrime());
            Assert.IsTrue   (2.IsPrime());
            Assert.IsTrue   (3.IsPrime());
            Assert.IsFalse  (4.IsPrime());
            Assert.IsTrue   (5.IsPrime());
            Assert.IsFalse  (6.IsPrime());
            Assert.IsTrue   (7.IsPrime());
            Assert.IsFalse  (8.IsPrime());
            Assert.IsFalse  (9.IsPrime());
            Assert.IsFalse  (10.IsPrime());
        }
    }
}
