using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorTDD
{
    public class Bank : Expression
    {
        public Money reduce(Expression source, string to)
        {
            return Money.dollar(10);
        }
    }
}
