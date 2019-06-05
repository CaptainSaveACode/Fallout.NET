using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XESPSubRecord : SubRecord
    {
        public uint Reference { get; protected set; }
        public REFR_XESPFlags Flags { get; protected set; }
        public byte[] Unknown { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Reference = reader.ReadUInt32();
            Flags = (REFR_XESPFlags)reader.ReadByte();
            Unknown = reader.ReadBytes(3);
        }
    }

    [Flags]
    public enum REFR_XESPFlags
    {
        SetEnableStateToOppositeOfParent = 0x01,
        PopIn = 0x02
    }
}
