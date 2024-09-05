using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Yatzy.Commands;
using Yatzy.Enums;

namespace Yatzy.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GameViewModel
    {
        public RelayCommand RollDiceCommand { get; set; }
        public ScoreCardViewModel ScoreCardViewModel { get; set; } = new ScoreCardViewModel();
        public YatzyCategory SelectedCategory { get; set; }
        private Random _random = new Random();
        public int CurrentRoll { get; set; }
        public ObservableCollection<int> DiceValues { get; private set; }
        public event EventHandler CanExecuteChanged;

        public GameViewModel()
        {
            // Initiera listan med fem tärningar, alla med standardvärdet 0
            DiceValues = new ObservableCollection<int>(new int[5]);
            RollDiceCommand = new RelayCommand(RollDice, CanRollDice);
            ScoreCardViewModel.CategorySelected += OnCategorySelected;
        }


        // Metod för att kasta alla tärningar
        public void RollDice()
        {
            for (int i = 0; i < DiceValues.Count; i++)
            {
                // Sätter värdet för varje tärning
                DiceValues[i] = _random.Next(1, 7);
            }

            CurrentRoll++;
            RollDiceCommand.RaiseCanExecuteChanged();
        }

        private void OnCategorySelected(object sender, YatzyCategory category)
        {
            ResetDice();
           // PlaceBetCommand.Execute(category);
        }

        private void ResetDice()
        {
            CurrentRoll = 0;
            RollDiceCommand.RaiseCanExecuteChanged();

        }

        private bool CanRollDice()
        {
            return CurrentRoll < 3;
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }


}
