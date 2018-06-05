using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Savings : Account {
		public double IntRate { get; set; } //current interest rate -- double type since more than 2 decimals may be needed

		//Method for calculating interest payment, updating the balance and then rounding the balance to 2 decimal places 
		public void CalcIntRate(double IntRate) {
			double NewBalance = 0;
			NewBalance = (double)Balance + ((double)Balance * (IntRate * .01));
			this.Balance = (decimal)(NewBalance);
			this.Balance = Math.Round(this.Balance, 2, MidpointRounding.AwayFromZero);
		}

		//constructor method to open a new savings account
		public Savings(string nbr, decimal Balance, string Description) {
			this.nbr = nbr;
			this.Balance = Balance;
			this.Description = Description;
		}
	}
}
