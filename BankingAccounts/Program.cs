using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Program {
		static void Main(string[] args) {

			//I COPIED GREG'S CODE FOR THIS AND IT IS IN "repos/BankingAccounts-GregVersion"

			//BEGIN SAVINGS CODE
			Savings s1 = new Savings("135423", 100M, "Fun Fund"); //adding info for the new account via the Savings constructor
																  //greg's program started balance at 0 and only allowed adding money through deposit function

			s1.AccountInfo(); //calling the account info method which displays the account info on the screen

			Console.WriteLine("------------------------------------------------");

			s1.CalcDeposit(100.25M); //calling the deposit method to deposit money into the savings account
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the deposit

			Console.WriteLine("------------------------------------------------");

			s1.CalcWithdrawal(50.50M); //calling the withdrawal method to withdrawal money from the savings account
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the withdrawal

			Console.WriteLine("------------------------------------------------");

			s1.CalcInterest(10); //calling the calculate interest rate function and passing a value of 10% as the interest rate
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the interest payment

			Console.WriteLine("------------------------------------------------");

			//getting the current balance of the account
			s1.GetBalance();
			//END SAVINGS CODE

			//CHECKING CODE
			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("------------------------------------------------");

			Checking c1 = new Checking("91910", 500M, "Checking Funds");
			c1.GetBalance();
			c1.WriteCheck("Denise", 100);
			c1.GetBalance();

			decimal total = c1.ReturnBalance() + s1.ReturnBalance();
			Console.WriteLine($"All Accounts: \t${total}");

			Console.WriteLine("------------------------------------------------");
			//calculate values of all accounts with an array
			List<Account> accounts = new List<Account> { c1, s1 };
			decimal totalAllAccounts = 0;
			foreach (Account account in accounts) {
				totalAllAccounts += account.ReturnBalance();
			}
			Console.WriteLine($"All Accounts: \t${totalAllAccounts}");
		}
	}
}
