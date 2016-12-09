using PointOfSale.Helpers;
using PointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controller
{
    class AuthenticationController
    {
        DBController DBHandler = new DBController();
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int AuthenticateUser(string UserName, string UserPwd)
        {
            int res = 0;
            String Query;
            Query = string.Format("Select [uid],[name],[role] from [tbl_users] where uname='{0}' AND pwd='{1}'", UserName, UserPwd);
            DataSet ds = (DataSet)DBHandler.CRUD(Query, 'r');
            if (DSHelper.HasResult(ref ds))
            {
                Global.UserId = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[0]);
                Global.FullName = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                return res = Convert.ToInt16(ds.Tables[0].Rows[0].ItemArray[2]);

            }
            else
            {
                return res;
            }
        }

    }
}
