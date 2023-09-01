using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS.Data
{
    public class DBConnect
    {
        private static DBConnect instance;
        private string oraDB;

        private DBConnect()
        {
            // Initialize the connection string
            oraDB = "Data Source = localhost/orcl; User Id = C##User1; Password = 123456;";
        }

        public static DBConnect Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnect();
                }
                return instance;
            }
        }

        public OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(oraDB);
            // Other connection setup here
            return conn;
        }

        public OracleCommand CreateCommand(string query, OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand(query, conn);
            // Other command setup here
            return cmd;
        }

        // E.g. Add Movies, Add Members
        public void ExecuteNonQuery(string query)
        {
            using (OracleConnection conn = GetConnection())
            using (OracleCommand cmd = CreateCommand(query, conn))
            {
                //declare an Oracle Command to execute
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public OracleDataReader ExecuteReader(string query)
        {
            //Declare an Oracle Connection
            OracleConnection conn = GetConnection();
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = CreateCommand(query, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DataSet ExecuteSearch(string query, string srcTbl)
        {
            DataSet ds = new DataSet();

            using (OracleConnection conn = GetConnection())
            using (OracleCommand cmd = CreateCommand(query, conn))
            {
                //Declare an Oracle Connection
                conn.Open();

                //Declare an Oracle DataAdapter
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(ds, srcTbl);
                conn.Close();
            }
            return ds;
        }

        public DataTable ExecuteAnalysis(string query)
        {
            DataTable dt = new DataTable();

            using (OracleConnection conn = GetConnection())
            using (OracleCommand cmd = CreateCommand(query, conn))
            {
                //Declare an Oracle Connection
                conn.Open();

                //Declare an Oracle DataAdapter
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}
