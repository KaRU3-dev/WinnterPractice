// Practice 01: Bank account control

using System;

using Entity.Banks;
using Entity.Users;

namespace Core {
    public class Program {
        public static void Main(string[] args) {

            // Create bank system
            BankSystem bankSystem = new BankSystem();

            // If system is running request something
            bool isRunning = true;
            while (isRunning) {
                Console.Write("Enter 1 to create account, 2 to deposit, 3 to withdraw, 4 to get balance, 5 to exit: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option) {
                    case 1:
                        /**
                        * 9桁のランダムIDを生成し、アカウントクラスと口座番号をBankSystemのマップに追加します。
                        */
                        bankSystem.CreateAccount();
                        break;
                    case 2:
                        /**
                        * 口座番号を入力し、その口座番号を持つアカウントに預金します。
                        */
                        bankSystem.DepositAction();
                        break;
                    case 3:
                        /**
                        * 口座番号を入力し、その口座番号を持つアカウントから引き出します。
                        */
                        bankSystem.WithdrawAction();
                        break;
                    case 4:
                        /**
                        * 口座番号を入力し、その口座番号を持つアカウントの残高を取得します。
                        */
                        bankSystem.GetBalanceAction();
                        break;
                    case 5:
                        /**
                        * システムを終了します。
                        */
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
