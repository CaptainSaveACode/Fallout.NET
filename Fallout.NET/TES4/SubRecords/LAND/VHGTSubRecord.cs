using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.LAND
{
    public class VHGTSubRecord : SubRecord
    {
        public float Offset { get; protected set; }
        public List<byte[]> Rows { get; protected set; }
        public byte[] Unused { get; protected set; }
        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Offset = reader.ReadSingle();

            Rows = new List<byte[]>();
            for(var i = 0; i < 33; i++)
            {
                Rows.Add(reader.ReadBytes(33));
            }

            Unused = reader.ReadBytes(3);
        }
    }
}
