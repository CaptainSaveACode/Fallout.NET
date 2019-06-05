﻿using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.REFR
{
    public class REFR_XRMRSubRecord : SubRecord
    {
        public ushort LinkedRoomsCount { get; protected set; }
        public byte[] Unknown { get; protected set; }


        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            LinkedRoomsCount = reader.ReadUInt16();
            Unknown = reader.ReadBytes(2);
        }
    }
}
