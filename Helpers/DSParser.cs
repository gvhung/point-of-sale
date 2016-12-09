using PointOfSale.Constants;
using PointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Helpers
{
    class DSParser
    {
        public static List<ModelService> ParseServices(ref DataSet Args, String TableName = "")
        {
            List<ModelService> Res = new List<ModelService>();
            if (DSHelper.HasResult(ref Args))
            {
                DataTable dt = string.IsNullOrEmpty(TableName) ? Args.Tables[0] : (Args.Tables.Contains(TableName)) ? Args.Tables[TableName] : Args.Tables[0];
                foreach (DataRow Row in dt.Rows)
                {
                    ModelService Temp = new ModelService();
                    Temp = (ModelService)DBNullHelper.GetValue(Row, Temp);
                    if (Temp != null)
                    {
                        Res.Add(Temp);
                    }
                }
            }
            else
            {
                Res = null;
            }
            return Res;
        }

        public List<ModelWorker> ParseWorkersDataSet(DataSet Args,string TableName=null)
        {
            List<ModelWorker> Res = new List<ModelWorker>();
            if (DSHelper.HasResult(ref Args))
            {
                DataTable dt = string.IsNullOrEmpty(TableName) ? Args.Tables[0] : (Args.Tables.Contains(TableName)) ? Args.Tables[TableName] : Args.Tables[0];
                foreach (DataRow Row in dt.Rows)
                {
                    ModelWorker Temp = new ModelWorker();
                    Temp = (ModelWorker)DBNullHelper.GetWorkerObject(Row, Temp);
                    if (Temp != null)
                    {
                        Res.Add(Temp);
                    }
                }
            }
            else
            {
                Res = null;
            }
            return Res;
        }
    }
}
