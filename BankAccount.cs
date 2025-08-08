using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankformcsapp
{
	public class BankAccount
	{
		public string Owner { get; set; }
		public Guid AccuntNumber { get; set; }
		// Changed Balance to protected set to allow derived classes to modify it
		public decimal Balance { get; protected set; }

		public BankAccount(string onwer) { 
			Owner = onwer;
			AccuntNumber = Guid.NewGuid();
			Balance = 0;
		}
		public virtual string Deposit(decimal amount)
		{
			if (amount <= 0)
			{
				return "Deposit amount must be greater than zero.";
			}
			if (amount > 999999)
			{
				return "Deposit amount exceeds the maximum limit of 999,999.";
			}
			Balance += amount;
			return $"Deposited {amount:C} to account {AccuntNumber}. New balance: {Balance:C}";
		}
		// this deosnt need to oveeride the base class method because withdrawl is not specific to saving accounts
		public string Withdraw(decimal amount)
		{
			if (amount <= 0)
			{
				return "Withdrawal amount must be greater than zero.";
			}
			if (amount > Balance)
			{
				return "Insufficient funds for withdrawal.";
			}
			if (amount > 999999)
			{
				return "Withdrawal amount exceeds the maximum limit of 999,999.";
			}
			Balance -= amount;
			return $"Withdrew {amount:C} from account {AccuntNumber}. New balance: {Balance:C}";
		}
	}
}
