using System.Collections.Generic;
using System.Linq;
using Core.Tools;

namespace Core.UndergroundVault
{
    public class VaultPath
    {
        private readonly IList<char> _keysNeeded;
        
        public int StepCount { get; }
        public VaultKey Target { get; }
        public IList<MatrixAddress> Coords { get; }

        public VaultPath(VaultKey target, IList<MatrixAddress> coords, IList<char> keysNeeded)
        {
            Target = target;
            Coords = coords;
            StepCount = coords.Count;
            _keysNeeded = keysNeeded;
        }

        public bool IsOpen(IList<VaultKey> collectedKeys)
        {
            return _keysNeeded.All(key => collectedKeys.Any(o => o.Id == key));
        }
    }
}