using Fallout.NET.Core;
using System;

namespace Fallout.NET.TES4.SubRecords
{
    public class FormID : SubRecord
    {
        public int Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadInt32();
        }
    }
}
