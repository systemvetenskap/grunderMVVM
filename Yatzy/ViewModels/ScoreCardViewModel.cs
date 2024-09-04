using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ScoreCardViewModel
    {
        public int Ones { get; set; } = 3;
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int OnePair { get; set; }
        public int TwoPairs { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Yatzy { get; set; }
        public int Chance { get; set; }

        public int TotalUpperSection { get; private set; }
        public int Bonus { get; private set; }
        public int TotalUpperSectionWithBonus { get; private set; }
        public int TotalLowerSection { get; private set; }
        public int GrandTotal { get; private set; }

    }
}
