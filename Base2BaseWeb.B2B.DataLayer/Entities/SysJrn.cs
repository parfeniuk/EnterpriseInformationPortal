using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class SysJrn
    {
        public int SysJrnNumber { get; set; }
        public string NameOper { get; set; }
        public string CompNumber { get; set; }
        public int? UserNumber { get; set; }
        public string UserName { get; set; }
        public string UserPasswd { get; set; }
        public int? ReestrNumber { get; set; }
        public DateTime? DateDoc { get; set; }
        public int? JrnNumber { get; set; }
        public int? NaklNumber { get; set; }
        public int? AktNumber { get; set; }
        public int? ZadNumber { get; set; }
        public int? TovarNumber { get; set; }
        public int? ClientNumber { get; set; }
        public DateTime? DateOperBase { get; set; }
        public DateTime? DateOperClient { get; set; }
        public bool Sprav { get; set; }
        public bool Admin { get; set; }
        public bool CliZad { get; set; }
        public int? PointNumber { get; set; }
        public bool PNV { get; set; }
        public bool PNE { get; set; }
        public bool PND { get; set; }
        public bool PerNV { get; set; }
        public bool PerNE { get; set; }
        public bool PerND { get; set; }
        public bool RNV { get; set; }
        public bool RNE { get; set; }
        public bool RND { get; set; }
        public bool APerV { get; set; }
        public bool APerE { get; set; }
        public bool APerD { get; set; }
        public bool ASpisV { get; set; }
        public bool ASpisE { get; set; }
        public bool ASpisD { get; set; }
        public bool KV { get; set; }
        public bool KE { get; set; }
        public bool KD { get; set; }
        public bool ZCliV { get; set; }
        public bool ZCliE { get; set; }
        public bool ZCliD { get; set; }
        public bool ZFirmV { get; set; }
        public bool ZFirmE { get; set; }
        public bool ZFirmD { get; set; }
        public int? MsgNumber { get; set; }
    }
}
