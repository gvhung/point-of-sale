using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
   public class ModelOrder
    {
        public string INVNO { get; set; }
        public DateTime INVDate { get; set; }
        public TimeSpan Tr_Time { get; set; }
        public string Remarks { get; set; }
        public string Party { get; set; }
        public string userid { get; set; }
        public string keyfield { get; set; }
        public char FinYear {get;set;}
        public int TrType { get; set; }
        public string Vkey { get; set; }
        public float DisAmount { get; set; }
        public float ReAmount { get; set; }
        public float BalAmount { get; set; }
        public string workstation { get; set; }
        public string ModeofPay { get; set; }
        public int comp_id { get; set; }

    }
   public class ModelDetail
    {
        public string INVNO { get; set; }
        public float Rate { get; set; }
        public float Value { get; set; }
        public float Qty { get; set; }
        public string ItemCode { get; set; }
        public int enteryno { get; set; }
        public string keyfield { get; set; }
        char[] FinYear { get; set; }
        char[] munit { get; set; }
        public float stax { get; set; }
        public int TrType { get; set; }
        public float Disc { get; set; }
        public float StAmt { get; set; }
        public float DisAmt { get; set; }
        public string PONo { get; set; }
        public float Tr_CostRate { get; set; }
        public int comp_id { get; set; }

    }
}
