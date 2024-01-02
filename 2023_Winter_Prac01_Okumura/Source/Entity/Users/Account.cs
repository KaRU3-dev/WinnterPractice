using System;

using Interface.Entity.Accounts;

namespace Entity.Users {
    public class Account : IAccount {
        // Properties
        public string accountNumber { get; set; }
        public double balance { get; set; }

        // Constructor
        public Account(string accountNumber, double balance) {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        // Methods
        public void Deposit(double amount) {
            this.balance += amount;
        }

        public void Withdraw(double amount) {
            this.balance -= amount;
        }

        public double GetBalance() {
            return this.balance;
        }
    }
}
