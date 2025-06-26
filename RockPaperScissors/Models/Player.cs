using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorApp.Models
{
    public class Player
    {
        private int _selectedWeapon;

		public int SelectedWeapon
		{
			get { return _selectedWeapon; }
			set { _selectedWeapon = value; } // Default = -1, Rock = 0, Paper = 1, Scissors = 2
        }
    }

}
