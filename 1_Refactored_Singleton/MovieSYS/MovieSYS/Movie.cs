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

            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "SELECT MAX(MovieId) FROM Movies";

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

        public void addMovie()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "INSERT INTO Movies VALUES (" + this.Id + ",'" +
            this.Title + "','" + this.Genre + "','" + this.AgeRating + "'," +
            this.Year + ",'" + this.Category + "','" + this.Status + "')";

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public static DataSet getMatchingMovies(String titleSearch)
        {
            //Define Source Table for Search
            String srcTbl = "MVS";

            //define Sql Query
            String strSQL = "SELECT MovieId, Title, Status FROM Movies WHERE Title LIKE '" +
                titleSearch + "%' AND (Status='A' OR Status='U') ORDER BY MovieId";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL,srcTbl);
        }

        public static DataSet getMatchingMoviesAlter(String titleSearch)
        {
            //Define Source Table for Search
            String srcTbl = "MVS";

            //define Sql Query
            String strSQL = "SELECT MovieId, Title FROM Movies WHERE Title LIKE '" +
                titleSearch + "%' AND Status='A' ORDER BY MovieId";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataSet getMatchingAvailMovies(String titleSearch)
        {
            //Define Source Table for Search
            String srcTbl = "MVS";

            //define Sql Query
            String strSQL = "SELECT MovieId, Title, Category, Rate FROM Movies M JOIN Categories C ON M.Category = C.CategoryCode " + 
                "WHERE Title LIKE '%" + titleSearch + "%' AND STATUS='A' ORDER BY MovieId";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public static DataSet getMatchingRentedMovies(String movieIdSearch, String memberIdSearch)
        {
            //Define Source Table for Search
            String srcTbl = "VID";

            //define Sql Query
            String strSQL = "SELECT RI.RentalId, RT.MemberId, RI.MovieId, M.Title, RI.Category, M.Status " +
                "FROM RentalItems RI JOIN Rentals RT ON RI.RentalId = RT.RentalId JOIN Movies M ON M.MovieId = RI.MovieId " +
                "WHERE M.MovieId LIKE '%" + movieIdSearch + "%' AND M.Status LIKE 'U' AND RT.MemberId LIKE '%" + 
                memberIdSearch + "%'";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public void getMovie(int Id)
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "SELECT * FROM Movies WHERE MovieId = " + Id;

            //Declare an Oracle Connection, then connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                dr.Read();
                //read the record returned in dr and use values to instantiate the object
                this.Id = dr.GetInt32(0);
                this.Title = dr.GetString(1);
                this.Genre = dr.GetString(2);
                this.AgeRating = dr.GetString(3);
                this.Year = dr.GetInt32(4);
                this.Category = dr.GetString(5);
                this.Status = dr.GetString(6);
            }
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
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "UPDATE Movies SET Title = '" + this.Title + "',GenreCode = '"
            + this.Genre + "',AgeRatingCode = '" + this.AgeRating + "',Year = " + this.Year +
            ",Category = '" + this.Category + "',Status = '" + this.Status + "' WHERE MovieId = " + this.Id;

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public void alterMovieStatus()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "UPDATE Movies SET Status = '" + this.Status + "' WHERE MovieId = " + this.Id;

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }


    }
}
