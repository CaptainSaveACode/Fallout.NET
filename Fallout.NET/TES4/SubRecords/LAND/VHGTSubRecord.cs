using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.LAND
{
    public class VHGTSubRecord : SubRecord
    {
        public float Offset { get; protected set; }
        //public List<byte[]> Rows { get; protected set; }
        public sbyte[,] Rows { get; protected set; }
        public byte[] Unused { get; protected set; }
        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Offset = reader.ReadSingle();

            Rows = new sbyte[33, 33];
            for (var y = 0; y < 33; y++)
            {
                for (var x = 0; x < 33; x++)
                {
                    Rows[y, x] = (sbyte)reader.ReadByte();
                }
            }

            Unused = reader.ReadBytes(3);
        }
    }
}
