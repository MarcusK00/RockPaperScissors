using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyCalculatorApp.ViewModels;

namespace MyCalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        MainViewModel mvm;
      
        public MainWindow()
        {
            InitializeComponent();
            mvm = new MainViewModel(this);
            DataContext = mvm;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            mvm.HideEverything(rockTextBlock, paperTextBlock, scissorsTextBlock, startBtn);
            mvm.CountDown();
            await Task.Delay(3000);
            mvm.StartGame();
           
           
        }

        private void rockTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mvm.IsClicked(rockTextBlock);
            mvm.ChangeBtnState(startBtn);
           
            mvm.IsSelected(rockTextBlock);
            mvm.SelectedWeaponPlay(0);
        }


        private void paperTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mvm.IsClicked(paperTextBlock);
            mvm.ChangeBtnState(startBtn);
            
            mvm.IsSelected(paperTextBlock);
            mvm.SelectedWeaponPlay(1);
        }

        private void scissorsTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mvm.IsClicked(scissorsTextBlock);
            mvm.ChangeBtnState(startBtn);
           
            mvm.IsSelected(scissorsTextBlock);
            mvm.SelectedWeaponPlay(2);
        }

        private void rockTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(rockTextBlock, 1);

        }

        private void rockTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(rockTextBlock, 0.7);
        }

        private void paperTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(paperTextBlock, 1);
        }

        private void paperTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(paperTextBlock, 0.7);
        }

        private void scissorsTextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(scissorsTextBlock, 1);
        }

        private void scissorsTextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            mvm.HoverOverOpacity(scissorsTextBlock, 0.7);
        }
    }
}