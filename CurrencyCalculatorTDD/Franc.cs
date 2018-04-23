using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorTDD
{
    public class Franc : Money
    {
        private String currency;
        public Franc(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }

        public override string Currency()
        {
            return currency;
        }
    }
}
