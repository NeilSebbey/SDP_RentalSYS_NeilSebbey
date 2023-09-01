using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieSYS.Business;

namespace MovieSYS
{
    public partial class frmAnalyseRev : Form
    {
        frmMainMenu parent;

        public frmAnalyseRev()
        {
            InitializeComponent();
        }

        public frmAnalyseRev(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAnalyseRev_Load(object sender, EventArgs e)
        {
            Utility.loadYears(cboYear);
        }

        private void mnuMain_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Ask user if they wish to exit
            DialogResult dialog1 = (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            
            String strSQL = "SELECT SUM(Cost), to_Char(RentDate,'MM') FROM Rentals " +
                "WHERE RentDate LIKE '%" + cboYear.Text.Substring(2,2) + "' GROUP BY to_Char(RentDate,'MM') ORDER BY to_char(RentDate,'MM')";
            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection("Data Source = localhost/orcl; User Id = C##User1; Password = 123456;");
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            myConn.Close();
            //Array size 12 since there are 12 months in a year
            string[] Months = new string[12];
            decimal[] Revenue = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(Convert.ToInt32(i + 1)); //save each month name in the array
                Revenue[i] = 0; //set Revenue for every month to zero
            }

            //this loop updates the revenue for the months that DO have a value
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Revenue[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            chtAnalyseRev.ChartAreas[0].AxisX.Interval = 1;

            chtAnalyseRev.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtAnalyseRev.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtAnalyseRev.Series[0].LegendText = "Total Revenue in €";
            chtAnalyseRev.Series[0].Points.DataBindXY(Months, Revenue);
            chtAnalyseRev.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            //chtAnalyseRev.Series[0].Points[0] = "XXX";
            chtAnalyseRev.Series[0].Label = "#VALY";
            chtAnalyseRev.Titles.Add("Yearly Revenue");
            chtAnalyseRev.Visible = true;
        }

        public String getMonth(int month)
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


    }
}
