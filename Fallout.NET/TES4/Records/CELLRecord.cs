using Fallout.NET.Core;
using Fallout.NET.TES4.SubRecords;
using Fallout.NET.TES4.SubRecords.CELL;

namespace Fallout.NET.TES4.Records
{
    public class CELLRecord : Record
    {
        public STRSubRecord EDID { get; private set; }
        public STRSubRecord FULL { get; private set; }
        public CELL_DATASubRecord DATA { get; private set; }
        public BytesSubRecord XCLL { get; private set; }
        public ByteSubRecord XCMT { get; private set; }
        public FormID XCLR { get; private set; }
        public FormID XCIM { get; private set; }
        public FormID XEZN { get; private set; }
        public FormID XCCM { get; private set; }
        public FormID XCWT { get; private set; }
        public FormID XOWN { get; private set; }
        public FormID XCAS { get; private set; }
        public FormID XCMO { get; private set; }

        public UInt32SubRecord XGLB { get; private set; }
        public UInt32SubRecord XRNK { get; private set; }
        public FloatSubRecord XCLW { get; private set; }
        public Vector2iSubRecord XCLC { get; private set; }

        protected override void ExtractSubRecords(BetterReader reader, GameID gameID, uint size)
        {
            var bytes = reader.ReadBytes((int)size);
            var name = string.Empty;

            using (var stream = new BetterMemoryReader(bytes))
            {
                var end = stream.Length;

                while (stream.Position < end)
                {
                    name = stream.ReadString(4);

                    switch (name)
                    {
                        case "EDID":
                            EDID = new STRSubRecord();
                            EDID.Deserialize(stream, name);
                            break;

                        case "FULL":
                            FULL = new STRSubRecord();
                            FULL.Deserialize(stream, name);
                            break;

                        case "DATA":
                            DATA = new CELL_DATASubRecord();
                            DATA.Deserialize(stream, name);
                            break;

                        case "XCLL":
                            XCLL = new BytesSubRecord();
                            XCLL.Deserialize(stream, name);
                            break;

                        case "XCMT":
                            XCMT = new ByteSubRecord();
                            XCMT.Deserialize(stream, name);
                            break;

                        case "XGLB":
                            XGLB = new UInt32SubRecord();
                            XGLB.Deserialize(stream, name);
                            break;

                        case "XRNK":
                            XRNK = new UInt32SubRecord();
                            XRNK.Deserialize(stream, name);
                            break;

                        case "XCLW":
                            XCLW = new FloatSubRecord();
                            XCLW.Deserialize(stream, name);
                            break;

                        case "XCLC":
                            XCLC = new Vector2iSubRecord();
                            XCLC.Deserialize(stream, name);
                            break;
                        

                        case "XCLR":
                            XCLR = new FormID();
                            XCLR.Deserialize(stream, name);
                            break;
                        case "XCIM":
                            XCIM = new FormID();
                            XCIM.Deserialize(stream, name);
                            break;
                        case "XEZN":
                            XEZN = new FormID();
                            XEZN.Deserialize(stream, name);
                            break;
                        case "XCCM":
                            XCCM = new FormID();
                            XCCM.Deserialize(stream, name);
                            break;
                        case "XCWT":
                            XCWT = new FormID();
                            XCWT.Deserialize(stream, name);
                            break;
                        case "XOWN":
                            XOWN = new FormID();
                            XOWN.Deserialize(stream, name);
                            break;
                        case "XCAS":
                            XCAS = new FormID();
                            XCAS.Deserialize(stream, name);
                            break;
                        case "XCMO":
                            XCMO = new FormID();
                            XCMO.Deserialize(stream, name);
                            break;

                        default:
                            var rest = stream.ReadUInt16();
                            stream.ReadBytes(rest);
                            break;
                    }
                }
            }            
        }

        public override string ToString()
        {
            return EDID.ToString();
        }
    }
}
