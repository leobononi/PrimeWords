using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoExercise.UnitTests
{
    /// <summary>
    /// Summary description for ProcessWordsTest
    /// </summary>
    [TestClass]
    public class ProcessWordsTest
    {
        private const string WORDS = "UFRN contest AcM asd addjrjr sjsjsu rjrjs ab rfkjh fiuduid iusd b osddsidf8er jsdsdu oeror  ooeir oiere rtyok IOJiojijwq8yo iorertoiKiIK";
        private const string PRIME_WORD_1 = "UFRN";
        private const string PRIME_WORD_2 = "ab";
        private const string PRIME_WORD_3 = "b";
        private const string NOT_PRIME_1 = "contest";
        private const string NOT_PRIME_2 = "AcM";

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Process_Words_Returns_Prime_Ones()
        {
            var output = ProcessWords.Factory(WORDS).ExtractPrimeWords();

            Assert.IsTrue(output.Contains(PRIME_WORD_1));
            Assert.IsTrue(output.Contains(PRIME_WORD_2));
            Assert.IsTrue(output.Contains(PRIME_WORD_3));
            Assert.IsFalse(output.Contains(NOT_PRIME_1));
            Assert.IsFalse(output.Contains(NOT_PRIME_2));
        }
    }
}
