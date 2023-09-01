using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS
{
    class Member
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

            //Define SQL query to retrieve the last Id assigned
            String strSQL = "SELECT MAX(MemberId) FROM Members";
            //Connect to the database
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //define an Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            //execute the command using an Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            //An aggregate function ALWAYS returns one record
            //which contains the largest MemberId in the table OR NULL
            if (dr.Read().Equals(null))
                nextId = 1;
            else
                nextId = dr.GetInt32(0) + 1;
            conn.Close();
            return nextId;
        }

        public void addMember()
        {
            //define Sql Query
            String strSQL = "INSERT INTO Members VALUES (" + this.Id + ",'" +
            this.Surname + "','" + this.Forename + "'," + this.Phone + ",'" +
            this.Street + "','" + this.Town + "','" + this.County + "','" +
            this.Eircode + "','" + this.Email + "')";
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataSet getMatchingMembers(String surnameSearch)
        {
            //define Sql Query
            String strSQL = "SELECT MemberId, Surname, Forename, Phone, Email FROM Members WHERE Surname LIKE '%" +
                surnameSearch + "%' ORDER BY MemberId";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();

            da.Fill(ds, "MS");

            //Close database connection
            conn.Close();

            return ds;
        }

        public void getMember(int Id)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Members WHERE MemberId = " + Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();
            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.Id = dr.GetInt32(0);
            this.Surname = dr.GetString(1);
            this.Forename = dr.GetString(2);
            this.Phone = dr.GetInt32(3);
            this.Street = dr.GetString(4);
            this.Town = dr.GetString(5);
            this.County = dr.GetString(6);
            this.Eircode = dr.GetString(7);
            this.Email = dr.GetString(8);
            //close database connection
            conn.Close();
        }

        public void updateMember()
        {
            String strSQL = "UPDATE Members SET Surname = '" + this.Surname + "',Forename = '"
            + this.Forename + "',Phone = " + this.Phone + ",Street = '" + this.Street +
            "',Town = '" + this.Town + "',County = '" + this.County + "',Eircode = '" +
            this.Eircode + "', Email = '" + this.Email + "' WHERE MemberId = " + this.Id;
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();
            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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
