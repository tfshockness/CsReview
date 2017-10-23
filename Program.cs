using static System.Console;
using CsReview.Chp4;
using CsReview.Chp4.Shapes;
using CsReview.Chp4.Interfaces;
using CsReview.Chp4.VenusBank;
using CsReview.Chp4.JupiterBank;

namespace CsReview
{
    class Program
    {
        static void Main(string[] args)
        {
           IBankAccount venusAccount = new SaverAccount();
           IBankAccount jupiterAccount = new GoldAccount();
           ITransferBankAccount jupiterAccount2 = new CurrentAccount();

           venusAccount.PayIn(200);
           venusAccount.Withdraw(100);
           WriteLine(venusAccount.ToString());

           jupiterAccount.PayIn(500);
           jupiterAccount.Withdraw(600);
           jupiterAccount.Withdraw(100);
           WriteLine(jupiterAccount.ToString());

            //Put money in jupiter2
            jupiterAccount2.PayIn(400);
           //Transfering money from Jupiter Account to VenusAccount
           jupiterAccount2.TransferTo(venusAccount, 100);

           WriteLine(venusAccount.ToString());
           WriteLine(jupiterAccount2.ToString());
        }
    }
}
