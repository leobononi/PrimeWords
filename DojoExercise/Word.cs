
namespace DojoExercise
{
    public class Word
    {
        public string Value { get; set; }
        public bool IsPrime { get; set; }

        public static Word Factory(string value, bool isPrime)
        {
            return new Word(value, isPrime);
        }

        public Word(string value, bool isPrime)
        {
            Value = value;
            IsPrime = isPrime;  
        }
    }
}
