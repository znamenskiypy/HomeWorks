namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcc = new BankAccount();
            Console.WriteLine(myAcc.AccountNumber);
            myAcc.Deposit(5000);
            myAcc.Withdraw(1250);
            Console.WriteLine(myAcc.Balance);
            BankAccount yourAcc = new BankAccount();
            BankAccount.ShowTotalAccounts();

            Console.ReadKey();
        }

        public class BankAccount
        {

            private decimal _balance;
            private static int _totalAccounts = 0;

            public string AccountNumber { get; }

            public decimal Balance { get; private set; }


            public BankAccount()   //Конструктор
            {
                Random rnd = new Random();
                this.AccountNumber = (rnd.Next(0, 999999).ToString());
                this.Balance = 0;

                _totalAccounts += 1;
            }


            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Положили {amount}.Баланс: {Balance}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= Balance)
                    Balance -= amount;

                else
                    throw new ArgumentException("На счете недостаточно средств");

                Console.WriteLine($"Сняли {amount}. Баланс: {Balance}");

            }
            public static void ShowTotalAccounts()
            {
                Console.WriteLine($"Всего создано счетов: {_totalAccounts}");

            }

        }
    }
}
