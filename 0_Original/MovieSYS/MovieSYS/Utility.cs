using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace MovieSYS
{
    class Utility
    {
        public static DataSet getCounties()
        {
            //define Sql Query
            String strSQL = "SELECT CountyCode, Name FROM Counties ORDER BY Name";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "CS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static void loadCombo(ComboBox cboName, String strSQL)
        {
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboName.Items.Add(dr.GetValue(0).ToString() + " - " + dr.GetValue(1).ToString());
            }

            //Close database connection
            conn.Close();
        }

        public static DataSet getGenres()
        {
            //define Sql Query
            String strSQL = "SELECT GenreCode, Name FROM Genres ORDER BY Name";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "GS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getAgeRating()
        {
            //define Sql Query
            String strSQL = "SELECT AgeRatingCode, Description FROM AgeRating";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "ARS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getCategories()
        {
            //define Sql Query
            String strSQL = "SELECT CategoryCode, Description FROM Categories ORDER BY Description";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "CTS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getStatus()
        {
            //define Sql Query
            String strSQL = "SELECT StatusCode, Description FROM Status";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "STS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static void loadYears(ComboBox cboYear)
        {
            int currentYear = DateTime.Now.Year;
            for(int i = 2016; i <= currentYear; i++)
            {
                cboYear.Items.Add(i.ToString());
            }

            cboYear.SelectedIndex = (cboYear.Items.Count - 1);
        }
    }
}
