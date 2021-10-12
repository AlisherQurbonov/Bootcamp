namespace Bootcamp.Solutions
{
    public class Planet
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Planet() : this(new Point(),0) { }
        public Planet(Point center,int radius)
        {
            Center=center;
            Radius=radius;
        }

        public bool HasPointInside(Point x) =>  Radius > Center.DistanceTo(x);
        
        
    }
}