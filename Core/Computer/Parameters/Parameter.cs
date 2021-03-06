namespace Core.Computer.Parameters
{
    public abstract class Parameter
    {
        public int Position { get; }
        public ParameterType Type { get; }

        protected Parameter(ParameterType type, int pos)
        {
            Position = pos;
            Type = type;
        }
    }
}