using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieSYS.Data;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace MovieSYS.Business
{
    public class Utility
    {
        public static DataSet getCounties()
        {
            return QuerySearchCommand("CS", "SELECT CountyCode, Name FROM Counties ORDER BY Name");
        }

        public static DataSet getGenres()
        {
            return QuerySearchCommand("GS", "SELECT GenreCode, Name FROM Genres ORDER BY Name");
        }

        public static DataSet getAgeRating()
        {
            return QuerySearchCommand("ARS", "SELECT AgeRatingCode, Description FROM AgeRating");
        }

        public static DataSet getCategories()
        {
            return QuerySearchCommand("CTS", "SELECT CategoryCode, Description FROM Categories ORDER BY Description");
        }

        public static DataSet getStatus()
        {
            return QuerySearchCommand("STS", "SELECT StatusCode, Description FROM Status");
        }

        public static DataSet QuerySearchCommand(string sourceTable, string query)
        {
            //Define Source Table for Search
            string srcTbl = sourceTable;

            //define Sql Query
            string strSQL = query;

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataTable QueryAnalysisCommand(string query)
        {
            //define Sql Query
            string strSQL = query;

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteAnalysis(strSQL);
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

        public static void loadYears(ComboBox cboYear)
        {
            int currentYear = DateTime.Now.Year;
            for(int i = 2016; i <= currentYear; i++)
            {
                cboYear.Items.Add(i.ToString());
            }

            cboYear.SelectedIndex = (cboYear.Items.Count - 1);
        }

        public static string GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";
                    }
                case 2:
                    {
                        return "FEB";
                    }
                case 3:
                    {
                        return "MAR";
                    }
                case 4:
                    {
                        return "APR";
                    }
                case 5:
                    {
                        return "MAY";
                    }
                case 6:
                    {
                        return "JUN";
                    }
                case 7:
                    {
                        return "JUL";
                    }
                case 8:
                    {
                        return "AUG";
                    }
                case 9:
                    {
                        return "SEP";
                    }
                case 10:
                    {
                        return "OCT";
                    }
                case 11:
                    {
                        return "NOV";
                    }
                case 12:
                    {
                        return "DEC";
                    }
                default: return "OTH";
            }
        }

        public static string GetFullStatusDescription(string statusCode)
        {
            switch (statusCode)
            {
                case "A":
                    return "Available";
                case "U":
                    return "Unavailable";
                case "D":
                    return "Deleted";
                default:
                    return null;
            }
        }

        public static bool IsMovieAvailableForRental(string statusCode)
        {
            return statusCode == "A";
        }
    }
}
