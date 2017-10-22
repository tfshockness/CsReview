//The main difference btween class and struct is - struct are value types and are alocated in the stack.
//The initializations of struct follows the same as the object.
// CustomerStruct  cs = new CustomerStruct();

//Usually struct are used for small data types. Performance reasons.

namespace CsReview.Chp3
{
    struct CustomerStruct
    {
        public string FirstName;
        public string LastName;

    }
}