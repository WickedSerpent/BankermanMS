using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace BankermanMS
{
    public class Konto
    {
        
        
        public string Nummer { get; }
        public string Eier { get; set; }
        public decimal Balanse
        { get 
            { 
                decimal balance = 0; 
                foreach (var T in AlleTranaksjoner) 
                {
                    balance += T.Mengde;
                }

                return balance;
            }
        } 
        
        public List<Transaksjon> AlleTranaksjoner = new List<Transaksjon>();
        
        private long KontoNummerSeed = 1234567891;
        
        
        public Konto(string name, decimal initialBalance)
        {
            // Random random = new Random();
            this.Eier = name;
            Deposit(initialBalance, DateTime.Now, "Første Innskudd");
            this.Nummer = KontoNummerSeed.ToString();
            // KontoNummerSeed += (KontoNummerSeed + random(1 - 10));
            KontoNummerSeed++;
        }
        
        public void Deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Mengde må være over null");
            }
            var deposit = new Transaksjon(amount, date, note);
            AlleTranaksjoner.Add(deposit);
        }
        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Kan ikke ta ut negativ sum!");
            }
            if (Balanse - amount < 0)
            {
                throw new InvalidOperationException("Du har ikke nokk penger i banken");
            }
            var withdrawal = new Transaksjon(-amount, date, note);
            AlleTranaksjoner.Add(withdrawal);
        } 
    }
}
