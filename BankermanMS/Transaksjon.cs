using System;

namespace BankermanMS
{
    public class Transaksjon
    {
        public decimal Mengde { get;}
        public DateTime Date { get;}
        public string Notat { get;}
        
        public Transaksjon(decimal amount, DateTime date, string note)
        {
            this.Mengde = amount;
            this.Date = date;
            this.Notat = note;
        }

    }
}