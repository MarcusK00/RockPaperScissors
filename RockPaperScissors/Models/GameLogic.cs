using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyCalculatorApp.ViewModels;
using MyCalculatorApp;

namespace MyCalculatorApp.Models
{
    public class GameLogic
    {
        private readonly ScoreSystem _scoreSystem;
        private readonly MainViewModel _viewModel;

        public GameLogic(ScoreSystem scoreSystem, MainViewModel viewModel)
        {
            _scoreSystem = scoreSystem;
            _viewModel = viewModel; // Inject the view model to access RestartGame
        }
        public void DetermineWinner(int playerChoice, int computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                ShowMessageAndHandle("Draw");
            }
            if(playerChoice == 0 && computerChoice == 2 || playerChoice == 1 && computerChoice == 0 || playerChoice == 2 && computerChoice == 1)
            {
                _scoreSystem.CurrentScore = _scoreSystem.CurrentScore + 1;
                ShowMessageAndHandle("Player Won!");
            }
            if (playerChoice == 0 && computerChoice == 1 || playerChoice == 2 && computerChoice == 0 || playerChoice == 1 && computerChoice == 2)
            {
                ShowMessageAndHandle("Computer Won!");
            }
        }

        private void ShowMessageAndHandle(string message)
        {
            // Show the message box and wait for the user's response
            MessageBoxResult result = MessageBox.Show(
                message,
                "Result",
                MessageBoxButton.OK
                
                );

            // Execute additional logic if the user clicks "OK"
            if (result == MessageBoxResult.OK)
            {
                _viewModel.RestartGame();
            }
        }


    }
}
