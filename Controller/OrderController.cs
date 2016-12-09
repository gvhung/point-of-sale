using PointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controller
{
    class OrderController
    {
        DBController dBHandler = new DBController();
        public bool AddNewSale(ref string error,string reference_no, string u_id, ModelService arg)
        {
            string INVNO = reference_no + "/" + DateTime.Now.Day + "/" + DateTime.Now.Month + DateTime.Now.Year+"-1";
            bool res = false;
            try
            {
                String Query;
                Query = string.Format("Insert Into main(INVNO,INVDate,Tr_Time,Remarks,Party,userid,FinYear,TrType,Vkey,DisAmount,ReAmount,BalAmount,workstation,ModeofPay,comp_id) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", INVNO, arg.INVDate, arg.INVDate.ToShortTimeString(), arg.Remarks, arg.Party, arg.userid, arg.FinYear, arg.TrType, arg.Vkey, arg.DisAmount, arg.ReAmount, arg.BalAmount, arg.workstation, arg.ModeofPay, arg.comp_id);
                if (Convert.ToBoolean(dBHandler.CRUD(Query, 'c')))
                {
                    res = true;
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                res = false;
            }
            return res;
        }

        public bool AddNewOrder(ref string error,string reference_no, ModelService arg)
        {
            bool res = false;
            try
            {
                String Query;
                Query = string.Format("Insert Into detail(INVNO,INVDate,Tr_Time,Remarks,Party,userid,keyfield,FinYear,TrType,Vkey,DisAmount,ReAmount,BalAmount,workstation,ModeofPay,comp_id) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",reference_no,arg.INVDate,arg.Tr_Time,arg.Remarks,arg.Party,arg.userid,arg.FinYear,arg.TrType,arg.Vkey,arg.DisAmount,arg.ReAmount,arg.BalAmount,arg.workstation,arg.ModeofPay,arg.comp_id);
                if (Convert.ToBoolean(dBHandler.CRUD(Query, 'c')))
                {
                    res = true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                res = false;
            }
            return res;
        }
    }
}
