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

namespace MovieSYS
{
    public partial class frmAnalyseCat : Form
    {
        frmMainMenu parent;

        public frmAnalyseCat()
        {
            InitializeComponent();
        }

        public frmAnalyseCat(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAnalyseCat_Load(object sender, EventArgs e)
        {
            Utility.loadCombo(cboCategory, "SELECT * FROM Categories ORDER BY Description");
            cboCategory.SelectedIndex = (cboCategory.Items.Count - 2);
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
            int currentYear = DateTime.Now.Year;

            String strSQL = "SELECT SUM(RT.Cost), to_Char(RT.RentDate,'MM') FROM Rentals RT JOIN RentalItems RI ON RT.RentalId = RI.RentalId " +
                "WHERE RT.RentDate LIKE '%" + currentYear.ToString().Substring(2,2) + "' AND RI.Category = '" + cboCategory.Text.Substring(0, 2) + 
                "' GROUP BY to_Char(RT.RentDate,'MM') ORDER BY to_char(RT.RentDate,'MM')";
            DataTable dt = new DataTable();
            OracleConnection myConn = new OracleConnection(DBConnect.oraDB);
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

            chtAnalyseCat.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtAnalyseCat.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtAnalyseCat.Series[0].LegendText = "Total Revenue in €";
            chtAnalyseCat.Series[0].Points.DataBindXY(Months, Revenue);
            chtAnalyseCat.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            //chtAnalyseRev.Series[0].Points[0] = "XXX";
            chtAnalyseCat.Series[0].Label = "#VALY";
            chtAnalyseCat.Titles.Clear();
            chtAnalyseCat.Titles.Add("Yearly Revenue for Selected Category");
            chtAnalyseCat.Visible = true;
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
