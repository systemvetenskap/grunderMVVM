using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yatzy.Views
{
    /// <summary>
    /// Interaction logic for DiceControl.xaml
    /// </summary>
    public partial class DiceControl : UserControl
    {


        public int DiceValue
        {
            get { return (int)GetValue(DiceValueProperty); }
            set { SetValue(DiceValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DiceValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DiceValueProperty =
            DependencyProperty.Register("DiceValue", typeof(int), typeof(DiceControl), new PropertyMetadata(0));


        public DiceControl()
        {
            InitializeComponent();
        }
    }
}
