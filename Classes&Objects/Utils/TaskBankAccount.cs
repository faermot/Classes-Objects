using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskBankAccount
    {
        int _accountNumber;
        int _balance;

        public int AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        public int Balance { get => _balance; set => _balance = value; }

        public TaskBankAccount(int accountNumber, int balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Аккаунт #{AccountNumber}" +
                $"\nБаланс: {Balance}");
        }

        public void TopUp(int quantity)
        {
            Balance += quantity;
        }

        public void CashOut(int quantity)
        {
            Balance -= quantity;
        }
    }
}
