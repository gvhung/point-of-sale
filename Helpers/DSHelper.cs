using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Helpers
{
    class DSHelper
    {
        public static bool HasResult(ref DataSet Args, string TableName = null)
        {
            bool Res = false;
            if (string.IsNullOrEmpty(TableName))
            {
                Res = Args != null && Args.Tables != null && Args.Tables[0] != null && Args.Tables[0].Rows != null && Args.Tables[0].Rows.Count > 0;
            }
            else
            {
                if (Args.Tables.Contains(TableName))
                    Res = Args.Tables[TableName].Rows.Count > 0;
            }
            return Res;
        }
    }
}
