using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Account {
		protected string nbr { get; set; }
		protected decimal Balance { get; set; }
		public string Description { get; set; }
		//public string Owner { get; set; }

		public void AccountInfo() {
			Console.WriteLine($"Account: \t{this.nbr}");
			Console.WriteLine($"Balance: \t{this.Balance}");
			Console.WriteLine($"Description: \t{this.Description}");
		}
		//Deposit //return decimal of updated balance
		public decimal CalcDeposit(decimal DepositAmount) {
			return Balance += DepositAmount;
		}


		//Withdrawal //return decimal of updated balance
		public decimal CalcWithdrawal(decimal WithdrawalAmount) {
			return Balance -= WithdrawalAmount;
		}

		//GetBalance  //return balance of decimal return type
		public void GetBalance() {
			Console.WriteLine($"Balance: \t{Balance}");
		}

	}
}
