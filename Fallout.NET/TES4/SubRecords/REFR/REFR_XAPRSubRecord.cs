using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XAPRSubRecord : SubRecord
    {
        public uint Reference { get; protected set; }
        public float Delay { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Reference = reader.ReadUInt32();
            Delay = reader.ReadSingle();
        }
    }
}
