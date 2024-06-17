using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinalExercise.Modules
{
    internal class SalaryCalculation : ICalculationInterest
    {
        private const double _koef = 0.5;
        private string CalculationName { get; set; }
        private double Interest { get; set; }

        public SalaryCalculation()
        {
            CalculationName = "Процентная ставка зарплатного аккаунта";
        }
        public void CalculateInterest(double balance)
        {
            Interest = balance * _koef/100;
            Console.WriteLine($"{CalculationName} при балансе {balance}$ = {Interest}%");
        }
    }
}
