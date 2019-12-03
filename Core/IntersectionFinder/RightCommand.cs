namespace Core.IntersectionFinder
{
    public class RightCommand : Command
    {
        public RightCommand(int distance)
            : base(distance)
        {
        }

        protected override Point Move(Point lastPoint)
        {
            return new Point(lastPoint.X + 1, lastPoint.Y);
        }
    }
}