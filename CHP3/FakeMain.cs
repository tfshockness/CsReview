using static System.Console;

namespace CsReview.Chp3
{
    public class FakeMain
    {
        public void main()
        {
            Customer customer = new Customer();
            WriteLine(customer.displayInfo());

            customer.FirstName = "Tim";
            customer.LastName = "Shockness     ";

            WriteLine(customer.displayInfo());

            var customer2 = new Customer()//First initialize the Object with Default Values
            { //Than, Pass values to the properties. If I try to Pass Age, I cannot because age is read-only
            FirstName = "John", 
            LastName = "Doe"
            };
 
            WriteLine(customer2.displayInfo());
            customer2.isTest();
            

            Car myCar = new Car("My beautiful Audi");
            WriteLine($"{myCar.Description} has {myCar.NumberWheels} Wheels");
        }
    }
}