using PointOfSale.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PointOfSale.Controller
{
    class ServiceController
    {
        public int ID { get; set; }
        public string Service { get; set; }
        public float Price { get; set; }
        public string Descp { get; set; }
        public Image Img { get; set; }
        DBController DBHandler = new DBController();
        public bool AddService(string service, float price, string descrip, Image img)
        {
            bool res = false;
            try
            {
                String Qurey = string.Format("Insert into tbl_services(Service,Charges,Description,Img) VALUES ('{0}','{1}','{2}','{3}')", service, price, descrip, img);
              bool i=Convert.ToBoolean(DBHandler.CRUD(Qurey, 'i'));
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
        public bool UpdateService(string service, float price, string descrip, Image img, string Id)
        {
            bool res = false;
            try
            {
                String Qurey = string.Format("Update tbl_services Set Service='{0}',Charges='{1}',Description='{2}',Img='{3}' where s_id='{4}'", service, price, descrip, img,Id);
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
        public DataSet GetAllServies()
        {
            String Query; 
            try
            {
                Query = string.Format("Select * From itemdet");
                DataSet ds =(DataSet) DBHandler.CRUD(Query, 's');
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        
        }
        public bool DeleteService(int ID)
        {
            bool Res = false;
            String Query;
            try
            {
                Query = string.Format("Delete from [itemdet] where ItemCode='{0}'", ID);
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

        internal bool AddService(string p1, string p2, double p3, double p4, double p5, bool p6, bool p7, bool p8, bool p9, string p10, string p11, int p12, double p13)
        {
            bool res = false;
            try
            {
                String Qurey = string.Format("INSERT INTO [itemdet]([sellprice],[costprice] ,[ItemCode] ,[ItemName],[munit],[IsActive],[Crate],[IsImp],[ReorderLvl],[Location],[IsDisc],[Discount],[IsRaw])VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
                    p13,p3,p2,p1.ToUpper(),p11,p6,p4,p8,p12,p10,p7,p5,p9);
                bool i = Convert.ToBoolean(DBHandler.CRUD(Qurey, 'i'));
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

        internal static DataSet GetItemByID(string p)
        {
            String Query;
            DBController DBHandler = new DBController();
            try
            {
                Query = string.Format("Select * From itemdet where ItemCode={0}",p);
                DataSet ds = (DataSet)DBHandler.CRUD(Query, 's');
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        internal bool UpdateService(string ItemName, float sellprice, double costprice, double Crate, double Discount, bool IsActive, bool IsDisc, bool IsImp, string Location, string munit, int ReorderLvl, bool IsRw, string ID)
        {
            bool res = false;
            try
            {
                StringBuilder sb = new StringBuilder();


                String Qurey = string.Format("UPDATE [dbo].[itemdet] SET [sellprice] = '{0}',[costprice] = '{1}',[ItemName] = '{2}',[munit] = '{3}',[IsActive] = '{4}',[Crate] = '{5}',[IsImp] = '{6}',[ReorderLvl] = '{7}',[Location] = '{8}',[IsDisc] = '{9}',[Discount] = '{10}',[IsRaw] = '{11}' WHERE ItemCode={12}"
                         ,sellprice,costprice,ItemName,munit,IsActive,Crate,IsImp,ReorderLvl,Location,IsDisc,Discount,IsRw,ID);
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

        internal string GetMaxId()
        {
            String Query;
           
            try
            {
                Query = string.Format("select MAX(INVNO) from main");
                DataSet ds = (DataSet)DBHandler.CRUD(Query, 's');
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
