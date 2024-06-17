using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Modules
{
    internal class Account
    {
        public double Balance { get; set; }        

        public Account(double balance)
        {
            Balance = balance;
        }

        public void Calculate(ICalculationInterest interest)
        {
            interest.CalculateInterest(Balance);
        }
    }
}
