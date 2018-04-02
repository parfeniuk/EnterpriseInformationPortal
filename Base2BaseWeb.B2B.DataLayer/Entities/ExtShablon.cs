using System;
using System.Collections.Generic;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class ExtShablon
    {
        public int ExtShablonNumber { get; set; }
        public int TovarNamePosition { get; set; }
        public int CenaPrice1Position { get; set; }
        public int CenaPrice2Position { get; set; }
        public int CenaPrice3Position { get; set; }
        public int CenaPrice4Position { get; set; }
        public int CenaPrice5Position { get; set; }
        public int CenaPrice1DolPosition { get; set; }
        public int CenaPrice2DolPosition { get; set; }
        public int CenaPrice3DolPosition { get; set; }
        public int CenaPrice4DolPosition { get; set; }
        public int CenaPrice5DolPosition { get; set; }
        public int TovarPresentPosition { get; set; }
        public int IsSplit { get; set; }
        public int SplitStep { get; set; }
        public string ShablonName { get; set; }
        public int PointNumber { get; set; }
        public int TovarDescripPosition { get; set; }

        public Point PointNumberNavigation { get; set; }
    }
}
