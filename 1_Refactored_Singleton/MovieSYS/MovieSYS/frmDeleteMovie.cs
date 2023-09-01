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
    public partial class frmDeleteMovie : Form
    {
        frmMainMenu parent;
        Movie aMovie = new Movie();
        public frmDeleteMovie()
        {
            InitializeComponent();
        }

        public frmDeleteMovie(frmMainMenu Parent)
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
            grdMovies.DataSource = Movie.getMatchingMoviesAlter(txtSearch.Text).Tables["MVS"];
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
            //display the widget for updating
            grpMovie.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //Ask user if they wish to delete this movie
            DialogResult delete1 = (MessageBox.Show("Are you sure do you want to delete this movie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (delete1 == DialogResult.Yes)
            {
                if (txtStatus.Text.Equals("U"))
                {
                    MessageBox.Show("Unable to delete this movie, as it has been rented by a member (status U)", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    aMovie.setStatus("D");
                    //invoke the alterMovieStatus() method
                    aMovie.alterMovieStatus();
                    //display confirmation message
                    MessageBox.Show("Movie " + txtId.Text + " has been deleted", "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Reset UI
                    grpMovie.Visible = false;
                    grdMovies.Visible = false;
                    txtSearch.Clear();
                    txtSearch.Focus();
                }
            }
        }

    }
}
