//The main difference btween class and struct is - struct are value types and are alocated in the stack.
//The initializations of struct follows the same as the object.
// CustomerStruct  cs = new CustomerStruct();

//Usually struct are used for small data types. Performance reasons.

//Struct does not support inheritance
namespace CsReview.Chp3
{
    struct CustomerStruct
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        //THE DEFAULT CONSTRUCTOR is always present, even when i have a overload constructor.
        public CustomerStruct(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

//Struct can be initialized:
//CustomerStruct customer;
//FirstName = "Tim"

//Or
//CustomerStruct customer = new CustomerStruct();
//New key word will just call the constructor, it will not put the struct in the heap,
//and all structs values are initialized with default values;
//All the fields should be initialized before use. Same rule of data types.