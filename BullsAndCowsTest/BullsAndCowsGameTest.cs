using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class BullsAndCowsGameTest
    {
        [Fact]
        public void Should_return_4A0B_when_guess_given_guess_number_and_secret_are_same()
        {
            //given
            string guessNumber = "1234";
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("4A0B", result);
        }

        [Theory]
        [InlineData("1256")]
        [InlineData("5634")]
        [InlineData("5239")]
        public void Should_return_2A0B_when_guess_given_position_and_digit_are_partially_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("2A0B", result);
        }

        [Theory]
        [InlineData("1356")]
        public void Should_return_1A1B_when_guess_given_position_and_digit_partially_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("1A1B", result);
        }

        [Theory]
        [InlineData("8956")]
        public void Should_return_0A0B_when_guess_given_all_position_and_digit_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A0B", result);
        }

        [Theory]
        [InlineData("4321")]
        public void Should_return_0A4B_when_guess_given_all_position_incorrect_all_digit_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A4B", result);
        }

        [Theory]
        [InlineData("1243")]
        public void Should_return_2A2B_when_guess_given_all_position_incorrect_all_digit_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("2A2B", result);
        }

        [Theory]
        [InlineData("5612")]
        public void Should_return_0A2B_when_guess_given_all_position_incorrect_all_digit_correct(string guessNumber)
        {
            //given
            string secret = "1234";

            Mock<SecretGenerator> mockSecretGenerator = new Mock<SecretGenerator>();
            mockSecretGenerator.Setup(generator => generator.GenerateSecret()).Returns(secret);

            var game = new BullsAndCowsGame(mockSecretGenerator.Object);
            //when
            string result = game.Guess(guessNumber);
            //then
            Assert.Equal("0A2B", result);
        }
    }
}
