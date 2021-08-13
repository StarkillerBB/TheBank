# Bank Repitition Project
##### Author: Benjamin Lank
#### Description:
##### Console project, demonstrating a bank with multiple accounts and with different options available.

#### Navigation menu:
ChangeLog:  
- [Bank 1](#Bank-1).  
- [Bank 2](#Bank-2).  
- [Bank 3](#Bank-3).  
- [Bank 4](#Bank-4).  
- [Bank 5](#Bank-5).


## Console menu.
### Short description of the menu and each method associated with it.

	1. Create account.
		* Allows you to create an account with a self chosen name.
		* Each account is specified to start with 0 money.
	2. Deposit money into account.
		* Transfer a specified amount of money into a specified account, chosen by the account ID inputed.
	3. Withdraw money from account.
		* Transfer a specified amount of money out of a specified account, chosen by the account ID inputed.
		* The account is allowed to go into negative numbers.
	4. Display balance on your account.
		* Display the balance of a specific account, chosen by the account ID inputed.
	5. Charge interest.
		*Add or remove money from all accounts in the bank.
		*The money removed are calculated from a specific mathematical calculation.
			* Checking Account: 
				* salary is calculated by current amount of money, times 1.05 for an increase of 5%
			* Savings Account: 
				* salary is calculated by current amount of money, times 1.01 for an increase of 1% if the deposited amount of money is less than 50 000.
				* salary is calculated by current amount of money, times 1.02 for an increase of 2% if the deposited amount of money is less than 100 000.
				* salary is calculated by current amount of money, times 1.03 for an increase of 3% if the deposited amount of money is more than 100 000.
			* Consumer account:
				* salary is calculated by current amount of money, times 1.001 for an increase of 0.1% if the deposited amoutn of money is a negative number, it will take 20% away from the account this is calculated by deopisted amount of money times 1.20 for a decrease of 20%
  	6. Exit.
		* Closes the application

## ChangeLog.
### All changes will be added to this section.

###### 11/8/21
#### Bank 1.

###### Create the bank and allow the user to create a singel account.

##### Added.

	* Create Bank.
	* Created Bank methods.
		* Deposit.
		* Withdrawl.
		* Balance.
	* Create Account.

##### Changed.

##### Removed.

---
###### 12/8/21
#### Bank 2.

###### Add a menu to the console for navigation.

##### Added.

	* Created method for making menu

##### Changed.

##### Removed.

---
###### 12/8/21
#### Bank 3.

###### Allow the user to create multiple accounts and a new option to see how much money is deposited into the bank.

##### Added.

	* option to create more accoutns.
	* option to see amount of money in the bank.
	* List with all accounts.
	* Account identifiers.

##### Changed.
	
	* Menu to work with more functions.

##### Removed.

---
###### 12/8/21
#### Bank 4.

###### Add an option to add interests to the bank's accounts.

##### Added.
	
	* Rates/interests for account.
	* Account types.

##### Changed.

	* Menu to allow adding rates/interests.

##### Removed.

	* Removed account structor in account class.

---

###### 13/8/21
#### Bank 5.

###### change directory structor so that you collect everything in specific fodlers for easier access. Add Enumerations and interfaces.

#### Added.

	* Enumerations.
	* Interfaces.
	* Folders and files.

#### Changed.

	* File placements.

	



