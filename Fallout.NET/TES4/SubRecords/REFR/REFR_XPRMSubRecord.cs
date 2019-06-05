using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XPRMSubRecord : SubRecord
    {
        public float XBound { get; protected set; }
        public float YBound { get; protected set; }
        public float ZBound { get; protected set; }
        public float Red { get; protected set; }
        public float Green { get; protected set; }
        public float Blue { get; protected set; }
        public byte[] Unknown { get; protected set; }
        public REFR_XPRMTypes Type { get; protected set; }


        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            XBound = reader.ReadSingle();
            YBound = reader.ReadSingle();
            ZBound = reader.ReadSingle();
            Red = reader.ReadSingle();
            Green = reader.ReadSingle();
            Blue = reader.ReadSingle();
            Unknown = reader.ReadBytes(4);
            Type = (REFR_XPRMTypes)reader.ReadUInt32();
        }
    }

    public enum REFR_XPRMTypes
    {
        None = 0,
        Box,
        Sphere,
        PortalBox
    }
}
