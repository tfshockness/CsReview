using static System.Console;
namespace CsReview.Chp4.Shapes
{
    public class Rectangle : Shape
    {
        //Default Constructor, Because there is no default constructor in Shape class, I need to call the base constructor and pass the values
        public Rectangle()
            :base(0,0,0,0)
        {
            
        }

        //in C# the constructor initializer must be outside of the constructor body because the parent constructor is called before the method gets in the body.
        public Rectangle(int witdh, int height, int x, int y)
            :base(witdh, height, x, y) 
        {
            //Everything is happening in the Parent constructor
        }
        //To override a method from the parent, you need to use the keywork override in the method. The signature for the method must match with the parent.
        //The return type must match as well.
        public override void Draw() => WriteLine($"Rectangle with {Position} and {Size}");

        //Overriding a method in the Parent, calling the method inside of the method and passing the argument down.
        public override void Move(Position newPosition)
        {
            Write("Rectangle ");
            //The base. calls the base class. With that, you can access methods/Properties which belongs to the parent.
            base.Move(newPosition);
        }

        //Class must be implemented because is set as abstract in the parent class.
        public override void Resize(int witdh, int height)
        {
            throw new System.NotImplementedException();
        }
    }
}