using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts {
	class Program {
		static void Main(string[] args) {

			Savings s1 = new Savings("135423",100, "Fun Fund");
			s1.Description = "Fun Fund";

			s1.AccountInfo();

			s1.CalcDeposit(100);
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance();

			s1.CalcWithdrawal(50);
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance();

			s1.CalcIntRate(10);
			Console.WriteLine("------------------------------------------------");
			s1.GetBalance();

			Console.WriteLine("------------------------------------------------");
			s1.GetBalance();

		}
	}
}
