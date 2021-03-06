using Core.Tools;

namespace Core.FractalArt
{
    public class FractalRule
    {
        public string Input { get; }
        public Matrix<char> Output { get; }

        public FractalRule(string input, string output)
        {
            Input = input;
            Output = MatrixBuilder.BuildCharMatrix(output.Replace("/", "\n"));
        }

        public bool IsMatch(string compare)
        {
            return compare == Input;
        }
    }
}