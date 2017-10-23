using CsReview.Chp4.Interfaces;
using static System.Console;

namespace CsReview.Chp4.VenusBank
{
    public class SaverAccount : IBankAccount
    {
        private decimal _balance; //Nobody outside of this class should touch my money!
        //Overriding the Property to return private instace variable.
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
        public override string ToString() => $"Venus Bank Saver: Balance = {_balance,6:C}";
    }
}