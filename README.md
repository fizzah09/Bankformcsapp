# Bankformcsapp

## Overview
Bankformcsapp is a Windows Forms application built with .NET 8 and C# 12.0. It simulates basic banking operations, allowing users to create accounts, deposit and withdraw money, and manage interest rates for savings accounts.

## Features
- **Create Accounts:** Users can create regular bank accounts or savings accounts with an interest rate.
- **Deposit & Withdraw:** Users can deposit or withdraw money from selected accounts.
- **Interest Rate Management:** Savings accounts can have an interest rate set at creation.
- **Account List:** All accounts are displayed in a DataGridView for easy management.

## Main Components

### Program.cs
- Entry point for the application.
- Initializes configuration and launches the main form (`Form1`).

### Form1.cs
- Main user interface.
- Handles account creation, deposit, withdrawal, and grid refresh.
- Uses controls like `TextBox`, `NumericUpDown`, `DataGridView`, and `Button`.

### BankAccount.cs
- Represents a bank account.
- Properties: `Owner`, `AccuntNumber`, `Balance`.
- Methods: `Deposit`, `Withdraw`.

### SavingAccount.cs
- Inherits from `BankAccount`.
- Adds `InterestRate` property.

## How to Use
1. **Run the application.**
2. **Create an account:** Enter owner name and (optionally) interest rate, then click "Create Account".
3. **Deposit/Withdraw:** Select an account in the grid, enter an amount, and click "Deposit" or "Withdraw".
4. **View balances and account details** in the grid.

## Requirements
- .NET 8 SDK
- Windows OS (for Windows Forms)

## Notes
- The application uses in-memory storage for accounts; data is not persisted after closing.
- The UI is generated using Windows Forms Designer.
