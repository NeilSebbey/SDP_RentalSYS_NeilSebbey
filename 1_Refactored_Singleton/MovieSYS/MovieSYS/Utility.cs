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
            //Define Source Table for Search
            String srcTbl = "CS";

            //define Sql Query
            String strSQL = "SELECT CountyCode, Name FROM Counties ORDER BY Name";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static void loadCombo(ComboBox cboName, String strSQL)
        {
            DBConnect dbConn = DBConnect.Instance;

            //Declare an Oracle Connection, then connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                while (dr.Read())
                {
                    cboName.Items.Add(dr.GetValue(0).ToString() + " - " + dr.GetValue(1).ToString());
                }
            }
        }

        public static DataSet getGenres()
        {
            //Define Source Table for Search
            String srcTbl = "GS";

            //define Sql Query
            String strSQL = "SELECT GenreCode, Name FROM Genres ORDER BY Name";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataSet getAgeRating()
        {
            //Define Source Table for Search
            String srcTbl = "ARS";

            //define Sql Query
            String strSQL = "SELECT AgeRatingCode, Description FROM AgeRating";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataSet getCategories()
        {
            //Define Source Table for Search
            String srcTbl = "CTS";

            //define Sql Query
            String strSQL = "SELECT CategoryCode, Description FROM Categories ORDER BY Description";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataSet getStatus()
        {
            //Define Source Table for Search
            String srcTbl = "STS";

            //define Sql Query
            String strSQL = "SELECT StatusCode, Description FROM Status";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
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
