namespace DojoExercise
{
    public static class NumberExtension
    {
        public static bool IsPrime(this int number)
        {
            var isPrime = number != 1 || (number > 2 && number % 2 != 0);

            if (isPrime)
            {
                for (var y = 2; y < number; y++)
                {
                    if (number != y && number % y == 0)
                        return false;
                }
            }

            return isPrime;
        }
    }
}
