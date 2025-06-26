using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCalculatorApp.Models
{
    public class ScoreSystem : INotifyPropertyChanged
    {
        private int _currentScore;

        public int CurrentScore
        {
            get { return _currentScore; }
            set
            {
                if (_currentScore != value)
                {
                    _currentScore = value;
                    OnPropertyChanged("CurrentScore");  // Ensure the property name is correct
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
	