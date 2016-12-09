using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controller
{
    class WorkerController
    {
        DBController DBHandler = new DBController();
        public DataSet GetAllWorkers()
        {
            String Query;
            try
            {
                Query = string.Format("Select * From tbl_Workers");
                DataSet ds = (DataSet)DBHandler.CRUD(Query, 's');
                return ds;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public bool AddNewWorker(string Name)
        {
            bool Res = false;
            String Query;
            try
            {
                Query = string.Format("Insert into tbl_Workers(worker)Values('{0}')",Name);
                if (Convert.ToBoolean(DBHandler.CRUD(Query, 'c')))
                {
                    Res = true;
                }
            }
            catch (Exception)
            {

                Res = false;
            }

            return Res;
        }
        public bool DeleteWorker(int ID)
        {
            bool Res = false;
            String Query;
            try
            {
                Query = string.Format("Delete from tbl_Workers where w_id='{0}'", ID);
                if (Convert.ToBoolean(DBHandler.CRUD(Query, 'd')))
                {
                    Res = true;
                }
            }
            catch (Exception)
            {

                Res = false;
            }

            return Res;
        }

        public bool UpdateWorker(string p, string ID)
        {
            bool res = false;
            try
            {
                String Qurey = string.Format("Update tbl_Workers Set worker='{0}' where w_id='{1}'", p, ID);
                bool i = Convert.ToBoolean(DBHandler.CRUD(Qurey, 'u'));
                if (i)
                {
                    res = true;
                }
                else res = false;
            }
            catch (Exception)
            {
                res = false;
            }
            return res;
        }
    }
}
