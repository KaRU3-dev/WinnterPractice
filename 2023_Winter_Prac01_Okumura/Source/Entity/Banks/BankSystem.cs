using System;

using Entity.Users;
using Interface.Entity.Banks;

namespace Entity.Banks {
    public class BankSystem : IBank {
        // Account map ( accountNumber, Account )
        public Dictionary<string, Account> accounts { get; set; }

        // Constructor
        public BankSystem() {
            this.accounts = new Dictionary<string, Account>();
        }

        // Methods
        public void CreateAccount() {
            Console.WriteLine("Creating account...");

            string accountNumber = this.GenerateAccountNumber();
            double balance = 0;

            Account account = new Account(accountNumber, balance);
            this.accounts.Add(accountNumber, account);

            Console.WriteLine("Account created!");
            Console.WriteLine("Account number: " + accountNumber);
        }

        public void DepositAction() {

            Account account;

            Console.Write("Enter account number: ");
            string ?accountNumber = Console.ReadLine();
            try {
                // Find account
                account = this.accounts[accountNumber];
            } catch (KeyNotFoundException) {
                Console.WriteLine("Account not found!");
                return;
            }

            double amount;
            Console.Write($"Enter amount to deposit: ");
            do {
                amount = Convert.ToDouble(Console.ReadLine());
                if (amount < 1 || amount >= 50000000) {
                    Console.WriteLine("Invalid amount!");
                    Console.Write($"Enter amount to deposit: ");
                } else {
                    break;
                }
            } while (true);

            account.Deposit(amount);
            Console.WriteLine($"Deposited {amount} to account {accountNumber}!");
        }

        public void WithdrawAction() {

            Account account;

            Console.Write("Enter account number: ");
            string ?accountNumber = Console.ReadLine();
            try {
                // Find account
                account = this.accounts[accountNumber];
            } catch (KeyNotFoundException) {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write($"Enter amount to withdraw (1 to {account.balance}): ");
            do {
                double amount = Convert.ToDouble(Console.ReadLine());
                if (amount < 1 || amount > account.balance) {
                    Console.WriteLine("Invalid amount!");
                    Console.WriteLine($"Enter amount to withdraw (1 to {account.balance}): ");
                } else {
                    account.Withdraw(amount);
                    Console.WriteLine($"Withdrew {amount} from account {accountNumber}!");
                    break;
                }
            } while (true);
        }

        public void GetBalanceAction() {
            Console.Write("Enter account number: ");
            string ?accountNumber = Console.ReadLine();
            try {
                // Find account
                Account account = this.accounts[accountNumber];
                Console.WriteLine($"Account {accountNumber} balance: {account.balance}");
            } catch (KeyNotFoundException) {
                Console.WriteLine("Account not found!");
            }
        }

        private string GenerateAccountNumber() {
            Random rnd = new Random();
            string accountNumber = rnd.Next(100000000, 999999999).ToString();
            while (this.accounts.ContainsKey(accountNumber)) {
                accountNumber = rnd.Next(100000000, 999999999).ToString();
            }

            return accountNumber;
        }
    }
}
