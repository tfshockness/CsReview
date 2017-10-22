

namespace CsReview.Chp3
{
    class Car
    {
        public string Description { get; set; }
        public int NumberWheels { get; set; }

        //
        public Car(string description, int wheels)
        {
            Description = description;
            NumberWheels = wheels;
        }

        //Constructor Initializer
        //Its a overload constructor with one argument.
        //But, when this constructor is called, the constructor other constructor is called with the values
        //in this()
        //Because the constructor Initialize runs before the body, there is no need for body in this constructor
        //Its not possible put more than one constructor initialization
        public Car(string description) : this(description, 4){}
    }
}