﻿using System;

namespace classes
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction (decimal amount, DateTime Date, string notes )
        {
            this.Amount = amount;
            this.Date = Date;
            this.Notes = notes;
        }
    }
}