
namespace CsReview.Chp4
{
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
         //ToString method come from the Object base class, and this method is set as virtual in the object class
         public override string ToString() => $"Width: {Width}, Height: {Height}";
    }
}