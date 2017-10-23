
namespace CsReview.Chp4.Interfaces
{
    //C# uses the keyword interface to declare a interface. Its a best practice give a I in the name of each interface.
    //Interfaces works similar to abstract classes. It cannot be instatiated, just contain abstract methods, and if some class derives from the interface
    //that class must implement every method in the interfac (with same return type and signature).
    public interface IBankAccount
    {
        //Because the methods are always virtual, the keywork virutal is not needed.
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }
}