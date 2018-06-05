using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Savings : Account {
		public double IntRate { get; set; } //(double type since more than 2 decimals may be needed)j

		//Method for CalcInterest() //do simple interest
		public void CalcIntRate(double IntRate) {
			double NewBalance = 0;
			NewBalance = (double)Balance + ((double)Balance * (IntRate * .01));
			this.Balance = (decimal)(NewBalance);
		}

		public Savings(string nbr, decimal Balance, string Description) {
			this.nbr = nbr;
			this.Balance = Balance;
			this.Description = Description;
		}

	}
}
