using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodichka
{
    class Program
    {
        public enum AccountType { Current, Saving, IncorrectInput };
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();
            acc1.CreateAcc();
            acc1.SetAccInfo();
            Console.WriteLine("Введите сумму для внесения на баланс счета");
            decimal x;
            while (!decimal.TryParse(Console.ReadLine(),out x))
            {
                Console.WriteLine("Некорректный ввод");
            }
            acc1.AddMoney(x);
            acc1.GetInfo();
            BankAccount acc2 = new BankAccount();
            acc2.CreateAcc();
            acc2.SetAccInfo();
            Console.WriteLine("Введите сумму для внесения на баланс счета");
            while (!decimal.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректный ввод");
            }
            acc2.AddMoney(x);
            acc2.GetInfo();
            Console.ReadKey();
        }
    }
}
