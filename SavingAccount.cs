using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankformcsapp
{
	public class SavingAccount : BankAccount
	{
		public decimal InterestRate { get; set; }
		public SavingAccount(string onwer, decimal interestRate) : base(onwer + " (" + interestRate + "%)")
		{
			InterestRate = interestRate;
		}
		public override string Deposit(decimal amount)
		{
			if (amount <= 0)
			{
				return "Deposit amount must be greater than zero.";
			}
			if (amount > 999999)
			{
				return "Deposit amount exceeds the maximum limit of 999,999.";
			}
			decimal interestAmount = amount * (InterestRate / 100);
			Balance += amount + interestAmount;
			return $"Deposited {amount:C} to account {AccuntNumber}. New balance: {Balance:C}";
		}

	}
}
