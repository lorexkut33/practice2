//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace задания_разработка_п_м.lessons
//{
//    internal class ExceptionClass
//    {
//        static void Main(string[] args) 
//        {
//            Console.WriteLine("Enter initial balance:");
//            decimal initBalance;
//            while (!decimal.TryParse(Console.ReadLine(), out initBalance))
//            {
//                Console.WriteLine("Invalid input!");  
//            }
//            BankAccount account1 = null;
//            try
//            {
//                account1 = new BankAccount(initBalance);
//                Console.WriteLine($"Initial balance: {account1.GetBalance()}");
//                account1.Withdraw(0);
//                Console.WriteLine($"Balance after withdrawal: {account1.GetBalance()}");
//            }
//            catch (ArgumentOutOfRangeException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            catch (InvalidOperationException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Unexpected error: {ex.Message}");
//            }
//            finally
//            {
//                Console.WriteLine($"Actually balance: {account1?.GetBalance() ?? 0}");
//            }
//        }
        
//    }
//    /*
    
//    Метод Deposit также должен выбрасывать ArgumentOutOfRangeException если сумма ≤ 0.
    
//    Пользовательский ввод баланса преобразовывать через decimal.TryParse. 

//    В коде метода Main используйте try-catch-finally. 
//    Сделайте отдельные catch под каждый вид исключения и общий catch (Exception) последним.
//    Также сделайте finally, который всегда выводит актуальный баланс.*/
//    public class BankAccount
//    {
//        private decimal Balance { get; set; }
//        public decimal GetBalance()
//        {
//            return Balance;
//        }

//        public BankAccount(decimal initialBalance)
//        {
//            Balance = initialBalance;
//        }
//        public void Withdraw(decimal amount)
//        {
//            if (amount <= 0)
//            {
//                throw new ArgumentOutOfRangeException("Amount must be a positive value");
//            }
//            else if (amount > Balance)
//            {
//                throw new InvalidOperationException("insufficient funds");
//            }
//            else
//            {
//                Balance -= amount;
//            }
//        }
//        public void Deposit(decimal amount)
//        {
//            if ( amount <= 0)
//            {
//                throw new ArgumentOutOfRangeException("Amount must be a positive value");
//            }
//            else
//            {
//                Balance += amount;
//            }
//        }
        
//    }
//}
