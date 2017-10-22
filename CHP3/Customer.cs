using System;
namespace CsReview.Chp3
{
    class Customer
    {
        //THIS IS NOT A INSTANCE VARIABLE, THIS IS A PROPERTY!!!!
        //This is a Auto-implemented-Property
        //Propeties are pair of methods (get and set) dressed like a field.
        public string FirstName { get; set; } = "Annomymous"; //Property Initializer. Initialize the property with the value before =
        //Behind the scenes, the Property FristName creates a private instance variable that just the compiles knows about.
        
        //This is a instance variable, declared as private. For that, you need to create the setters and getters.
        private string _lastName;


        //Setters and getters in C# is knows as Properties.
        //To call a set or get in a Properties just call the property or pass a value to the property.
        //This methods declarations is a bit different of other methods. becaue the set and get goes inside of this method
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                //the value variable is a argument injected to the set method. The set always going to have
                //value containing the value passed to the set method
                if(!(value.Trim() == "")){
                    _lastName = value.Trim();
                }
                
            }
        }
        public int Age {get; private set;} //Read-Only

        //Default constructor
        public Customer()
        {

        }
        //Overload constructor, works same for methods. If the signature is different, you can overload.
        public Customer(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        //New C#6 feature, makes methods like Javascrip ES6
        //Arrow functions in Javascript are lambda expressions in C#6
        //Its most used when the method consists just in one statement
        public bool isOld() => Age > 50;

        public void isTest() => System.Console.WriteLine("Testing");

        //Expression-Bodied Properties.
        //Looks like a method, but is a propety with just a get accessor that returns the FullName;
        public string FullName => $"{FirstName} {LastName}";

        //What is the main difference? FullName can be access like: customer.FullName
        //Because this is not a Method. isOld and isTest is called like: customer.isOld() / customer.isTest()
        //Another difference is, methods receive arguments, and properties dont!
        public string displayInfo()
        {
            return $"{FirstName} {LastName} is my fullname! I am {Age} year old";
        }
    }
}


// //NOTES:
//  Customer customer2 = new Customer()//First initialize the Object with Default Values
//             { //Than, Pass values to the properties. If I try to Pass Age, I cannot because age is read-only
//             FirstName = "John", 
//             LastName = "Doe"
//             };