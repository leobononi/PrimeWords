using System;

namespace DojoExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o conjunto de palavras separado por espaço:");
            var words = Console.ReadLine();

            var primeWords = ProcessWords.Factory(words).ExtractPrimeWords();

            Console.WriteLine("Palavra(s) prima(s): " + primeWords);
            Console.ReadKey();
        }
    }
}
