using System.Collections.Generic;
using System.Linq;

namespace Core.SafeCracking
{
    public class AssembunnyInstruction
    {
        public string Name { get; set; }
        public IList<string> Args { get; }

        public AssembunnyInstruction(string s)
        {
            var parts = s.Split(' ');
            Name = parts.First();
            Args = parts.Skip(1).ToList();
        }
    }
}