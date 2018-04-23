using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorTDD
{
    public abstract class Money
    {
        public abstract Money Times(int multiplier);
        public abstract string Currency();

        protected string currency;
        protected int amount;

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                && GetType().Equals(money.GetType());
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }

}
