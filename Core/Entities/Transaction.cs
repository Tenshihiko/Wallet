using System;
using System.Collections.Generic;

namespace Wallet.Core.Entities
{
    public class Transaction
    {
        public long Id { get; set; }
        public User User { get; set; }
        public Account From { get; set; }
        public Account To { get; set; }
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Beneficiar { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
    }
}
