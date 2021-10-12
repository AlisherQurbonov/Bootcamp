using System;

namespace Bootcamp.Solutions
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        // [Obsolete("X and Y")]
        public Point() : this(0,0) { }
        
       
        public Point(int x, int y)
        {
            X=x;
            Y=y;
        }

        public override string ToString()
        {
           return string.Format($"{X} {Y}");
        }

        public double DistanceTo(Point b)=>  Math.Sqrt(Math.Pow(X-b.X,2)+Math.Pow(Y-b.Y,2));
        

    }
}