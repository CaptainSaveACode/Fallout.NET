using Fallout.NET.Core;
using System;

namespace Fallout.NET.TES4.SubRecords
{
    public class ZString : SubRecord
    {
        public string Value { get; protected set; }

        public override void Deserialize(BetterReader reader, String name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadNullTerminatedString((int)Size);
        }
    }
}
