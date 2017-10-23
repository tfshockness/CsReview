using static System.Console;
using CsReview.Chp4.Interfaces;

namespace CsReview.Chp4.JupiterBank
{
    public class GoldAccount : IBankAccount
    {
        private decimal _balance;
        public decimal Balance => _balance;

        public void PayIn(decimal amount) => _balance += amount;

        public bool Withdraw(decimal amount)
        {
            if(_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            WriteLine("You dont have money man! Sorry!");
            return false;
        }
        //,6:C it will magic put a $ .00 in the amount. Crazy!
        public override string ToString() => $"Jupter Bank Saver: Balance = {_balance,6:C}";
    }
}