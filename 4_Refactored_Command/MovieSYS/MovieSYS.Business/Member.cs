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
        private string Surname;
        private string Forename;
        private int Phone;
        private string Street;
        private string Town;
        private string County;
        private string Eircode;
        private string Email;

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

        public Member(int Id, string Surname, string Forename, int Phone, string Street, string Town, string County, string Eircode, string Email)
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

        public string getSurname()
        {
            return this.Surname;
        }

        public string getForename()
        {
            return this.Forename;
        }

        public int getPhone()
        {
            return this.Phone;
        }

        public string getStreet()
        {
            return this.Street;
        }

        public string getTown()
        {
            return this.Town;
        }

        public string getCounty()
        {
            return this.County;
        }

        public string getEircode()
        {
            return this.Eircode;
        }

        public string getEmail()
        {
            return this.Email;
        }
        public static int getNextId()
        {
            
            int nextId = 0;

            DBConnect dbConn = DBConnect.Instance;

            //Define SQL query to retrieve the last Id assigned
            string strSQL = "SELECT MAX(MemberId) FROM Members";

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
            string strSQL = "INSERT INTO Members VALUES (" + this.Id + ",'" +
            this.Surname + "','" + this.Forename + "'," + this.Phone + ",'" +
            this.Street + "','" + this.Town + "','" + this.County + "','" +
            this.Eircode + "','" + this.Email + "')";

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public static DataSet getMatchingMembers(string surnameSearch)
        {
            return Utility.QuerySearchCommand("MS", "SELECT MemberId, Surname, Forename, Phone, Email FROM Members WHERE Surname LIKE '%" +
                surnameSearch + "%' ORDER BY MemberId");
        }

        public void getMember(int Id)
        {
            DBConnect dbConn = DBConnect.Instance;

            //define Sql Query
            string strSQL = "SELECT * FROM Members WHERE MemberId = " + Id;

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
            string strSQL = "UPDATE Members SET Surname = '" + this.Surname + "',Forename = '"
            + this.Forename + "',Phone = " + this.Phone + ",Street = '" + this.Street +
            "',Town = '" + this.Town + "',County = '" + this.County + "',Eircode = '" +
            this.Eircode + "', Email = '" + this.Email + "' WHERE MemberId = " + this.Id;

            //declare an Oracle Command to execute
            dbConn.ExecuteNonQuery(strSQL);
        }

        public void setSurname(string surname)
        {
            this.Surname = surname;
        }

        public void setForename(string forename)
        {
            this.Forename = forename;
        }

        public void setPhone(int phone)
        {
            this.Phone = phone;
        }

        public void setStreet(string street)
        {
            this.Street = street;
        }

        public void setTown(string town)
        {
            this.Town = town;
        }

        public void setCounty(string county)
        {
            this.County = county;
        }

        public void setEircode(string eircode)
        {
            this.Eircode = eircode;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }
    }
}
