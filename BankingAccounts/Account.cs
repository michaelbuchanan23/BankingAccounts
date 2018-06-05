using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Account {
		protected string nbr { get; set; } //account number
		protected decimal Balance { get; set; } //keeps the current balance in the account
		protected string Description { get; set; } //contains a description of the account

		//method to write the account info to the screen
		public void AccountInfo() {
			Console.WriteLine($"Account: \t{this.nbr}");
			Console.WriteLine($"Balance: \t${this.Balance.ToString(".00")}"); //added the ."ToString(".00") portion so that it formats to 2 decimal places even if they are zero
			Console.WriteLine($"Description: \t{this.Description}");
		}
		//calculates the deposit with the passed in Deposit Amount and returns decimal of updated balance
		public void CalcDeposit(decimal DepositAmount) {
			this.Balance += DepositAmount;
		}


		//calculates balance after the withdrawal with passed in WithdrawalAmount
		public void CalcWithdrawal(decimal WithdrawalAmount) {
			this.Balance -= WithdrawalAmount;
		}

		//calculates and writes to the screen the current balance  
		public void GetBalance() {
			Console.WriteLine($"Balance: \t${this.Balance.ToString(".00")}");
		}

	}
}
