using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Savings : Account {
		public double IntRate { get; set; } //current interest rate -- double type since more than 2 decimals may be needed

		//Method for calculating interest payment, updating the balance and then rounding the balance to 2 decimal places 
		public void CalcInterest(double IntRate) {
			this.Balance= (decimal)((double)Balance + ((double)Balance * (IntRate * .01)));
			this.Balance = Math.Round(this.Balance, 2, MidpointRounding.AwayFromZero);
			//greg used the deposit method from accounts to add money to the account since we don't want to be able to set the balance
		}

		//creating an intializtion method for the constructor to reuse lines of code
		private void Initialization(string nbr, decimal Balance) {
			this.nbr = nbr;
			this.Balance = Balance;
		}

		//constructor method to open a new savings account
		public Savings(string nbr, decimal Balance, string Description) {
			Initialization(nbr, Balance);
			this.Description = Description;
		}

		public Savings(string nbr, decimal Balance) {
			Initialization(nbr, Balance);
			this.Description = "My Savings Account";
		}
		/* constructor with inherited values which is how Greg did this -- calls to the constructor in Account.cs
		public Savings(string nbr, decimal Balance: base(nbr, Description, Balance) {
			Initialization(nbr, Balance);
			this.Description = "My Savings Account";

			}
		*/
	}
}
