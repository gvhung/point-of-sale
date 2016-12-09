using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Controller
{
    class DBController
    {
        public SqlConnection _SqlConnection { get; set; }
        public String _SqlConnectionString { get; set; }
        public DataSet _DataSet { get; set; }
        public List<SqlCommand> _CommandList { set; get; }
        public DBController()
        {
           // _SqlConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + @Properties.Settings.Default.ConnectionStringFolder + @"\pos.mdf;Integrated Security=True";
            _SqlConnectionString = @"Data Source=localhost;Initial Catalog=ABC;Integrated Security=True";
        }

        public void TestConnection(ref string error, ref int res)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_SqlConnectionString))
                {
                    con.Open();
                    res = (int)con.State;
                    error = "Database : " + con.Database + " is connected from " + con.DataSource;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                res = 16;
            }
        }

        public DataTable RunQuey(string Query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_SqlConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = Query;
                        DataTable dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());
                        return dt;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetRecords(string date1, string date2) 
        {
            string Query = string.Format("SELECT * FROM tbl_orders WHERE date between '{0}' AND '{1}' ORDER BY reference_no", date1, date2);
            return RunQuey(Query);
        }
        public bool OpenConnection()
        {

            _SqlConnection = new SqlConnection(_SqlConnectionString);
            if (_SqlConnection != null && _SqlConnection.State == ConnectionState.Closed)
            {

                _SqlConnection.Open();
            }
            return (_SqlConnection != null && _SqlConnection.State == ConnectionState.Open);
        }

        public bool CloseConnection()
        {
            if (_SqlConnection != null && _SqlConnection.State == ConnectionState.Open)
                _SqlConnection.Close();
            if (_SqlConnection != null)
                _SqlConnection.Dispose();
            return _SqlConnection == null;
        }
        public object CRUD(string Query, char operation = 'c')
        {
            operation = char.Parse(operation.ToString().ToLower());
            object res = null;
            try
            {
                OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                switch (operation)
                {
                    case 'c':
                    case 'i':
                        da.InsertCommand = _SqlConnection.CreateCommand();
                        da.InsertCommand.CommandText = Query;
                        da.InsertCommand.ExecuteNonQuery();
                        res = true;
                        break;
                    case 'z':
                        da.SelectCommand = _SqlConnection.CreateCommand();
                        da.SelectCommand.CommandText = Query;
                        return da.SelectCommand.ExecuteScalar();
                    case 's':
                    case 'r':
                        DataSet ds = new DataSet();
                        da.SelectCommand = _SqlConnection.CreateCommand();
                        da.SelectCommand.CommandText = Query;
                        //da.SelectCommand.ExecuteReader();
                        da.Fill(ds);
                        res = ds;
                        //ds.Dispose(); 
                        break;
                    case 'u':
                        da.UpdateCommand = _SqlConnection.CreateCommand();
                        da.UpdateCommand.CommandText = Query;
                        res = da.UpdateCommand.ExecuteNonQuery();
                        break;
                    case 'd':
                        da.DeleteCommand = _SqlConnection.CreateCommand();
                        da.DeleteCommand.CommandText = Query;
                        da.DeleteCommand.ExecuteNonQuery();
                        res = true;
                        break;
                    default: break;
                }
                if (res == null)
                    res = false;
            }
            catch (Exception ex)
            {

                string err = Environment.NewLine+DateTime.Now.ToString() + ":" + operation + ":" + Query + ":" + ex.Message;
                if (System.IO.File.Exists(Properties.Settings.Default.ErrorFile))
                {

                    System.IO.File.AppendAllText(Properties.Settings.Default.ErrorFile,err);
                }
                else
                {
                    System.IO.File.WriteAllText(Properties.Settings.Default.ErrorFile, err);
                }
                res = null;
            }
            finally
            {
                CloseConnection();
            }
            return res;
        }
    }
}