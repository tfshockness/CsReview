//C# is case sensitive
using System;
//C# uses Camel case and Pascal case in diffrent cases.
//Camel case - variableName;
//Pascal case - VariableName;

namespace CsReview.Chp2
{
    public class Naming
    {
        //In other languages constant are usually all capital.However in C# is used in Pascal Case
        public const int NumberOfMonths = 12;
        //Public Variables must follow the Camel case patter
        public string CityName;
        //Private variable follows the Pascal case patter, and usually has a _ before the variable name
        private bool _isSingle;

        //All parameters passed to a functions should follow the Pascal case
        public string FullName(string firstName, string lastName)
        {
            return $"my name is {firstName} {lastName}";
        }
    }
}