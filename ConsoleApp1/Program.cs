namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = Game.Play(100, FizzBuzzSpeakRule.Speak);
            PrintResult(results);
        }

        static void PrintResult(string[] results)
        {
            foreach (var result in results)
            {
                // Print
            }
        }
    }
}