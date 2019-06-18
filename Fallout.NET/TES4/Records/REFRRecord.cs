using Fallout.NET.Core;
using Fallout.NET.TES4.SubRecords;
using Fallout.NET.TES4.SubRecords.REFR;
using System;
using System.Collections.Generic;

namespace Fallout.NET.TES4.Records
{
    public class REFRRecord : Record
    {
        public STRSubRecord EDID { get; private set; }
        public FormID NAME { get; private set; }
        public REFR_XLOCSubRecord XLOC { get; private set; }
        public FormID XOWN { get; private set; }
        public FormID XLKR { get; private set; }
        public PosAndRotSubRecord DATA { get; private set; }
        public FloatSubRecord XSCL { get; private set; }
        public REFR_XTELSubRecord XTEL { get; private set; }
        public REFR_XNDPSubRecord XNDP { get; private set; }
        public FormID XLTW { get; private set; }
        public FloatSubRecord XRDS { get; private set; }
        public FormID XEMI { get; private set; }
        public List<REFR_XPWRSubRecord> XPWR { get; private set; } = new List<REFR_XPWRSubRecord>();
        public FloatSubRecord XPRD { get; private set; }
        public FormID INAM { get; private set; }
        public SCHRSubRecord SCHR { get; private set; }
        //public REFR_TNAMSubRecord TNAM { get; private set; }
        //public FormID TNAM { get; private set; }
        public BytesSubRecord TNAM { get; private set; }
        public REFR_XMBOSubRecord XMBO { get; private set; }
        public REFR_XPRMSubRecord XPRM { get; private set; }
        public REFR_XRMRSubRecord XRMR { get; private set; }
        public FormID XLRM { get; private set; }
        public REFR_XACTSubRecord XACT { get; private set; }
        public BytesSubRecord XRGD { get; private set; }
        public FloatSubRecord XHLP { get; private set; }
        public ByteSubRecord XSED { get; private set; }
        public REFR_XPODSubRecord XPOD { get; private set; }
        public REFR_XRDOSubRecord XRDO { get; private set; }
        public ByteSubRecord XAPD { get; private set; }
        public List<REFR_XAPRSubRecord> XAPR { get; private set; } = new List<REFR_XAPRSubRecord>();
        public REFR_XESPSubRecord XESP { get; private set; }
        public UInt32SubRecord XLCM { get; private set; }
        public UInt32SubRecord XCNT { get; private set; }
        public REFR_XTRISubRecord XTRI { get; private set; }
        public BytesSubRecord XOCP { get; private set; }
        public FormID XAMT { get; private set; }
        public UInt32SubRecord XAMC { get; private set; }
        public FloatSubRecord XRAD { get; private set; }
        public FormID XTRG { get; private set; }
        public BytesSubRecord XORD { get; private set; }
        public FormID XMBR { get; private set; }
        public BytesSubRecord XCLP { get; private set; }
        public REFR_FNAMSubRecord FNAM { get; private set; }
        public STRSubRecord FULL { get; private set; }
        public BytesSubRecord SCDA { get; private set; }
        public BytesSubRecord SCRO { get; private set; }
        public BytesSubRecord XLOD { get; private set; }
        public BytesSubRecord RCLR { get; private set; }
        public BytesSubRecord XRGB { get; private set; }

        public bool XPPA { get; private set; }
        public bool ONAM { get; private set; }
        public bool XIBS { get; private set; }
        public bool XMBP { get; private set; }
        public bool XMRK { get; private set; }


        //protected override void ExtractSubRecords(BetterReader reader, GameID gameID, uint size)
        //{
        //    var bytes = reader.ReadBytes((int)size);
        //    var name = string.Empty;

        //    using (var stream = new BetterMemoryReader(bytes))
        //    {
        //        var end = stream.Length;

        //        while (stream.Position < end)
        //        {
        //            name = stream.ReadString(4);

        //            switch (name)
        //            {
        //                case "EDID":
        //                    EDID = new STRSubRecord();
        //                    EDID.Deserialize(stream, name);
        //                    break;
        //                case "NAME":
        //                    NAME = new FormID();
        //                    NAME.Deserialize(stream, name);
        //                    break;
        //                case "XLOC":
        //                    XLOC = new REFR_XLOCSubRecord();
        //                    XLOC.Deserialize(stream, name);
        //                    break;
        //                case "XOWN":
        //                    XOWN = new FormID();
        //                    XOWN.Deserialize(stream, name);
        //                    break;
        //                case "XLKR":
        //                    XLKR = new FormID();
        //                    XLKR.Deserialize(stream, name);
        //                    break;
        //                case "DATA":
        //                    DATA = new PosAndRotSubRecord();
        //                    DATA.Deserialize(stream, name);
        //                    break;
        //                case "XSCL":
        //                    XSCL = new FloatSubRecord();
        //                    XSCL.Deserialize(stream, name);
        //                    break;
        //                case "XTEL":
        //                    XTEL = new REFR_XTELSubRecord();
        //                    XTEL.Deserialize(stream, name);
        //                    break;
        //                case "XNDP":
        //                    XNDP = new REFR_XNDPSubRecord();
        //                    XNDP.Deserialize(stream, name);
        //                    break;
        //                case "XLTW":
        //                    XLTW = new FormID();
        //                    XLTW.Deserialize(stream, name);
        //                    break;
        //                case "XRDS":
        //                    XRDS = new FloatSubRecord();
        //                    XRDS.Deserialize(stream, name);
        //                    break;
        //                case "XEMI":
        //                    XEMI = new FormID();
        //                    XEMI.Deserialize(stream, name);
        //                    break;
        //                case "XPWR":
        //                    var xpwr = new REFR_XPWRSubRecord();
        //                    xpwr.Deserialize(stream, name);
        //                    XPWR.Add(xpwr);
        //                    break;
        //                case "XPRD":
        //                    XPRD = new FloatSubRecord();
        //                    XPRD.Deserialize(stream, name);
        //                    break;
        //                case "XPPA":
        //                    var xppaSize = stream.ReadUInt16();
        //                    var xppaData = stream.ReadBytes(Convert.ToInt32(xppaSize));
        //                    XPPA = true;
        //                    if (xppaData.Length > 0)
        //                    {
        //                        break;
        //                    }
        //                    break;
        //                case "INAM":
        //                    INAM = new FormID();
        //                    INAM.Deserialize(stream, name);
        //                    break;
        //                case "SCHR":
        //                    SCHR = new SCHRSubRecord();
        //                    SCHR.Deserialize(stream, name);
        //                    break;
        //                case "TNAM":
        //                    TNAM = new BytesSubRecord();
        //                    TNAM.Deserialize(stream, name);
        //                    break;
        //                case "XMBO":
        //                    XMBO = new REFR_XMBOSubRecord();
        //                    XMBO.Deserialize(stream, name);
        //                    break;
        //                case "XPRM":
        //                    XPRM = new REFR_XPRMSubRecord();
        //                    XPRM.Deserialize(stream, name);
        //                    break;
        //                case "XRMR":
        //                    XRMR = new REFR_XRMRSubRecord();
        //                    XRMR.Deserialize(stream, name);
        //                    break;
        //                case "XLRM":
        //                    XLRM = new FormID();
        //                    XLRM.Deserialize(stream, name);
        //                    break;
        //                case "XACT":
        //                    XACT = new REFR_XACTSubRecord();
        //                    XACT.Deserialize(stream, name);
        //                    break;
        //                case "ONAM":
        //                    var onamSize = stream.ReadUInt16();
        //                    var onamData = stream.ReadBytes(Convert.ToInt32(onamSize));
        //                    ONAM = true;
        //                    if (onamData.Length > 0)
        //                    {
        //                        break;
        //                    }
        //                    break;
        //                case "XRGD":
        //                    XRGD = new BytesSubRecord();
        //                    XRGD.Deserialize(stream, name);
        //                    break;
        //                case "XHLP":
        //                    XHLP = new FloatSubRecord();
        //                    XHLP.Deserialize(stream, name);
        //                    break;
        //                case "XSED":
        //                    XSED = new ByteSubRecord();
        //                    XSED.Deserialize(stream, name);
        //                    break;
        //                case "XPOD":
        //                    XPOD = new REFR_XPODSubRecord();
        //                    XPOD.Deserialize(stream, name);
        //                    break;
        //                case "XRDO":
        //                    XRDO = new REFR_XRDOSubRecord();
        //                    XRDO.Deserialize(stream, name);
        //                    break;
        //                case "XAPD":
        //                    XAPD = new ByteSubRecord();
        //                    XAPD.Deserialize(stream, name);
        //                    break;
        //                case "XAPR":
        //                    var xapr = new REFR_XAPRSubRecord();
        //                    xapr.Deserialize(stream, name);
        //                    XAPR.Add(xapr);
                            
        //                    if(XAPR.Count > 1)
        //                    {
        //                        break;
        //                    }
        //                    break;
        //                case "XESP":
        //                    XESP = new REFR_XESPSubRecord();
        //                    XESP.Deserialize(stream, name);
        //                    break;
        //                case "XLCM":
        //                    XLCM = new UInt32SubRecord();
        //                    XLCM.Deserialize(stream, name);
        //                    break;
        //                case "XCNT":
        //                    XCNT = new UInt32SubRecord();
        //                    XCNT.Deserialize(stream, name);
        //                    break;
        //                case "XTRI":
        //                    XTRI = new REFR_XTRISubRecord();
        //                    XTRI.Deserialize(stream, name);
        //                    break;
        //                case "XOCP":
        //                    XOCP = new BytesSubRecord();
        //                    XOCP.Deserialize(stream, name);
        //                    break;
        //                case "XAMT":
        //                    XAMT = new FormID();
        //                    XAMT.Deserialize(stream, name);
        //                    break;
        //                case "XAMC":
        //                    XAMC = new UInt32SubRecord();
        //                    XAMC.Deserialize(stream, name);
        //                    break;
        //                case "XRAD":
        //                    XRAD = new FloatSubRecord();
        //                    XRAD.Deserialize(stream, name);
        //                    break;
        //                case "XIBS":
        //                    var xibsSize = stream.ReadUInt16();
        //                    var xibsData = stream.ReadBytes(xibsSize);
        //                    XIBS = true;
        //                    break;
        //                case "XTRG":
        //                    XTRG = new FormID();
        //                    XTRG.Deserialize(stream, name);
        //                    break;
        //                case "XORD":
        //                    XORD = new BytesSubRecord();
        //                    XORD.Deserialize(stream, name);
        //                    break;
        //                case "XMBP":
        //                    var xmbpSize = stream.ReadUInt16();
        //                    var xmbpData = stream.ReadBytes(xmbpSize);
        //                    XMBP = true;
        //                    break;
        //                case "XMBR":
        //                    XMBR = new FormID();
        //                    XMBR.Deserialize(stream, name);
        //                    break;
        //                case "XCLP":
        //                    XCLP = new BytesSubRecord();
        //                    XCLP.Deserialize(stream, name);
        //                    break;
        //                case "XMRK":
        //                    var xmrkSize = stream.ReadUInt16();
        //                    var xmrkData = stream.ReadBytes(xmrkSize);
        //                    XMRK = true;
        //                    break;
        //                case "FNAM":
        //                    FNAM = new REFR_FNAMSubRecord();
        //                    FNAM.Deserialize(stream, name);
        //                    break;
        //                case "FULL":
        //                    FULL = new STRSubRecord();
        //                    FULL.Deserialize(stream, name);
        //                    break;
        //                case "SCDA":
        //                    SCDA = new BytesSubRecord();
        //                    SCDA.Deserialize(stream, name);
        //                    break;
        //                case "SCRO":
        //                    SCRO = new BytesSubRecord();
        //                    SCRO.Deserialize(stream, name);
        //                    break;
        //                case "XLOD":
        //                    XLOD = new BytesSubRecord();
        //                    XLOD.Deserialize(stream, name);
        //                    break;
        //                case "RCLR":
        //                    RCLR = new BytesSubRecord();
        //                    RCLR.Deserialize(stream, name);
        //                    break;
        //                case "XRGB":
        //                    XRGB = new BytesSubRecord();
        //                    XRGB.Deserialize(stream, name);
        //                    break;
        //                default:
        //                    var rest = stream.ReadUInt16();
        //                    stream.ReadBytes(rest);
        //                    break;
        //            }
        //        }
        //    }
        //}

    }
}