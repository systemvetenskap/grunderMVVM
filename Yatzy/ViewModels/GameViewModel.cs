using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yatzy.Enums;

namespace Yatzy.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GameViewModel
    {
        public ScoreCardViewModel ScoreCardViewModel { get; set; } = new ScoreCardViewModel();
        public YatzyCategory SelectedCategory { get; set; }
        private Random _random = new Random();

        // En lista för att hålla värden på fem tärningar
        public List<int> DiceValues { get; private set; }

        // Property för den senaste kastade tärningen
        public int CurrentDiceValue { get; private set; }

        public GameViewModel()
        {
            // Initiera listan med fem tärningar, alla med standardvärdet 0
            DiceValues = new List<int>(new int[5]);
            RollDice();
        }


        // Metod för att kasta alla tärningar
        public void RollDice()
        {
            for (int i = 0; i < DiceValues.Count; i++)
            {
                // Sätter värdet för varje tärning
                DiceValues[i] = _random.Next(1, 7);
            }

            // Här sätter vi CurrentDiceValue till värdet på den första tärningen som ett exempel.
            // Du kan ändra detta till den sista tärningen eller något annat beroende på din logik.
            CurrentDiceValue = DiceValues[0];
        }
    }


}
