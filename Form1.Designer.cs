namespace Bankformcsapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			OwnerLabel = new Label();
			Amount = new Label();
			OwnerTxt = new TextBox();
			AmountNum = new NumericUpDown();
			BankAccountgrid = new DataGridView();
			Depositbtn = new Button();
			WithdrawBtn = new Button();
			CreateaccountButton = new Button();
			InterestRateLabel = new Label();
			Interest = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
			((System.ComponentModel.ISupportInitialize)BankAccountgrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)Interest).BeginInit();
			SuspendLayout();
			// 
			// OwnerLabel
			// 
			OwnerLabel.AutoSize = true;
			OwnerLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			OwnerLabel.Location = new Point(51, 32);
			OwnerLabel.Name = "OwnerLabel";
			OwnerLabel.Size = new Size(79, 30);
			OwnerLabel.TabIndex = 0;
			OwnerLabel.Text = "Owner:";
			// 
			// Amount
			// 
			Amount.AutoSize = true;
			Amount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Amount.Location = new Point(51, 386);
			Amount.Name = "Amount";
			Amount.Size = new Size(88, 30);
			Amount.TabIndex = 1;
			Amount.Text = "Amount";
			// 
			// OwnerTxt
			// 
			OwnerTxt.Location = new Point(136, 41);
			OwnerTxt.Name = "OwnerTxt";
			OwnerTxt.Size = new Size(217, 23);
			OwnerTxt.TabIndex = 2;
			// 
			// AmountNum
			// 
			AmountNum.Location = new Point(136, 393);
			AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
			AmountNum.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
			AmountNum.Name = "AmountNum";
			AmountNum.Size = new Size(217, 23);
			AmountNum.TabIndex = 3;
			AmountNum.Value = new decimal(new int[] { 999999, 0, 0, 0 });
			AmountNum.ValueChanged += AmountNum_ValueChanged;
			// 
			// BankAccountgrid
			// 
			BankAccountgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			BankAccountgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BankAccountgrid.Location = new Point(392, 84);
			BankAccountgrid.Name = "BankAccountgrid";
			BankAccountgrid.Size = new Size(369, 292);
			BankAccountgrid.TabIndex = 4;
			// 
			// Depositbtn
			// 
			Depositbtn.Location = new Point(392, 393);
			Depositbtn.Name = "Depositbtn";
			Depositbtn.Size = new Size(187, 44);
			Depositbtn.TabIndex = 5;
			Depositbtn.Text = "Deposit";
			Depositbtn.UseVisualStyleBackColor = true;
			Depositbtn.Click += Depositbtn_Click;
			// 
			// WithdrawBtn
			// 
			WithdrawBtn.Location = new Point(585, 393);
			WithdrawBtn.Name = "WithdrawBtn";
			WithdrawBtn.Size = new Size(176, 44);
			WithdrawBtn.TabIndex = 6;
			WithdrawBtn.Text = "WithDraw";
			WithdrawBtn.UseVisualStyleBackColor = true;
			WithdrawBtn.Click += WithdrawBtn_Click;
			// 
			// CreateaccountButton
			// 
			CreateaccountButton.Location = new Point(136, 125);
			CreateaccountButton.Name = "CreateaccountButton";
			CreateaccountButton.Size = new Size(174, 43);
			CreateaccountButton.TabIndex = 7;
			CreateaccountButton.Text = "Create Account";
			CreateaccountButton.UseVisualStyleBackColor = true;
			CreateaccountButton.Click += CreateaccountButton_Click;
			// 
			// InterestRateLabel
			// 
			InterestRateLabel.AutoSize = true;
			InterestRateLabel.Location = new Point(60, 86);
			InterestRateLabel.Name = "InterestRateLabel";
			InterestRateLabel.Size = new Size(90, 15);
			InterestRateLabel.TabIndex = 8;
			InterestRateLabel.Text = "Interest Rate(%)";
			InterestRateLabel.Click += Interest_Click;
			// 
			// Interest
			// 
			Interest.Location = new Point(222, 84);
			Interest.Name = "Interest";
			Interest.Size = new Size(120, 23);
			Interest.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(Interest);
			Controls.Add(InterestRateLabel);
			Controls.Add(CreateaccountButton);
			Controls.Add(WithdrawBtn);
			Controls.Add(Depositbtn);
			Controls.Add(BankAccountgrid);
			Controls.Add(AmountNum);
			Controls.Add(OwnerTxt);
			Controls.Add(Amount);
			Controls.Add(OwnerLabel);
			Name = "Form1";
			Text = " ";
			((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
			((System.ComponentModel.ISupportInitialize)BankAccountgrid).EndInit();
			((System.ComponentModel.ISupportInitialize)Interest).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label OwnerLabel;
		private Label Amount;
		private TextBox OwnerTxt;
		private NumericUpDown AmountNum;
		private DataGridView BankAccountgrid;
		private Button Depositbtn;
		private Button WithdrawBtn;
		private Button CreateaccountButton;
		private Label InterestRateLabel;
		private NumericUpDown Interest;
	}
}
