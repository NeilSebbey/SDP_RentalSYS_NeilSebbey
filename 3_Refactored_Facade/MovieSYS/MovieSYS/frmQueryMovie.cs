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
    public partial class frmQueryMovie : Form
    {
        frmMainMenu parent;
        Movie aMovie = new Movie();
        public frmQueryMovie()
        {
            InitializeComponent();
        }

        public frmQueryMovie(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // retrieve matching Movies
            grdMovies.DataSource = Movie.getMatchingMovies(txtSearch.Text).Tables["MVS"];
            //Display the retrieved records
            grdMovies.Visible = true;
        }

        private void grdMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected widget and load on UI for updating
            //create an instance of Widget and call a method to instantiate it's instance
            //variables
            int Id = Convert.ToInt32(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aMovie.getMovie(Id);

            //move values from instance variables to form controls
            txtId.Text = aMovie.getId().ToString("0000");
            txtTitle.Text = aMovie.getTitle();
            txtGenre.Text = aMovie.getGenre();
            txtAgeRating.Text = aMovie.getAgeRating();
            txtYear.Text = aMovie.getYear().ToString("0000");
            txtCategory.Text = aMovie.getCategory();
            txtStatus.Text = aMovie.getStatus();

            //Status Description in txtStatusDesc Textbox
            string fullStatusDesc = Utility.GetFullStatusDescription(txtStatus.Text);
            if (fullStatusDesc != null)
            {
                txtStatusDesc.Text = fullStatusDesc;
            }

            //display the widget for movie details
            grpMovie.Visible = true;
        }
    }
}
