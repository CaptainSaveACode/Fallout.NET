using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords.LAND
{
    public class VNMLorVCLRSubRecord : SubRecord
    {
        public List<VNMLorVCLRStruct[]> Rows { get; protected set; }
        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Rows = new List<VNMLorVCLRStruct[]>();

            var newRow = new List<VNMLorVCLRStruct>();
            for (var i = 0; i < 1089; i++)
            {
                var record = new VNMLorVCLRStruct
                {
                    X = reader.ReadByte(),
                    Y = reader.ReadByte(),
                    Z = reader.ReadByte()
                };
                newRow.Add(record);

                if(newRow.Count == 33)
                {
                    Rows.Add(newRow.ToArray());
                    newRow.Clear();
                }
            }
            
        }
    }

    public struct VNMLorVCLRStruct
    {
        public byte X { get; set; }
        public byte Y { get; set; }
        public byte Z { get; set; }
    }
}
