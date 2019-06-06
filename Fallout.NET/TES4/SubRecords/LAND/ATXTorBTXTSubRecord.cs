using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.LAND
{
    public class ATXTorBTXTSubRecord : SubRecord
    {
        public uint Texture { get; protected set; }
        public ATXTorBTXTQuadrants Quadrant { get; protected set; }
        public byte Unused { get; protected set; }
        public short Layer { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Texture = reader.ReadUInt32();
            Quadrant = (ATXTorBTXTQuadrants)reader.ReadByte();
            Unused = reader.ReadByte();
            Layer = reader.ReadInt16();
        }
    }

    public enum ATXTorBTXTQuadrants
    {
        BottomLeft = 0,
        BottomRight,
        TopLeft,
        TopRight
    }
}
