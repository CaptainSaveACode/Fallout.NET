using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XTELSubRecord : SubRecord
    {
        public uint Door { get; protected set; }
        public float X { get; protected set; }
        public float Y { get; protected set; }
        public float Z { get; protected set; }
        public float rX { get; protected set; }
        public float rY { get; protected set; }
        public float rZ { get; protected set; }
        public REFR_XTELFlags Flags { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Door = reader.ReadUInt32();
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();
            rX = reader.ReadSingle();
            rY = reader.ReadSingle();
            rZ = reader.ReadSingle();
            Flags = (REFR_XTELFlags)reader.ReadUInt32();
        }
    }

    [Flags]
    public enum REFR_XTELFlags
    {
        NoAlarm = 0x01
    }
}
