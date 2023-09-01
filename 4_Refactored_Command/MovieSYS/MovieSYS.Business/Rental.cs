using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSYS.Data;

namespace MovieSYS.Business
{
    public class Rental
    {
        private int id;
        private int memberId;
        private string rentalDate;
        private string dueDate;
        private decimal cost;

        //Constructor
        public Rental()
        {
            id = 0;
            memberId = 0;
            rentalDate = "";
            dueDate = "";
            cost = 0;
        }

        public Rental(int id, int memberId, string rentalDate, string dueDate, decimal cost)
        {
            this.id = id;
            this.memberId = memberId;
            this.rentalDate = rentalDate;
            this.dueDate = dueDate;
            this.cost = cost;
        }

        public int GetId()
        {
            return this.id;
        }

        public int GetMemberId()
        {
            return this.memberId;
        }

        public string GetRentalDate()
        {
            return this.rentalDate;
        }

        public string GetDueDate()
        {
            return this.dueDate;
        }

        public decimal GetCost()
        {
            return this.cost;
        }

        public void SetMemberId(int memberId)
        {
            this.memberId = memberId;
        }

        public void SetRentalDate(string rentalDate)
        {
            this.rentalDate = rentalDate;
        }

        public void SetDueDate(string dueDate)
        {
            this.dueDate = dueDate;
        }

        public void SetCost(decimal cost)
        {
            this.cost = cost;
        }

        public static int GetNextId()
        {
            int nextId = 0;

            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            string strSQL = "SELECT MAX(RentalId) FROM Rentals";

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

        public void RentMovie()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            string strSQL = "INSERT INTO Rentals VALUES (" + this.id + "," +
            this.memberId + ",'" + this.rentalDate + "','" + this.dueDate + "'," +
            this.cost + ")";

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public void GetRental(int Id)
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            string strSQL = "SELECT * FROM Rentals WHERE RentalId = " + Id;

            //Declare an Oracle Connection, then connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                dr.Read();
                //read the record returned in dr and use values to instantiate the object
                this.id = dr.GetInt32(0);
                this.memberId = dr.GetInt32(1);
                this.rentalDate = dr.GetString(2);
                this.dueDate = dr.GetString(3);
                this.cost = dr.GetDecimal(4);
            }
        }

        public static DataSet GetMatchingRentals(string rentalIdSearch)
        {
            return Utility.QuerySearchCommand("RID", "SELECT RI.MovieId, Title, DueDate FROM Rentals R JOIN RentalItems RI ON R.RentalId = RI.RentalId " +
                "JOIN MOVIES M ON RI.MovieId = M.MovieId WHERE R.RentalId = '" +
                rentalIdSearch + "' AND ReturnedDate IS NULL ORDER BY M.Title");
        }

        public static DataTable GetRevenueAnalysis(string cboRentDate)
        {
            return Utility.QueryAnalysisCommand("SELECT SUM(Cost), to_Char(RentDate,'MM') FROM Rentals " +
                "WHERE RentDate LIKE '%" + cboRentDate + "' GROUP BY to_Char(RentDate,'MM') ORDER BY to_char(RentDate,'MM')");
        }

        public static DataTable GetCategoryAnalysis(string cboRentDate, string cboCategory)
        {
            return Utility.QueryAnalysisCommand("SELECT SUM(RT.Cost), to_Char(RT.RentDate,'MM') FROM Rentals RT JOIN RentalItems RI ON RT.RentalId = RI.RentalId " +
                "WHERE RT.RentDate LIKE '%" + cboRentDate + "' AND RI.Category = '" + cboCategory +
                "' GROUP BY to_Char(RT.RentDate,'MM') ORDER BY to_char(RT.RentDate,'MM')");
        }

    }
}
