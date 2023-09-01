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

            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "SELECT MAX(RentalId) FROM Rentals";

            //Declare an Oracle Connection, execute the command, and connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                dr.Read();
                if (dr.IsDBNull(0))
                    nextId = 1;
                else
                    nextId = dr.GetInt32(0) + 1;
                return nextId;
            }
        }

        public void rentMovie()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "INSERT INTO Rentals VALUES (" + this.Id + "," +
            this.MemberId + ",'" + this.RentalDate + "','" + this.DueDate + "'," +
            this.Cost + ")";

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public void getRental(int Id)
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "SELECT * FROM Rentals WHERE RentalId = " + Id;

            //Declare an Oracle Connection, then connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                dr.Read();
                //read the record returned in dr and use values to instantiate the object
                this.Id = dr.GetInt32(0);
                this.MemberId = dr.GetInt32(1);
                this.RentalDate = dr.GetString(2);
                this.DueDate = dr.GetString(3);
                this.Cost = dr.GetDecimal(4);
            }
        }

        public static DataSet getMatchingRentals(String rentalIdSearch)
        {
            //Define Source Table for Search
            String srcTbl = "RID";

            //define Sql Query
            String strSQL = "SELECT RI.MovieId, Title, DueDate FROM Rentals R JOIN RentalItems RI ON R.RentalId = RI.RentalId " +
                "JOIN MOVIES M ON RI.MovieId = M.MovieId WHERE R.RentalId = '" +
                rentalIdSearch + "' AND ReturnedDate IS NULL ORDER BY M.Title";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);

        }

    }
}
