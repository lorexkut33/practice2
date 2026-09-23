//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м
//{
//    internal class lesson_class
//    {
//        class BankAccount
//        {
//            public static int TotalAccounts;
//            public string Owner;
//            private decimal _balance;
//            public decimal Balance 
//            { 
//               get { return _balance; }
//                set
//                {
//                    if (value < 0)
//                        Console.WriteLine("Balance cannot be negative.");
//                    else
//                        _balance = value;
//                }
//            }
//            public BankAccount(string owner, decimal initialBalance)
//            {
//                Owner = owner;
//                Balance = initialBalance;
//                TotalAccounts++;
//            }
//            public void Deposit(decimal amount)
//            {
//                if (amount > 0)
//                {
//                    Balance += amount;
//                    Console.WriteLine($"Balance updated: {Balance}");
//                }
//                else
//                    Console.WriteLine("Failed! deposit have been rejected.");
//            }
//            public void Withdraw(decimal amount)
//            {
//                if (amount > 0 && amount <= Balance)
//                {
//                    Balance -= amount;
//                    Console.WriteLine($"Balance updated: {Balance}");
//                }
//                else
//                    Console.WriteLine("Fail! Withdrawal has been rejected");
//            }
//            public string PrintInfo()
//            {
//                return $"Owner: {Owner}, Balance: {Balance}";
//            }
//            public string Print_balance()
//            {
//                return $"Balance: {Balance}";
//            }

//        }
//        static void Main(string[] args)
//        {
//            Dictionary<string, decimal> name = new Dictionary<string, decimal> { { "John", 1000 }, { "Steve", 500 }, { "Alice", 2000 }, { "Bob", 1500 } };

//            Console.WriteLine("Информация о пользователях:");
//            //Цикл для создания объектов BankAccount и вывода информации о каждом пользователе
//            foreach (var n in name)
//            {
//                BankAccount account = new BankAccount(n.Key, n.Value);
//                Console.WriteLine($"{account.PrintInfo()}");
//                account.Deposit(200);
//                Console.WriteLine($"Баланс обновлен: {account.Print_balance()}");
//                account.Withdraw(100);
//                Console.WriteLine($"Баланс обновлен: {account.Print_balance()}");
//                Console.WriteLine("\n");

//            }

//        }

//    }
//}
