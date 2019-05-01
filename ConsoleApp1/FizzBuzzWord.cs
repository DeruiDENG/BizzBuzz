using System;

namespace FizzBuzzGame
{
    public class FizzBuzzWord: IWord
    {
        public bool IsFizz { get; private set; }
        public bool IsBuzz { get; private set; }

        public FizzBuzzWord(bool isFizz, bool isBuzz)
        {
            IsFizz = isFizz;
            IsBuzz = isBuzz;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}