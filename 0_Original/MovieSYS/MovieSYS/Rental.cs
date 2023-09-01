using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSYS
{
    class Rental
    {
        private int Id;
        private int MemberId;
        private String RentalDate;
        private String DueDate;
        private Decimal Cost;

        //Constructor
        public Rental()
        {
            Id = 0;
            MemberId = 0;
            RentalDate = "";
            DueDate = "";
            Cost = 0;
        }

        public Rental(int Id, int MemberId, String RentalDate, String DueDate, Decimal Cost)
        {
            this.Id = Id;
            this.MemberId = MemberId;
            this.RentalDate = RentalDate;
            this.DueDate = DueDate;
            this.Cost = Cost;
        }

        public int getId()
        {
            return this.Id;
        }

        public int getMemberId()
        {
            return this.MemberId;
        }

        public String getRentalDate()
        {
            return this.RentalDate;
        }

        public String getDueDate()
        {
            return this.DueDate;
        }

        public Decimal getCost()
        {
            return this.Cost;
        }

        public void setMemberId(int MemberId)
        {
            this.MemberId = MemberId;
        }

        public void setRentalDate(String RentalDate)
        {
            this.RentalDate = RentalDate;
        }

        public void setDueDate(String DueDate)
        {
            this.DueDate = DueDate;
        }

        public void setCost(Decimal Cost)
        {
            this.Cost = Cost;
        }

        public static int getNextId()
        {
            int nextId = 0;

            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT MAX(RentalId) FROM Rentals";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            //An aggregate function ALWAYS returns one record
            //which contains the largest MovieId in the table OR NULL
            dr.Read();
            if (dr.IsDBNull(0))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;
            conn.Close();
            return nextId;
        }

        public void rentMovie()
        {
            //define Sql Query
            String strSQL = "INSERT INTO Rentals VALUES (" + this.Id + "," +
            this.MemberId + ",'" + this.RentalDate + "','" + this.DueDate + "'," +
            this.Cost + ")";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void getRental(int Id)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Rentals WHERE RentalId = " + Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.Id = dr.GetInt32(0);
            this.MemberId = dr.GetInt32(1);
            this.RentalDate = dr.GetString(2);
            this.DueDate = dr.GetString(3);
            this.Cost = dr.GetDecimal(4);
            //close database connection
            conn.Close();
        }

        public static DataSet getMatchingRentals(String rentalIdSearch)
        {
            //define Sql Query
            String strSQL = "SELECT RI.MovieId, Title, DueDate FROM Rentals R JOIN RentalItems RI ON R.RentalId = RI.RentalId " +
                "JOIN MOVIES M ON RI.MovieId = M.MovieId WHERE R.RentalId = '" +
                rentalIdSearch + "' AND ReturnedDate IS NULL ORDER BY M.Title";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "RID");

            //Close database connection
            conn.Close();

            return ds;
        }

    }
}
