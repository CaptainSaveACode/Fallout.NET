using Fallout.NET.Core;
using System;

namespace Fallout.NET.TES4.SubRecords
{
    public class MODL : SubRecord
    {
        public string Model { get; protected set; }

        public override void Deserialize(BetterReader reader, String name)
        {
            base.Deserialize(reader, name);
            Model = reader.ReadNullTerminatedString((int)Size);
        }
    }
}
