using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.WRLD
{
    public class WRLD_MNAMSubRecord : SubRecord
    {
        public int UseableXSize { get; set; }
        public int UseableYSize { get; set; }
        public short NWCellXCoordinate { get; set; }
        public short NWCellYCoordinate { get; set; }
        public short SECellXCoordinate { get; set; }
        public short SECellYCoordinate { get; set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            UseableXSize = reader.ReadInt32();
            UseableYSize = reader.ReadInt32();
            NWCellXCoordinate = reader.ReadInt16();
            NWCellYCoordinate = reader.ReadInt16();
            SECellXCoordinate = reader.ReadInt16();
            SECellYCoordinate = reader.ReadInt16();
        }
    }
}
