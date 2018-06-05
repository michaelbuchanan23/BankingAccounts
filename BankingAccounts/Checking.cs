using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Checking : Account {

		public int NextCheckNbr { get; set; } = 1;

		public void WriteCheck(string Payee, decimal Amount) {
			int CheckNbr = NextCheckNbr++;
			CalcWithdrawal(Amount); //use this way so it goes through the if statements in CalcWithdrawal() that check for errors;
		}

		//creating an intializtion method for the constructor to reuse lines of code
		private void Initialization(string nbr, decimal Balance) {
			this.nbr = nbr;
			this.Balance = Balance;
		}


		//constructor methods to open a new savings account
		public Checking(string nbr, decimal Balance, string Description) {
			Initialization(nbr, Balance);
			this.Description = Description;
		}

		public Checking(string nbr, decimal Balance) {
			Initialization(nbr, Balance);
			this.Description = "My Checking Account"; //default name if nothing else is passed in
		}
	}
}
