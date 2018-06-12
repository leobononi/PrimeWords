using System;
using System.Collections.Generic;
using System.Linq;

namespace DojoExercise
{
    public class ProcessWords
    {
        private readonly string _words;
        IEnumerable<string> _splitedWords;
        List<Word> _objWords;

        public static ProcessWords Factory(string words)
        {
            return new ProcessWords(words);
        }

        public ProcessWords(string words)
        {
            _words = words;
        }

        public string ExtractPrimeWords()
        {
            var primeWordsList = SplitWords()
                .MakeListObjWords()
                .TakePrimeWordsList();

            return String.Join(" ", primeWordsList);
        }

        private ProcessWords SplitWords()
        {
            _splitedWords =  _words.Split(null).ToList();
            return this;
        }

        private ProcessWords MakeListObjWords()
        {
            _objWords = new List<Word>();

            _splitedWords.ToList().ForEach(w =>
            {
                var isPrime = w.SumWordChars().IsPrime();

                _objWords.Add(Word.Factory(w, isPrime));
            });

            return this;
        }

        private IEnumerable<string> TakePrimeWordsList()
        {
            return _objWords.Where(w => w.IsPrime).Select(w => w.Value);
        }
    }
}
