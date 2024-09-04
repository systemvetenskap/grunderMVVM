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
            int diceValue = gameViewModel.CurrentDiceValue;  // Vi antar att CurrentDiceValue �r en property som h�ller t�rningsv�rdet.

            // Assert
            Assert.InRange(diceValue, 1, 6);  // Kontrollerar att v�rdet �r mellan 1 och 6.

            // gammal kod som jag inte v�gar �ndra

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
            // Kontrollera att alla fem t�rningar har ett v�rde mellan 1 och 6
            Assert.Equal(5, gameViewModel.DiceValues.Count); // Kontrollera att det verkligen �r fem t�rningar

            foreach (var diceValue in gameViewModel.DiceValues)
            {
                Assert.InRange(diceValue, 1, 6);  // Kontrollera att varje t�rningsv�rde �r mellan 1 och 6
            }
        }

    }
}