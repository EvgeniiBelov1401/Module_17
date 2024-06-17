using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Modules
{
    internal class UsualCalculation : ICalculationInterest
    {
        private const double _koef = 0.4;
        private string CalculationName { get; set; }
        public double Interest { private get; set; }
        public UsualCalculation()
        {
            CalculationName = "Процентная ставка обычного аккаунта";
        }
        public void CalculateInterest(double balance)
        {
            Interest = balance * _koef/100;
            if (balance < 1000)
            {
                Interest -= balance * 0.2/100;
            }
            if (balance>=1000)
            {
                Interest -= balance * 0.4/100;
            }
            Console.WriteLine($"{CalculationName} при балансе {balance}$ = {Interest}%");
        }
    }
}
