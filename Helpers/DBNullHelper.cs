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
    class DBNullHelper
    {

        public static object GetValue(DataRow Row, object obj)
        {
            object Res = null;
            if (obj.GetType().Equals(typeof(ModelService)))
            {
                ModelService Temp = new ModelService();
                Temp.ItemCode =
                    Row.Table.Columns.Contains(ServiceObject.ItemCode) ?
                    Row[ServiceObject.ItemCode] != DBNull.Value ?(string) Row[ServiceObject.ItemCode] : "" : "";
                Temp.ItemName = Row.Table.Columns.Contains(ServiceObject.ItemName) ?
                    Row[ServiceObject.ItemName] != DBNull.Value ? (string)Row[ServiceObject.ItemName] : "" : "";
                Temp.sellprice = Row.Table.Columns.Contains(ServiceObject.sellprice) ?
                    Row[ServiceObject.sellprice] != DBNull.Value ? Convert.ToDouble(Row[ServiceObject.sellprice]) : 0D : 0D;
                Temp.Location = Row.Table.Columns.Contains(ServiceObject.Location) ?
                    Row[ServiceObject.Location] != DBNull.Value ? (string)Row[ServiceObject.Location] : "" : "";
                Temp.costprice = Row.Table.Columns.Contains(ServiceObject.costprice) ?
                   Row[ServiceObject.costprice] != DBNull.Value ? (double)Row[ServiceObject.costprice] : 0F : 0F;
                Temp.Discount = Row.Table.Columns.Contains(ServiceObject.Discount) ?
                   Row[ServiceObject.Discount] != DBNull.Value ? (double)Row[ServiceObject.Discount] : 0F : 0F;
                Temp.Crate = Row.Table.Columns.Contains(ServiceObject.Crate) ?
                   Row[ServiceObject.Crate] != DBNull.Value ? (double)Row[ServiceObject.Crate] : 0F : 0F;
                Temp.IsActive = Row.Table.Columns.Contains(ServiceObject.IsActive) ?
                   Row[ServiceObject.IsActive] != DBNull.Value ? (bool)Row[ServiceObject.IsActive] : false : false;
                Temp.IsDisc = Row.Table.Columns.Contains(ServiceObject.IsDisc) ?
                   Row[ServiceObject.IsDisc] != DBNull.Value ? (bool)Row[ServiceObject.IsDisc] : false : false;
                Temp.IsImp = Row.Table.Columns.Contains(ServiceObject.IsImp) ?
                   Row[ServiceObject.IsImp] != DBNull.Value ? (bool)Row[ServiceObject.IsImp] : false : false;
                Temp.munit = Row.Table.Columns.Contains(ServiceObject.munit) ?
                   Row[ServiceObject.munit] != DBNull.Value ? (string)Row[ServiceObject.munit] : "" : "";
                Temp.ReorderLvl = Row.Table.Columns.Contains(ServiceObject.ReorderLvl) ?
                   Row[ServiceObject.ReorderLvl] != DBNull.Value ? (int)Row[ServiceObject.ReorderLvl] : 0 : 0;
                Temp.IsRaw = Row.Table.Columns.Contains(ServiceObject.IsRaw) ?
                  Row[ServiceObject.IsRaw.ToString()] != DBNull.Value ? (bool)Row[ServiceObject.IsRaw.ToString()] : false : false;
                //Temp.Img = Row.Table.Columns.Contains(ServiceObject.IMAGE) ?
                //    Row[ServiceObject.IMAGE] != DBNull.Value ? ImageHelper.GetImageFromBytes((byte[])Row[ServiceObject.IMAGE]) : null : null;
                //Temp.Img = null;
                Res = Temp;
            }
            return Res;
        }

        internal static ModelWorker GetWorkerObject(DataRow Row, object obj)
        {
            ModelWorker Temp = new ModelWorker();
            Temp.ID =
                Row.Table.Columns.Contains(WorkerObject.ID) ?
                Row[WorkerObject.ID] != DBNull.Value ? Convert.ToInt32(Row[WorkerObject.ID]) : 0 : 0;
            Temp.Worker = Row.Table.Columns.Contains(WorkerObject.WORKER) ?
                Row[WorkerObject.WORKER] != DBNull.Value ? (string)Row[WorkerObject.WORKER] : "" : "";
            return Temp;
        }
    }
}
