using System.Collections.Generic;

namespace Core.Computer.Instructions
{
    public class JumpIfTrueInstruction : Instruction
    {
        public override InstructionType Type => InstructionType.JumpIfTrue;

        public JumpIfTrueInstruction(IList<long> memory, int position, int relativeBase, IList<ParameterType> parameterTypes)
            : base(memory, position, relativeBase, parameterTypes)
        {
            ReadParameter(0);
            ReadParameter(1);
        }
    }
}