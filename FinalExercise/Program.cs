using FinalExercise.Modules;

namespace FinalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var accountList = new List<Account>()
            {
                new Account(random.Next(300,1500)),
                new Account(random.Next(300,1500)),
                new Account(random.Next(300,1500)),
            };

            Console.WriteLine("Процентные ставки для:");
            foreach (var account in accountList)
            {
                account.Calculate(new UsualCalculation());
            }
            foreach (var account in accountList)
            {
                account.Calculate(new SalaryCalculation());
            }


        }
    }
}
