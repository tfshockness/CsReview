using static System.Console;

namespace CsReview.Chp4
{
    //Abstract class cannot be instantiated.
    //sealed - this keyword doest allow any class inherit from this class. sealed class is same as final class in Java;
    //sealed method is same as final method. The method cannot be overriden. 
    public abstract class Shape
    {
        public Position Position { get; } = new Position();
        public Size Size { get; } = new Size();

        public Shape(int witdh, int height, int x, int y)
        {
            Size = new Size() { Width = witdh, Height = height };
            Position = new Position() { X = x, Y = y };
        }

        //Virutal keyword allow the method to be overrid in the child classes.
        public virtual void Draw() => WriteLine($"Shape with {Position} and {Size}");

        //DrawShape method receive Shape object as parameter, this means, that any object that derives from Shape be passed as argument.
        public static void DrawShape(Shape shape) => shape.Draw();

        public virtual void Move(Position newPosition)
        {
            Position.X = newPosition.X;
            Position.Y = newPosition.Y;
            WriteLine($"moves to {Position}");
        }

        //Abstract methods are automatically virtual, and Every class that derives from Shape must implement a override method for Resize.
        //If a class has a abstract method, the class must be declared abstract as such.
        public abstract void Resize(int witdh, int height);
        
    }
}