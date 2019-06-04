using Fallout.NET.Core;
using Fallout.NET.TES4.SubRecords.DIAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fallout.NET.TES4.SubRecords.INFO
{
    public class INFO_DATASubRecord : SubRecord
    {
        public DialogType Type { get; protected set; }
        public NextSpeaker NextSpeaker { get; protected set; }
        public INFOFlags Flags { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Type = (DialogType)reader.ReadByte();
            NextSpeaker = (NextSpeaker)reader.ReadByte();
            Flags = (INFOFlags)BitConverter.ToUInt16(reader.ReadBytes(2), 0);
        }
    }
}
