
using CsReview.Chp4.Interfaces;

namespace CsReview.Chp4
{
    //ITransfer derives from IBankAccount, this means that ITransfer has all the methods declared in IBankAccount.
    //All classes that implements ITransfer must implements the methods in ITransfer and IBankAccount.
    public interface ITransferBankAccount : IBankAccount
    {
        //TransferTo accept as argument any class that Implments IBankAccount.
        bool TransferTo(IBankAccount destination, decimal amount);
    }
}