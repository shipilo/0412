﻿using System;

namespace Les_0412
{
    class BankTransaction
    {
        private DateTime date;
        private TimeSpan time;
        private int sum;

        public DateTime Date { get => date; }
        public TimeSpan Time { get => time; }
        public int Sum { get => sum; }

        public BankTransaction(int sum)
        {
            date = DateTime.Now.Date;
            time = DateTime.Now.TimeOfDay;
            this.sum = sum;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} {Time} {Sum}";
        }
    }
}
