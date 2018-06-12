using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoExercise.UnitTests
{
    [TestClass]
    public class WordExtensionTest
    {
        private const string LOWER_CASE_WORD = "abcdefgh";
        private const string UPPER_CASE_WORD = "ABCDEFGH";
        private const string MIXED_CASE_WORD = "AbcB";

        private const int LOWER_CASE_CHAR_SUM = 36;
        private const int UPPER_CASE_CHAR_SUM = 244;
        private const int MIXED_CASE_CHAR_SUM = 60;

        [TestMethod]
        public void Check_Sum_Word_Char()
        {
            Assert.AreEqual(LOWER_CASE_CHAR_SUM, LOWER_CASE_WORD.SumWordChars());
            Assert.AreEqual(UPPER_CASE_CHAR_SUM, UPPER_CASE_WORD.SumWordChars());
            Assert.AreEqual(MIXED_CASE_CHAR_SUM, MIXED_CASE_WORD.SumWordChars());
        }
    }
}
