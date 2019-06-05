using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords
{
    public class PosAndRotSubRecord : SubRecord
    {
        public float X { get; protected set; }
        public float Y { get; protected set; }
        public float Z { get; protected set; }
        public float rX { get; protected set; }
        public float rY { get; protected set; }
        public float rZ { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            X = reader.ReadSingle();
            Y = reader.ReadSingle();
            Z = reader.ReadSingle();
            rX = reader.ReadSingle();
            rY = reader.ReadSingle();
            rZ = reader.ReadSingle();
        }
    }
}
