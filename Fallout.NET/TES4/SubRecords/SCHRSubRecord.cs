using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords
{
    public class SCHRSubRecord : SubRecord
    {
        public byte[] Unused { get; protected set; }
        public uint RefCount { get; protected set; }
        public uint CompiledSize { get; protected set; }
        public uint VariableCount { get; protected set; }
        public SCHR_Types Type { get; protected set; }
        public SCHR_Flags Flags { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Unused = reader.ReadBytes(4);
            RefCount = reader.ReadUInt32();
            CompiledSize = reader.ReadUInt32();
            VariableCount = reader.ReadUInt32();
            Type = (SCHR_Types)reader.ReadUInt16();
            Flags = (SCHR_Flags)reader.ReadUInt16();
        }
    }

    public enum SCHR_Types
    {
        Object = 0,
        Quest = 1,
        Effect = 0x100
    }

    [Flags]
    public enum SCHR_Flags
    {
        Enabled = 0x0001
    }
}
