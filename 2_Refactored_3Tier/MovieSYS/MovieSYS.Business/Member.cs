using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieSYS.Data;
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS.Business
{
    public class Member
    {
        private int Id;
        private String Surname;
        private String Forename;
        private int Phone;
        private String Street;
        private String Town;
        private String County;
        private String Eircode;
        private String Email;

        //Constructor
        public Member()
        {
            Id = 0;
            Surname = "";
            Forename = "";
            Phone = 0;
            Street = "";
            Town = "";
            County = "";
            Eircode = "";
            Email = "";
        }

        public Member(int Id, String Surname, String Forename, int Phone, String Street, String Town, String County, String Eircode, String Email)
        {
            this.Id = Id;
            this.Surname = Surname;
            this.Forename = Forename;
            this.Phone = Phone;
            this.Street = Street;
            this.Town = Town;
            this.County = County;
            this.Eircode = Eircode;
            this.Email = Email;
        }

        public int getId()
        {
            return this.Id;
        }

        public String getSurname()
        {
            return this.Surname;
        }

        public String getForename()
        {
            return this.Forename;
        }

        public int getPhone()
        {
            return this.Phone;
        }

        public String getStreet()
        {
            return this.Street;
        }

        public String getTown()
        {
            return this.Town;
        }

        public String getCounty()
        {
            return this.County;
        }

        public String getEircode()
        {
            return this.Eircode;
        }

        public String getEmail()
        {
            return this.Email;
        }
        public static int getNextId()
        {
            
            int nextId = 0;

            DBConnect dbConn = DBConnect.Instance;

            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT MAX(MemberId) FROM Members";

            //Declare an Oracle Connection, execute the command, and connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                //An aggregate function ALWAYS returns one record
                //which contains the largest MemberId in the table OR NULL
                if (dr.Read().Equals(null))
                    nextId = 1;
                else
                    nextId = dr.GetInt32(0) + 1;
                return nextId;
            }
        }

        public void addMember()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "INSERT INTO Members VALUES (" + this.Id + ",'" +
            this.Surname + "','" + this.Forename + "'," + this.Phone + ",'" +
            this.Street + "','" + this.Town + "','" + this.County + "','" +
            this.Eircode + "','" + this.Email + "')";

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public static DataSet getMatchingMembers(String surnameSearch)
        {
            //Define Source Table for Search
            String srcTbl = "MS";

            //define Sql Query
            String strSQL = "SELECT MemberId, Surname, Forename, Phone, Email FROM Members WHERE Surname LIKE '%" +
                surnameSearch + "%' ORDER BY MemberId";

            //Declare an Oracle Connection
            DBConnect dbConn = DBConnect.Instance;
            return dbConn.ExecuteSearch(strSQL, srcTbl);
        }

        public void getMember(int Id)
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "SELECT * FROM Members WHERE MemberId = " + Id;

            //Declare an Oracle Connection, then connection will close
            using (OracleDataReader dr = dbConn.ExecuteReader(strSQL))
            {
                dr.Read();
                //read the record returned in dr and use values to instantiate the object
                this.Id = dr.GetInt32(0);
                this.Surname = dr.GetString(1);
                this.Forename = dr.GetString(2);
                this.Phone = dr.GetInt32(3);
                this.Street = dr.GetString(4);
                this.Town = dr.GetString(5);
                this.County = dr.GetString(6);
                this.Eircode = dr.GetString(7);
                this.Email = dr.GetString(8);
            }


        }

        public void updateMember()
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            String strSQL = "UPDATE Members SET Surname = '" + this.Surname + "',Forename = '"
            + this.Forename + "',Phone = " + this.Phone + ",Street = '" + this.Street +
            "',Town = '" + this.Town + "',County = '" + this.County + "',Eircode = '" +
            this.Eircode + "', Email = '" + this.Email + "' WHERE MemberId = " + this.Id;

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public void setSurname(String surname)
        {
            this.Surname = surname;
        }

        public void setForename(String forename)
        {
            this.Forename = forename;
        }

        public void setPhone(int phone)
        {
            this.Phone = phone;
        }

        public void setStreet(String street)
        {
            this.Street = street;
        }

        public void setTown(String town)
        {
            this.Town = town;
        }

        public void setCounty(String county)
        {
            this.County = county;
        }

        public void setEircode(String eircode)
        {
            this.Eircode = eircode;
        }

        public void setEmail(String email)
        {
            this.Email = email;
        }
    }
}
