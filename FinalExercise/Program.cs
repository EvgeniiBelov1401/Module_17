using FinalExercise.Modules;

namespace FinalExercise
{
    internal class Program
    {
        static void ShowResult(List<Account> accounts,ICalculationInterest calculationInterest)
        {
            foreach (var account in accounts)
            {
                account.Calculate(calculationInterest);
            }
        }
        static void Main(string[] args)
        {           
            while (true)
            {
                Random random = new Random();
                var accountList = new List<Account>()
                {
                    new Account(random.Next(300,1500)),
                    new Account(random.Next(300,1500)),
                    new Account(random.Next(300,1500)),
                };

                Console.WriteLine("Процентные ставки для:");
                ShowResult(accountList,new UsualCalculation());
                ShowResult(accountList, new SalaryCalculation());
                

                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
