using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS
{
    class Movie
    {
        private int Id;
        private String Title;
        private String Genre;
        private String AgeRating;
        private int Year;
        private String Category;
        private String Status;

        //Constructor
        public Movie()
        {
            Id = 0;
            Title = "";
            Genre = "";
            AgeRating = "";
            Year = 0;
            Category = "";
            Status = "";
        }

        public Movie(int Id, String Title, String Genre, String AgeRating, int Year, String Category, String Status)
        {
            this.Id = Id;
            this.Title = Title;
            this.Genre = Genre;
            this.AgeRating = AgeRating;
            this.Year = Year;
            this.Category = Category;
            this.Status = Status;
        }

        public int getId()
        {
            return this.Id;
        }

        public String getTitle()
        {
            return this.Title;
        }

        public String getGenre()
        {
            return this.Genre;
        }

        public String getAgeRating()
        {
            return this.AgeRating;
        }

        public int getYear()
        {
            return this.Year;
        }

        public String getCategory()
        {
            return this.Category;
        }

        public String getStatus()
        {
            return this.Status;
        }

        public static int getNextId()
        {
            int nextId = 0;

            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT MAX(MovieId) FROM Movies";
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

        public void addMovie()
        {
            //define Sql Query
            String strSQL = "INSERT INTO Movies VALUES (" + this.Id + ",'" +
            this.Title + "','" + this.Genre + "','" + this.AgeRating + "'," +
            this.Year + ",'" + this.Category + "','" + this.Status + "')";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet getMatchingMovies(String titleSearch)
        {
            //define Sql Query
            String strSQL = "SELECT MovieId, Title, Status FROM Movies WHERE Title LIKE '" +
                titleSearch + "%' AND (Status='A' OR Status='U') ORDER BY MovieId";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MVS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getMatchingMoviesAlter(String titleSearch)
        {
            //define Sql Query
            String strSQL = "SELECT MovieId, Title FROM Movies WHERE Title LIKE '" +
                titleSearch + "%' AND Status='A' ORDER BY MovieId";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MVS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getMatchingAvailMovies(String titleSearch)
        {
            //define Sql Query
            String strSQL = "SELECT MovieId, Title, Category, Rate FROM Movies M JOIN Categories C ON M.Category = C.CategoryCode " + 
                "WHERE Title LIKE '%" + titleSearch + "%' AND STATUS='A' ORDER BY MovieId";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MVS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public static DataSet getMatchingRentedMovies(String movieIdSearch, String memberIdSearch)
        {
            //define Sql Query
            String strSQL = "SELECT RI.RentalId, RT.MemberId, RI.MovieId, M.Title, RI.Category, M.Status " +
                "FROM RentalItems RI JOIN Rentals RT ON RI.RentalId = RT.RentalId JOIN Movies M ON M.MovieId = RI.MovieId " +
                "WHERE M.MovieId LIKE '%" + movieIdSearch + "%' AND M.Status LIKE 'U' AND RT.MemberId LIKE '%" + 
                memberIdSearch + "%'";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "VID");

            //Close database connection
            conn.Close();

            return ds;
        }

        public void getMovie(int Id)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Movies WHERE MovieId = " + Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.Id = dr.GetInt32(0);
            this.Title = dr.GetString(1);
            this.Genre = dr.GetString(2);
            this.AgeRating = dr.GetString(3);
            this.Year = dr.GetInt32(4);
            this.Category = dr.GetString(5);
            this.Status = dr.GetString(6);
            //close database connection
            conn.Close();
        }

        public void setTitle(String title)
        {
            this.Title = title;
        }

        public void setGenre(String genre)
        {
            this.Genre = genre;
        }

        public void setAgeRating(String ageRating)
        {
            this.AgeRating = ageRating;
        }

        public void setYear(int year)
        {
            this.Year = year;
        }

        public void setCategory(String category)
        {
            this.Category = category;
        }

        public void setStatus(String status)
        {
            this.Status = status;
        }

        public void updateMovie()
        {
            String strSQL = "UPDATE Movies SET Title = '" + this.Title + "',GenreCode = '"
            + this.Genre + "',AgeRatingCode = '" + this.AgeRating + "',Year = " + this.Year +
            ",Category = '" + this.Category + "',Status = '" + this.Status + "' WHERE MovieId = " + this.Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void alterMovieStatus()
        {
            String strSQL = "UPDATE Movies SET Status = '" + this.Status + "' WHERE MovieId = " + this.Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
