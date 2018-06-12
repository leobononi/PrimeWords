
namespace DojoExercise
{
    public static class WordsExtension
    {
        public static int SumWordChars(this string word)
        {
            int sum = 0;
            var charArray = word.ToCharArray();

            foreach (var character in charArray)
            {
                // A = 65 (27); a = 97 (1)
                if ((int)character >= 97)
                    sum += (int)character - 96;
                else
                    sum += (int)character - 38;
            }

            return sum;
        }
    }
}
