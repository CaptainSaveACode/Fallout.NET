using Fallout.NET.TES4.Records;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fallout.NET.TES4.SubRecords.INFO
{
    public class INFO_ResponseSubRecordCollection
    {
        public INFO_TRDTSubrecord TRDT { get; set; }
        public STRSubRecord NAM1 { get; set; }
        public STRSubRecord NAM2 { get; set; }
        public STRSubRecord NAM3 { get; set; }
        public FormID SNAM { get; set; }
        public FormID LNAM { get; set; }
    }
}
