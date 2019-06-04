using Fallout.NET.Core;

namespace Fallout.NET.TES4.Records
{
    public class BytesSubRecord : SubRecord
    {
        public byte[] Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadBytes((int)Size);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class ByteSubRecord : SubRecord
    {
        public byte Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadByte();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class STRSubRecord : SubRecord
    {
        public string Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadNullTerminatedString((int)Size);
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public class UInt16SubRecord : SubRecord
    {
        public ushort Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadUInt16();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class UInt32SubRecord : SubRecord
    {
        public uint Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadUInt32();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }


    public class UInt64SubRecord : SubRecord
    {
        public ulong Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadUInt64();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class FloatSubRecord : SubRecord
    {
        public float Value { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            Value = reader.ReadSingle();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class Vector2iSubRecord : SubRecord
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            X = reader.ReadInt32();
            Y = reader.ReadInt32();
        }

        public override string ToString()
        {
            return $"X:{X.ToString()} Y:{Y.ToString()})";
        }
    }
    public class Vector2fSubRecord : SubRecord
    {
        public float X { get; protected set; }
        public float Y { get; protected set; }

        public override void Deserialize(BetterReader reader, string name)
        {
            base.Deserialize(reader, name);
            X = reader.ReadSingle();
            Y = reader.ReadSingle();
        }

        public override string ToString()
        {
            return $"X:{X.ToString()} Y:{Y.ToString()})";
        }
    }
}
