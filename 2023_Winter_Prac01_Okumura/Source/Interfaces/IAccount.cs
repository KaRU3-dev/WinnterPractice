using System;

namespace Interface.Entity.Accounts {
    public interface IAccount {

        // properties
        string accountNumber { get; set; }
        double balance { get; set; }

        // methods
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();
    }
}