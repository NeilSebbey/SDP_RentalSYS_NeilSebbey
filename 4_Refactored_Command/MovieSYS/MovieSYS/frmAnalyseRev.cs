using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using MovieSYS.Business;
using MovieSYS.Data;

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
            
            string rentDate = cboYear.Text.Substring(2,2);

            //Call into Rental class from Business Logic
            DataTable dt = Rental.GetRevenueAnalysis(rentDate);

            //Array size 12 since there are 12 months in a year
            string[] Months = new string[12];
            decimal[] Revenue = new decimal[12];

            for (int i = 0; i < 12; i++)
            {
                Months[i] = Utility.GetMonth(Convert.ToInt32(i + 1)); //save each month name in the array
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
    }
}
