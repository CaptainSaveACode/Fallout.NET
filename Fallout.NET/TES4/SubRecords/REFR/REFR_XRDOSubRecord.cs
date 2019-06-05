using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XRDOSubRecord : SubRecord
    {
        public float RangeRadius { get; protected set; }
        public REFR_XRDOBroadcastRangeType BroadcastRangeType { get; protected set; }
        public float StaticPercentage { get; protected set; }
        public uint PositionReference { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            RangeRadius = reader.ReadSingle();
            BroadcastRangeType = (REFR_XRDOBroadcastRangeType)reader.ReadUInt32();
            StaticPercentage = reader.ReadSingle();
            PositionReference = reader.ReadUInt32();
        }
    }

    public enum REFR_XRDOBroadcastRangeType
    {
        Radius = 0,
        Everywhere,
        WorldspaceAndLinkedInteriors,
        LinkedInteriors,
        CurrentCellOnly
    }
}
