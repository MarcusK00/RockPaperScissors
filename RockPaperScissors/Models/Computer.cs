using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorApp.Models
{
    internal class Computer
    {
		private Random random;
		private int randomNumber;

        private int _selectedWeapon;

		public int SelectedWeapon
		{
			get { return _selectedWeapon; }
			set { _selectedWeapon = value; }
		}

		public Computer()
		{
			random = new Random();
			SelectedWeapon = random.Next(0,3);
		}




	}
}
