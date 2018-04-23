using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorTDD
{
    public class Dollar : Money
    {
        private string currency;

        public Dollar(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
           return  Money.dollar(amount * multiplier);
        }

        public override string Currency()
        {
            return currency;
        }
    }
}
