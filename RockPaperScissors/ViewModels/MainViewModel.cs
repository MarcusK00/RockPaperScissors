using MyCalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyCalculatorApp.ViewModels
{
    public class MainViewModel
    {
        private MainWindow mw;
        private Player player;
        private GameLogic gameLogic;
        private Computer computer;
        public bool rockClicked { get; set; } = false;
        public bool paperClicked { get; set; } = false;
        public bool scissorClicked { get; set; } = false;
        public bool CheckForSelect { get; set; } = false;
        public ScoreSystem ScoreSystem { get; private set; }



        // Constructor accepts the MainWindow instance
        public MainViewModel(MainWindow window)
        {
           
            player = new Player();
            ScoreSystem = new ScoreSystem();
            gameLogic = new GameLogic(ScoreSystem, this);

            mw = window;

        }

        // Toggle font weight between bold and normal
        public void IsSelected(Label label)
        {

            if (mw != null && label != null)  // Ensure both 'mw' and 'rockTextBlock' are not null
            {
                // Compare the FontFamily Source property
                if (label.FontFamily.Source == "Cascadia Mono")
                {
                    label.FontFamily = new FontFamily("Cascadia Mono Light");
                    label.FontSize = 23;
                    label.Opacity = 0.7;
                }
                else
                {
                    label.FontFamily = new FontFamily("Cascadia Mono");
                    label.FontSize = 30;
                    label.Opacity = 1;
                }
            }
        }

        public void HoverOverOpacity(Label label, double opacity)
        {
            if (label.FontFamily.Source == "Cascadia Mono Light")
            {
                label.Opacity = opacity;
            }
        }

        public void SelectedWeaponPlay(int a)
        {
            if (a == 0)
            {
                player.SelectedWeapon = 0;
            }
            if (a == 1)
            {
                player.SelectedWeapon = 1;
            }
            if (a == 2)
            {
                player.SelectedWeapon = 2;
            }
        }

        public void HideEverything(Label label1, Label label2, Label label3, Label label4)
        {
            label4.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
        }

        public void IsClicked(Label label)
        {
            CheckForSelect = !CheckForSelect;

            if (label == mw.rockTextBlock)
            {
                rockClicked = !rockClicked;
            }

            if (label == mw.paperTextBlock)
            {
                paperClicked = !paperClicked;
            }

            if (label == mw.scissorsTextBlock)
            {
                scissorClicked = !scissorClicked;
            }
        }

        public async void CountDown()
        {
            mw.rockCountDownLabel.Visibility = Visibility.Visible;
            await Task.Delay(400);
            mw.rockCountDownLabel.Visibility = Visibility.Hidden;
            await Task.Delay(50);
            mw.paperCountDownLabel.Visibility = Visibility.Visible;
            await Task.Delay(400);
            mw.paperCountDownLabel.Visibility = Visibility.Hidden;
            await Task.Delay(50);
            mw.scissorsCountDownLabel.Visibility = Visibility.Visible;
            await Task.Delay(400);
            mw.scissorsCountDownLabel.Visibility = Visibility.Hidden;
            await Task.Delay(50);
            mw.shootCountDownLabel.Visibility = Visibility.Visible;
            await Task.Delay(400);
            mw.shootCountDownLabel.Visibility = Visibility.Hidden;
            await Task.Delay(50);
            mw.txtBlockComputer.Visibility = Visibility.Visible;
            mw.txtBlockPlayer.Visibility = Visibility.Visible;
            mw.txtBlockVS.Visibility = Visibility.Visible;

            
        }

        public void ChangeBtnState(Label label)
        {
            // Check if any option is selected
            bool isAnySelected = rockClicked || paperClicked || scissorClicked;

            // Set the button's enabled state based on selection
            label.IsEnabled = isAnySelected;
            label.Opacity = isAnySelected ? 1 : 0.7;
        }

        public void StartGame()
        {
            computer = new Computer();
            ShowTheWeapons();
            int computerWeapon = computer.SelectedWeapon;
            gameLogic.DetermineWinner(player.SelectedWeapon, computer.SelectedWeapon);
            
           
        }

        public void ShowTheWeapons()
        {
            if (player.SelectedWeapon == 0)
            {
                mw.rockPlayerWeapon.Visibility = Visibility.Visible;
            }
            else if (player.SelectedWeapon == 1)
            {
                mw.paperPlayerWeapon.Visibility = Visibility.Visible;
            }
            else if (player.SelectedWeapon == 2)
            {
                mw.scissorsPlayerWeapon.Visibility = Visibility.Visible;
            }
            if (computer.SelectedWeapon == 0)
            {
                mw.rockComputerWeapon.Visibility = Visibility.Visible;
            }
            else if (computer.SelectedWeapon == 1)
            {
                mw.paperComputerWeapon.Visibility = Visibility.Visible;
            }
            else if (computer.SelectedWeapon == 2)
            {
                mw.scissorsComputerWeapon.Visibility = Visibility.Visible;
            }
        }

        public void RestartGame()
        {
            // Reset the player's and computer's weapons
            player.SelectedWeapon = -1;
            computer = new Computer();

            // Reset UI elements
            mw.rockPlayerWeapon.Visibility = Visibility.Hidden;
            mw.paperPlayerWeapon.Visibility = Visibility.Hidden;
            mw.scissorsPlayerWeapon.Visibility = Visibility.Hidden;

            mw.rockComputerWeapon.Visibility = Visibility.Hidden;
            mw.paperComputerWeapon.Visibility = Visibility.Hidden;
            mw.scissorsComputerWeapon.Visibility = Visibility.Hidden;

            mw.txtBlockComputer.Visibility = Visibility.Hidden;
            mw.txtBlockPlayer.Visibility = Visibility.Hidden;
            mw.txtBlockVS.Visibility = Visibility.Hidden;

            // Reset the button and labels
            mw.rockTextBlock.Visibility = Visibility.Visible;
            mw.rockTextBlock.FontFamily = new FontFamily("Cascadia Mono Light");
            mw.rockTextBlock.FontSize = 23;
            mw.rockTextBlock.Opacity = 0.7;

            mw.paperTextBlock.Visibility = Visibility.Visible;
            mw.paperTextBlock.FontFamily = new FontFamily("Cascadia Mono Light");
            mw.paperTextBlock.FontSize = 23;
            mw.paperTextBlock.Opacity = 0.7;

            mw.scissorsTextBlock.Visibility = Visibility.Visible;
            mw.scissorsTextBlock.FontFamily = new FontFamily("Cascadia Mono Light");
            mw.scissorsTextBlock.FontSize = 23;
            mw.scissorsTextBlock.Opacity = 0.7;

            mw.startBtn.Visibility = Visibility.Visible;
            mw.startBtn.IsEnabled = false;
            mw.startBtn.Opacity = 0.7;

            rockClicked = false;
            paperClicked = false;
            scissorClicked = false;
            CheckForSelect = false;
        }
    }
}
