using System;

namespace BankermanMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var konto = new Konto("Andreas", 10000000);
            Console.WriteLine($"Konto:{konto.Nummer} \n " +
                              $"Eier: {konto.Eier} \n " +
                              $"Saldo: {konto.Balanse}");
            
            konto.Withdrawal(500,DateTime.Now, "Snusboks i Oslo");
            Console.WriteLine($"{konto.Balanse}");
            konto.Withdrawal(70,DateTime.Now, "Snusboks i Skien");
            Console.WriteLine($"{konto.Balanse}");
            konto.Withdrawal(34,DateTime.Now, "Snusboks i Sverige");
            Console.WriteLine($"{konto.Balanse}");
            Console.ReadKey();
            konto.Deposit(40000, DateTime.Now, "renter");
            Console.WriteLine($"{konto.Balanse}");
        }

       
    }
}