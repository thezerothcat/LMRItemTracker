using LiveSplit.ComponentUtil;
using System;

namespace EyeOfTruth
{
    using OffsetT = Int32;

    public class GameVar<T> : MemoryWatcher<T> where T : struct
    {
        public GameVar(string id, OffsetT base_, params OffsetT[] offsets) : base(new DeepPointer(base_, offsets))
        {
            this.Name = id;
            this.UpdateInterval = TimeSpan.FromMilliseconds(5);
        }

        public override string ToString()
        {
            // TODO: display names, preferably locale specific
            return Name;
        }
    }
}
