using FizzBuzzGame;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzSpeakRuleTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(903)]
        public void ShouldSpeakFizzIfMultipleByThree(int input)
        {
            var word = FizzBuzzSpeakRule.Speak(input);
            Assert.True(word.IsFizz);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(13)]
        [InlineData(35)]
        [InlineData(305)]
        public void ShouldSpeakFizzIfHasThree(int input)
        {
            var word = FizzBuzzSpeakRule.Speak(input);
            Assert.True(word.IsFizz);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(500)]
        [InlineData(155)]
        public void ShouldSpeakBuzzIfMultipleByFive(int input)
        {
            var word = FizzBuzzSpeakRule.Speak(input);
            Assert.True(word.IsBuzz);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(51)]
        [InlineData(152)]
        [InlineData(305)]
        public void ShouldSpeakBuzzIfHasFive(int input)
        {
            var word = FizzBuzzSpeakRule.Speak(input);
            Assert.True(word.IsBuzz);
        }
    }
}