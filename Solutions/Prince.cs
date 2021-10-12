namespace Bootcamp.Solutions
{
    public class Prince
    {
        public Point Start { get; set; }
        public Point Destination { get; set; }
        public Prince() : this(new Point(), new Point()) { }
        
            
        

        public Prince(Point start, Point destination)
        {
            Start=start;
            Destination=destination;
        }

        public bool HasToCross(Planet planet) => areBothIn(planet) || areBothOut(planet);
      

        private bool areBothIn(Planet planet) => planet.HasPointInside(Start) && planet.HasPointInside(Destination);
        private bool areBothOut(Planet planet) => !planet.HasPointInside(Start) && !planet.HasPointInside(Destination);
        
    }
}