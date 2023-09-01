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
    public partial class frmUpdateMovie : Form
    {
        frmMainMenu parent;
        Movie aMovie = new Movie();
        public frmUpdateMovie()
        {
            InitializeComponent();
        }

        public frmUpdateMovie(frmMainMenu Parent)
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
            Utility.loadCombo(cboGenre, "SELECT * FROM Genres ORDER BY Name");
            Utility.loadCombo(cboAgeRating, "SELECT * FROM AgeRating");
            Utility.loadCombo(cboCategory, "SELECT * FROM Categories ORDER BY Description");

            //retrieve FULL details for selected Movie and load on UI for updating
            //create an instance of Movie and call a method to instantiate it's instance
            //variables
            int Id = Convert.ToInt32(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aMovie.getMovie(Id);

            //Genre ComboBox data
            cboGenre.SelectedIndex = 0;
            while (!aMovie.getGenre().Equals(cboGenre.Text.Substring(0, 2)))
            {
                cboGenre.SelectedIndex++;
            }

            //AgeRating ComboBox data
            cboAgeRating.SelectedIndex = 0;
            while (!aMovie.getAgeRating().Equals(cboAgeRating.Text.Substring(0, 2)))
            {
                cboAgeRating.SelectedIndex++;
            }

            //Categories ComboBox data
            cboCategory.SelectedIndex = 0;
            while (!aMovie.getCategory().Equals(cboCategory.Text.Substring(0, 2)))
            {
                cboCategory.SelectedIndex++;

            }




            //move values from instance variables to form controls
            txtId.Text = aMovie.getId().ToString("0000");
            txtTitle.Text = aMovie.getTitle();

            //Loop through cboGenre and set selectedIndex to item that matches the current genre value
            cboGenre.SelectedIndex = 0;
            while (!cboGenre.Text.Substring(0, 2).Equals(aMovie.getGenre()))
            {
                cboGenre.SelectedIndex++;
            }

            //Loop through cboAgeRating and set selectedIndex to item that matches the current genre value
            cboAgeRating.SelectedIndex = 0;
            while (!cboAgeRating.Text.Substring(0, 2).Equals(aMovie.getAgeRating()))
            {
                cboAgeRating.SelectedIndex++;
            }

            //Loop through cboCategory and set selectedIndex to item that matches the current genre value
            cboCategory.SelectedIndex = 0;
            while (!cboCategory.Text.Substring(0, 2).Equals(aMovie.getCategory()))
            {
                cboCategory.SelectedIndex++;
            }


            /*****************************************************
            *    Title: How to convert int to DateTime
            *    Author: Marcel B (edited version by Bakudan)
            *    Site owner/sponsor: stackoverflow.com
            *    Date: Feb 25 2016
            *    Code version: edited Feb 26 2016 at 11:06
            *    Availability: https://stackoverflow.com/questions/35623482/how-to-convert-int-to-datetime/35623564 (Accessed 02 March 2021)
            *    Modified:  Code refactored (Identifiers renamed)
            *****************************************************/
            // Convert Year in numeric (Int) data type into DateTime data type - refactored code
            int year = aMovie.getYear(), month = 1, day = 1, hour = 0, minute = 0;
            DateTime yearDT = new DateTime(year, month, day, hour, minute, 0);
            //   end of refactored code
            dtpYear.Value = yearDT;

            cboCategory.Text = aMovie.getCategory();
            txtStatus.Text = aMovie.getStatus();

            //Status Description in txtStatusDesc Textbox
            if(txtStatus.Text.Equals("A"))
            {
                txtStatusDesc.Text = "Available";
            }
            if (txtStatus.Text.Equals("U"))
            {
                txtStatusDesc.Text = "Unavailable";
            }
            if (txtStatus.Text.Equals("D"))
            {
                txtStatusDesc.Text = "Deleted";
            }

            //display the Movie for updating
            grpMovie.Visible = true;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("U") || txtStatus.Text.Equals("D"))
            {
                MessageBox.Show("Unable to update movie details, as it has been rented by a member (status U) or deleted (status D)", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //validate the data
                //Update data in Movie File
                //instantiate an instance of an Movie with values in form controls
                aMovie.setTitle(txtTitle.Text);
                aMovie.setGenre(cboGenre.Text.Substring(0, 2));
                aMovie.setAgeRating(cboAgeRating.Text.Substring(0, 2));
                aMovie.setYear(Convert.ToInt32(String.Format("{0:yyyy}", dtpYear.Value)));
                aMovie.setCategory(cboCategory.Text.Substring(0, 2));
                aMovie.setStatus(txtStatus.Text);

                //invoke the updateMovie() method
                aMovie.updateMovie();

                //display confirmation message
                MessageBox.Show("Movie " + txtId.Text + " Updated", "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Reset UI
                grpMovie.Visible = false;
                grdMovies.Visible = false;
                txtSearch.Clear();
                txtSearch.Focus();
            } 
        }

        
        
        public void loadCategories()
        {
            // Load Categories into UI from A-Z into the Combo box
            DataSet ds = Utility.getCategories();
            for (int i = 0; i < ds.Tables["CTS"].Rows.Count; i++)
                cboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                " - " + ds.Tables[0].Rows[i][1].ToString());
        }

        
    }
}
