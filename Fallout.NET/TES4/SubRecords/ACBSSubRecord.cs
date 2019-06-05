using System;
using System.Collections.Generic;
using System.Text;
using Fallout.NET.Core;

namespace Fallout.NET.TES4.SubRecords
{
    public class ACBSSubRecord : SubRecord
    {
        public uint Flags { get; protected set; }
        public ushort Fatigue { get; protected set; }
        public ushort BarterGold { get; protected set; }
        public short LevelOrLevelMult { get; protected set; }
        public ushort CalcMin { get; protected set; }
        public ushort CalcMax { get; protected set; }
        public ushort SpeedMult { get; protected set; }
        public float KarmaAlignment { get; protected set; }
        public short DispositionBase { get; protected set; }
        public ACBSTemplateFlags TemplateFlags { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);

            Flags = reader.ReadUInt32();
            Fatigue = reader.ReadUInt16();
            BarterGold = reader.ReadUInt16();
            LevelOrLevelMult = reader.ReadInt16();
            CalcMin = reader.ReadUInt16();
            CalcMax = reader.ReadUInt16();
            SpeedMult = reader.ReadUInt16();
            KarmaAlignment = reader.ReadSingle();
            DispositionBase = reader.ReadInt16();
            TemplateFlags = (ACBSTemplateFlags)reader.ReadUInt16();
        }
    }

    [Flags]
    public enum ACBSTemplateFlags
    {
        UseTraits = 0x0001,
        UseStats = 0x0002,
        UseFactions = 0x0004,
        UseActorEffectList = 0x0008,
        UseAIData = 0x0010,
        UseAIPackages = 0x0020,
        UseModelAnimation = 0x0040,
        UseBaseData = 0x0080,
        UseInventory = 0x0100,
        UseScript = 0x0200,
    }
}
