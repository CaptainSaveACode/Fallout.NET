using Fallout.NET.Core;
using Fallout.NET.TES4.SubRecords;
using System.Collections.Generic;

namespace Fallout.NET.TES4.Records
{
	public class NPC_Record : Record
	{
        public STRSubRecord EDID { get; private set; }
        public STRSubRecord FULL { get; private set; }
        public STRSubRecord MODL { get; private set; }
        public OBNDSubRecord OBND { get; private set; }
        public ACBSSubRecord ACBS { get; private set; }
        public FormID INAM { get; private set; }
        public FormID VTCK { get; private set; }
        public FormID TPLT { get; private set; }
        public FormID RNAM { get; private set; }
        public FormID EITM { get; private set; }
        public FormID SCRI { get; private set; }
        public FormID CNAM { get; private set; }
        public FormID HNAM { get; private set; }
        public FormID ENAM { get; private set; }
        public FormID ZNAM { get; private set; }
        public List<FormID> PKID { get; private set; } = new List<FormID>();
        public List<FormID> PNAM { get; private set; } = new List<FormID>();
        public List<SNAMSubRecord> SNAM { get; private set; } = new List<SNAMSubRecord>();


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
                        case "OBND":
                            OBND = new OBNDSubRecord();
                            OBND.Deserialize(stream, name);
                            break;
                        case "MODL":
                            MODL = new STRSubRecord();
                            MODL.Deserialize(stream, name);
                            break;
                        case "ACBS":
                            ACBS = new ACBSSubRecord();
                            ACBS.Deserialize(stream, name);
                            break;
                        case "SNAM":
                            var snam = new SNAMSubRecord();
                            snam.Deserialize(stream, name);
                            SNAM.Add(snam);
                            break;
                        case "INAM":
                            INAM = new FormID();
                            INAM.Deserialize(stream, name);
                            break;
                        case "VTCK":
                            VTCK = new FormID();
                            VTCK.Deserialize(stream, name);
                            break;
                        case "TPLT":
                            TPLT = new FormID();
                            TPLT.Deserialize(stream, name);
                            break;
                        case "RNAM":
                            RNAM = new FormID();
                            RNAM.Deserialize(stream, name);
                            break;
                        case "EITM":
                            EITM = new FormID();
                            EITM.Deserialize(stream, name);
                            break;
                        case "SCRI":
                            SCRI = new FormID();
                            SCRI.Deserialize(stream, name);
                            break;
                        case "PKID":
                            var pkid = new FormID();
                            pkid.Deserialize(stream, name);
                            PKID.Add(pkid);
                            break;
                        case "CNAM":
                            CNAM = new FormID();
                            CNAM.Deserialize(stream, name);
                            break;
                        case "PNAM":
                            var pnam = new FormID();
                            pnam.Deserialize(stream, name);
                            PNAM.Add(pnam);
                            break;
                        case "HNAM":
                            HNAM = new FormID();
                            HNAM.Deserialize(stream, name);
                            break;
                        case "ENAM":
                            ENAM = new FormID();
                            ENAM.Deserialize(stream, name);
                            break;
                        case "ZNAM":
                            ZNAM = new FormID();
                            ZNAM.Deserialize(stream, name);
                            break;
                        default:
                            var rest = stream.ReadUInt16();
                            stream.ReadBytes(rest);
                            break;
                    }
                }
            }
        }
	}
}