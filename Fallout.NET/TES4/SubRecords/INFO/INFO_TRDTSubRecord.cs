using Fallout.NET.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fallout.NET.TES4.SubRecords.INFO
{
    public class INFO_TRDTSubrecord : SubRecord
    {
        public DialogResponseEmotionType EmotionType { get; private set; }
        public uint EmotionValue { get; private set; }
        public byte[] Unused1 { get; private set; }
        public byte ResponseNumber { get; private set; }
        public byte[] Unused2 { get; private set; }
        public int Sound { get; private set; }
        public DialogResponseFlags Flags { get; private set; }
        public byte[] Unused3 { get; private set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            EmotionType = (DialogResponseEmotionType)reader.ReadUInt32();
            EmotionValue = reader.ReadUInt32();
            Unused1 = reader.ReadBytes(4);
            ResponseNumber = reader.ReadByte();
            Unused2 = reader.ReadBytes(3);
            Sound = reader.ReadInt32();
            Flags = (DialogResponseFlags)reader.ReadByte();
            Unused3 = reader.ReadBytes(3);
        }
    }
}
