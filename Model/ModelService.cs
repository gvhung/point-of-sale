using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
    public class ModelService
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double sellprice { get; set; }
        public double costprice { get; set; }
        public string munit { get; set; }
        public bool IsActive { get; set; }
        public double Crate { get; set; }
        public bool IsImp { get; set; }
        public int ReorderLvl { get; set; }
        public string Location { get; set; }
        public bool IsDisc { get; set; }
        public double Discount { get; set; }
        public bool IsRaw { get; set; }
        ///////////////// Order Items
        public string INVNO { get; set; }
        public DateTime INVDate { get; set; }
        public TimeSpan Tr_Time { get; set; }
        public string Remarks { get; set; }
        public string Party { get; set; }
        public string userid { get; set; }
        public string keyfield { get; set; }
        public string FinYear { get; set; }
        public int TrType { get; set; }
        public string Vkey { get; set; }
        public float DisAmount { get; set; }
        public float ReAmount { get; set; }
        public float BalAmount { get; set; }
        public string workstation { get; set; }
        public string ModeofPay { get; set; }
        public int comp_id { get; set; }
    }
}
