﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorTDD
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
           return new Dollar(amount * multiplier);
        }
        
        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }

        //public override int GetHashCode()
        //{
        //    return amount;
        //}
    }
}
