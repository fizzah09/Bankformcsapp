namespace Bankformcsapp
{
	public partial class Form1 : Form
	{
		private List<BankAccount> Accounts; // Move Accounts to a field
		public Form1()
		{
			Accounts = new List<BankAccount>();
			// Global initialization of the form
			InitializeComponent();

			BankAccountgrid.DataSource = Accounts;
		}
		private void CreateaccountButton_Click(object sender, EventArgs e)
		{
		
			if (string.IsNullOrEmpty(OwnerTxt.Text))
			{
				MessageBox.Show("Please enter an owner name.");
				return;
			}
			if (Interest.Value > 0)
			{
				Accounts.Add(new SavingAccount(OwnerTxt.Text, Interest.Value));
				RefreshGrid();
			}
			else
			{
				Accounts.Add(new BankAccount(OwnerTxt.Text));
			}
			RefreshGrid();
			OwnerTxt.Text = string.Empty;
			Interest.Value = 0; // Fixed typo: InteresetRateNum -> InterestRateNum
		}

		private void RefreshGrid()
		{
			BankAccountgrid.DataSource = null;
			BankAccountgrid.DataSource = Accounts; //
		}

		private void Depositbtn_Click(object sender, EventArgs e)
		{
			if (BankAccountgrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
			{
				BankAccount selectedBankaCOND = BankAccountgrid.SelectedRows[0].DataBoundItem as BankAccount;
				if (selectedBankaCOND != null)
				{
					selectedBankaCOND.Deposit(AmountNum.Value);
					RefreshGrid(); // Refresh the grid to show the updated balance
				}
			}
		}

		private void WithdrawBtn_Click(object sender, EventArgs e)
		{
			if (BankAccountgrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
			{
				BankAccount selectedBankaccount = BankAccountgrid.SelectedRows[0].DataBoundItem as BankAccount;
				if (selectedBankaccount != null)
				{
					selectedBankaccount.Withdraw(AmountNum.Value);
					RefreshGrid(); // Refresh the grid to show the updated balance
					AmountNum.Value = 0; // Reset the amount after withdrawal

				}
			}
		}

		private void AmountNum_ValueChanged(object sender, EventArgs e)
		{
			// Enable buttons only if amount > 0
			bool validAmount = AmountNum.Value > 0;
			Depositbtn.Enabled = validAmount;
			WithdrawBtn.Enabled = validAmount;
		}

		private void Interest_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Enter the annual interest rate for a savings account. Must be greater than 0 to create a savings account.");
			Interest.Focus(); // Set focus to the interest rate input
		}
	}
}
