using Yatzy.ViewModels;

namespace YatzyTests
{
    public class GameViewModelTests
    {
        [Fact]
        public void RollDice_ShouldSetDiceValueBetween1And6()
        {
            // Arrange
            var gameViewModel = new GameViewModel();

            // Act
            gameViewModel.RollDice();
            int diceValue = gameViewModel.CurrentDiceValue;  // Vi antar att CurrentDiceValue är en property som håller tärningsvärdet.

            // Assert
            Assert.InRange(diceValue, 1, 6);  // Kontrollerar att värdet är mellan 1 och 6.

            // gammal kod som jag inte vågar ändra

            // miin nya kod
        }

        [Fact]
        public void RollDice_ShouldSetAllFiveDiceValuesBetween1And6()
        {
            // Arrange
            var gameViewModel = new GameViewModel();

            // Act
            gameViewModel.RollDice();

            // Assert
            // Kontrollera att alla fem tärningar har ett värde mellan 1 och 6
            Assert.Equal(5, gameViewModel.DiceValues.Count); // Kontrollera att det verkligen är fem tärningar

            foreach (var diceValue in gameViewModel.DiceValues)
            {
                Assert.InRange(diceValue, 1, 6);  // Kontrollera att varje tärningsvärde är mellan 1 och 6
            }
        }

    }
}