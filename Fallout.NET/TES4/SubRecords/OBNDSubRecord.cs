using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords
{
    public class OBNDSubRecord : SubRecord
    {
        public short X1 { get; protected set; }
        public short Y1 { get; protected set; }
        public short Z1 { get; protected set; }
        public short X2 { get; protected set; }
        public short Y2 { get; protected set; }
        public short Z2 { get; protected set; }
        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            X1 = reader.ReadInt16();
            Y1 = reader.ReadInt16();
            Z1 = reader.ReadInt16();
            X2 = reader.ReadInt16();
            Y2 = reader.ReadInt16();
            Z2 = reader.ReadInt16();
        }
    }
}
