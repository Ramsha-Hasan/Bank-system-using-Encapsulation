using System;

namespace ConsoleApp3
{
    class BankSystem
    {
        private double balance;
        private double deposit;
        private double withdraw;

        public double TBalance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public double TDeposit
        {
            get
            {
                return deposit;
            }

            set
            {
                deposit = value;
            }
        }

        public double TwithDraw
        {
            get
            {
                return withdraw;
            }

            set
            {
                withdraw = value;
            }
        }

        public double Balance()
        {
            Console.Write("Enter your account balance ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your account balance is {0}",balance);
            return balance;
        }


        public double Deposit()
        {
            Console.Write("Enter your deposited amount ");
            deposit = Convert.ToDouble(Console.ReadLine());
            balance += deposit;
            Console.WriteLine("Your account balance is {0}", balance);
            return balance;
        }


        public double WithDraw()
        {
            Console.Write("Enter your withdrawn amount ");
            withdraw = Convert.ToDouble(Console.ReadLine());
            balance -= withdraw;
            Console.WriteLine("Your account balance is {0}", balance);
            return balance;
        }
    }
   
    
    class Program : BankSystem
    {
        static void Main(string[] args)
        {
            BankSystem bank = new BankSystem();
            bank.Balance();
            bank.Deposit();
            bank.WithDraw();
            
            Console.ReadKey();
        }
    }
}

