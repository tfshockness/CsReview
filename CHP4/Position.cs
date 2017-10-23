
namespace CsReview.Chp4
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        //ToString method come from the Object base class, and this method is set as virtual in the object class
        public override string ToString() => $"X: {X}, Y: {Y}";
    }
}