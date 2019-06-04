using Fallout.NET.Core;
using Fallout.NET.TES4.SubRecords;
using Fallout.NET.TES4.SubRecords.DIAL;
using Fallout.NET.TES4.SubRecords.INFO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fallout.NET.TES4.Records
{
    public class INFORecord : Record
    {
        public INFO_DATASubRecord DATA { get; private set; }
        public FormID QSTI { get; private set; }
        public INFO_ResponseSubRecordCollection Responses { get; private set; }
        public List<FormID> TCLT { get; private set; } = new List<FormID>();
        public List<FormID> TCLF { get; private set; } = new List<FormID>();


        protected override void ExtractSubRecords(BetterReader reader, GameID gameID, uint size)
        {
            var bytes = reader.ReadBytes((int)size);
            var name = string.Empty;

            using (var stream = new BetterMemoryReader(bytes))
            {
                var end = stream.Length;

                //var currentResponseCollection = new ResponseSubcollection();

                while (stream.Position < end)
                {
                    name = stream.ReadString(4);

                    switch (name)
                    {
                        case "DATA":
                            DATA = new INFO_DATASubRecord();
                            DATA.Deserialize(stream, name);
                            break;
                        case "QSTI":
                            QSTI = new FormID();
                            QSTI.Deserialize(stream, name);
                            break;
                        case "TRDT":
                            var trdt = new INFO_TRDTSubrecord();
                            trdt.Deserialize(stream, name);
                            Responses = new INFO_ResponseSubRecordCollection();
                            Responses.TRDT = trdt;
                            break;
                        case "NAM1":
                            var nam1 = new STRSubRecord();
                            nam1.Deserialize(stream, name);
                            Responses.NAM1 = nam1;
                            break;
                        case "NAM2":
                            var nam2 = new STRSubRecord();
                            nam2.Deserialize(stream, name);
                            Responses.NAM2 = nam2;
                            break;
                        case "NAM3":
                            var nam3 = new STRSubRecord();
                            nam3.Deserialize(stream, name);
                            Responses.NAM3 = nam3;
                            break;
                        case "TCLT":
                            var tclt = new FormID();
                            tclt.Deserialize(stream, name);
                            TCLT.Add(tclt);
                            break;
                        case "TCLF":
                            var tclf = new FormID();
                            tclf.Deserialize(stream, name);
                            TCLF.Add(tclf);
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