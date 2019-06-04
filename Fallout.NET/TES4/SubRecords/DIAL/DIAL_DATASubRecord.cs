using Fallout.NET.Core;

using System;
using System.Collections.Generic;
using System.Text;

namespace Fallout.NET.TES4.SubRecords.DIAL
{
    public class DIAL_DATASubRecord : SubRecord
    {
        public DialogType Type { get; private set; }
        public DialogFlags Flags { get; private set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Type = (DialogType)reader.ReadByte();
            Flags = (DialogFlags)reader.ReadByte();
        }
    }
}
