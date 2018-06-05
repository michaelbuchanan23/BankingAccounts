using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Account { //greg called this "abstract class Account" --this is a way to designate that this exists but only for something else and thus can't be instantiated -- 
					//--thus you can't create "Account a1 = new Account();" in Program.cs
		protected string nbr { get; set; } //account number
		protected string Description { get; set; } //contains a description of the account
		public decimal Balance { get; protected set; } //keeps the current balance in the account
		
		//method to write the account info to the screen
		public void AccountInfo() {
			Console.WriteLine($"Account: \t{this.nbr}");
			Console.WriteLine($"Balance: \t${this.Balance.ToString(".00")}"); //added the ."ToString(".00") portion so that it formats to 2 decimal places even if they are zero
			Console.WriteLine($"Description: \t{this.Description}");
		}
		//calculates the deposit with the passed in Deposit Amount and returns decimal of updated balance
		public void CalcDeposit(decimal DepositAmount) {
			if(DepositAmount <= 0) {
				Console.WriteLine("Amount must be greater than zero");
				return;
			}
			this.Balance += DepositAmount;
		}

		//calculates balance after the withdrawal with passed in WithdrawalAmount for savings
		public void CalcWithdrawal(decimal WithdrawalAmount) {
			if (WithdrawalAmount <= 0) {
				Console.WriteLine("Amount must be greater than zero");
				return;
			}
			if (WithdrawalAmount > this.Balance) { //DON'T UDNERSTAND WHY WE DIDN'T JUST USE AN ELSE-IF HERE
				Console.WriteLine("Withdrawal amount must be less than or equal to account balance");
				return;
			}
			this.Balance -= WithdrawalAmount;
		}

		//calculates and writes to the screen the current balance  
		public void GetBalance() {
			Console.WriteLine($"Balance: \t${this.Balance.ToString(".00")}"); 
			//Console.WriteLine($"Balance: \t${Decimal.Round(this.Balance, 2)}");//greg's program used this way to format
		}

		/*constructor that Greg used which connects to commented out constructor in Savings.cs
		 * public Account(string AccountNbr, string Description) {
		 *	this.AccountNbr = AccountNbr;
		 *	this.Description = Description;
		 *	this.Balance = 0.0M;
		 *	}
		 */

		public decimal ReturnBalance () {
			return this.Balance;
		}
	}
}
