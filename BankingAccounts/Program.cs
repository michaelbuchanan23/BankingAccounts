using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Program {
		static void Main(string[] args) {
			
			Savings s1 = new Savings("135423",100M, "Fun Fund"); //adding info for the new account via the Savings constructor

			s1.AccountInfo(); //calling the account info method which displays the account info on the screen

			s1.CalcDeposit(100.25M); //calling the deposit method to deposit money into the savings account
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the deposit

			s1.CalcWithdrawal(50.50M); //calling the withdrawal method to withdrawal money from the savings account
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the withdrawal

			s1.CalcIntRate(10); //calling the calculate interest rate function and passing a value of 10% as the interest rate
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance(); //calling the GetBalance method to obtain the balance after the interest payment

			//getting the current balance of the account
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance();

		}
	}
}
