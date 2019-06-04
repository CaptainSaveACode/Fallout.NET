using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.WRLD
{
    public class WRLD_DNAMSubRecord : SubRecord
    {
        public float DefaultLandHeight { get; set; }
        public float DefaultWaterHeight { get; set; }
        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            DefaultLandHeight = reader.ReadSingle();
            DefaultWaterHeight = reader.ReadSingle();
        }
    }
}
