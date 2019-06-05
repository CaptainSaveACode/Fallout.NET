using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords
{
    public class SNAMSubRecord : SubRecord
    {
        public uint Faction { get; protected set; }
        public byte Rank { get; protected set; }
        public byte[] Unused { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Faction = reader.ReadUInt32();
            Rank = reader.ReadByte();
            Unused = reader.ReadBytes(3);
        }
    }
}
