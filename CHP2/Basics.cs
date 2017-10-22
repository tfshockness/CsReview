#define DEBUG //MUST BE THE FIRST THING IN THE CODE 
//Work as a preprocessor. It will define DEBUG "Variable" and can be combined to #if statements and other
//Preprocessor directives
//Oposite of #define is #undef
#define APP
#define PREMIUM
#define REGULAR
using static System.Console; //Using static allowed you to refer static members in a class


//Best format for namespaces is : CompanyName.ProjectName.SystemSection
namespace CsReview.Chp2 //Declare the namespace where the class should be associated
{
    public class Basics //public is the acessor for the class. Basic is the nome of the class.
    {

        public void StringInterpolation(string str1, string str2)
        {
            //To use string Interpolation put $ before the first ",and wrap the variables with {}
            WriteLine($"String 1 has value of {str1} and String 2 has value of {str2}");
            //This code will only run if the DEBUG was defined in the top of the file
            //Statements Directives #if, #elif, #else, #endif
            #if DEBUG
                Write("String Interpolations Running");
            #endif
        }

        public void PreprocessorDirectives()
        {
            #if APP
                #if REGULAR
                    WriteLine("Regular subscription");
                    #elif PREMIUM
                        WriteLine("Premium subscription");
                    #else
                        WriteLine("Subscript now!");
                #endif
            #endif

            //#warning "This is a warning directive"
            //#error "This is an error directive"

        }



    }
}


//NOTES:
//Foreach loop cannot modify value in a colletion. To modify you should use for loop. Pg 55 Book.