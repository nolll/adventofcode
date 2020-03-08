namespace Core.OperationComputer
{
    public class GtrrOperation : Operation
    {
        public override string Name => "gtrr";

        public override int[] Execute(int[] registers, int a, int b, int c)
        {
            registers[c] = registers[a] > registers[b] ? 1 : 0;
            return registers;
        }
    }
}