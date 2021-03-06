namespace Core.IntersectionFinder
{
    public class UpCommand : Command
    {
        public UpCommand(int distance)
            : base(distance)
        {
        }

        protected override Point Move(Point lastPoint)
        {
            return new Point(lastPoint.X, lastPoint.Y + 1, lastPoint.Steps + 1);
        }
    }
}