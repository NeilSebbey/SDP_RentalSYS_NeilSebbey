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
    public partial class frmReturnMovie : Form
    {
        frmMainMenu parent;
        Member aMember = new Member();
        Movie aMovie = new Movie();
        Rental aRental = new Rental();
        RentalItem aRentalItem = new RentalItem();

        public frmReturnMovie()
        {
            InitializeComponent();
        }

        public frmReturnMovie(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmReturnMovie_Load(object sender, EventArgs e)
        {

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

        // Prevents a text box from entering letters (useful for numeric textboxes)
        private void txtRentalId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnRentalId_Click(object sender, EventArgs e)
        {
            grpRental.Visible = false;
            if (txtRentalId.Text == "")
            {
                MessageBox.Show("You must enter your Rental ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // retrieve matching Rentals
                grdRentals.DataSource = Rental.getMatchingRentals(txtRentalId.Text).Tables["RID"];
                //Display the retrieved records
                grdRentals.Visible = true;
            }
        }

        private void grdRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected member and load on UI for updating
            //create an instance of Member and call a method to instantiate it's instance
            //variables
            //int RentalId = Convert.ToInt32(grdRentals.Rows[grdRentals.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aRental.getRental(Convert.ToInt32(txtRentalId.Text));

            //move values from instance variables to form controls
            txtRentalIdSel.Text = aRental.getId().ToString("0000");
            txtMemberId.Text = aRental.getMemberId().ToString("0000");
            txtRentalDate.Text = aRental.getRentalDate().ToString();
            txtDueDate.Text = aRental.getDueDate().ToString();
            txtCost.Text = Convert.ToDecimal(aRental.getCost()).ToString("000.00");

            // int MemberIdSel = Convert.ToInt32(txtMemberIdSel.Text);
            aMember.getMember(aRental.getMemberId());
            txtMemberIdSel.Text = aMember.getId().ToString("0000");
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();

            //display the Rental Details and Movies GroupBox
            grpRental.Visible = true;
            grpMember.Visible = true;
            grpMovies.Visible = true;
        }

        // Number-only Text Box (same function as that of the MemberId search box in Rent Movie)
        private void txtMovieId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnMovieId_Click(object sender, EventArgs e)
        {
            // retrieve matching Movies
            grdMovies.DataSource = Movie.getMatchingRentedMovies(Convert.ToInt32(txtMovieId.Text).ToString(), Convert.ToInt32(txtMemberId.Text).ToString()).Tables["VID"];
            //Display the retrieved records
            grdMovies.Visible = true;
        }

        private void grdMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected Movie and load on UI for updating
            //create an instance of Movie and call a method to instantiate it's instance
            //variables
            int MovieId = Convert.ToInt32(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[2].Value.ToString());
            aMovie.getMovie(MovieId);

            //move values from instance variables to form controls
            txtMovieIdSel.Text = aMovie.getId().ToString("0000");
            txtTitle.Text = aMovie.getTitle();
            txtGenre.Text = aMovie.getGenre();
            txtAgeRating.Text = aMovie.getAgeRating();
            txtYear.Text = aMovie.getYear().ToString("0000");
            txtCategory.Text = aMovie.getCategory();
            txtStatus.Text = aMovie.getStatus();

            //display the Movie Details
            grpMovie.Visible = true;
            lblReturnDate.Visible = true;
            dtpReturnDate.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Ask user if they wish to return this movie
            DialogResult return1 = (MessageBox.Show("Are you sure do you want to return this movie?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (return1 == DialogResult.Yes)
            {
                int MovieId = Convert.ToInt32(txtMovieIdSel.Text);
                aMovie.getMovie(MovieId);
                aMovie.setStatus("A");
                //invoke the alterMovieStatus() method
                aMovie.alterMovieStatus();

                aRentalItem.setRentalId(Convert.ToInt32(txtRentalIdSel.Text));
                aRentalItem.setMovieId(Convert.ToInt32(txtMovieIdSel.Text));
                aRentalItem.setCategory(txtCategory.Text);
                aRentalItem.setReturnedDate(String.Format("{0:dd-MMM-yy}", DateTime.Now));
                aRentalItem.setReturnedByMemId(Convert.ToInt32(txtMemberIdSel.Text));
                aRentalItem.setFine(0);

                aRentalItem.returnedMovie();

                //display confirmation message
                MessageBox.Show("Thank you for returning movies to us, " + txtForename.Text, "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                //Reset UI
                lblReturnDate.Visible = false;
                dtpReturnDate.Visible = false;
                grpMovie.Visible = false;
                grdMovies.Visible = false;
                grpRental.Visible = false;
                grdRentals.Visible = false;
                grpMember.Visible = false;
                grpMovies.Visible = false;
                txtRentalId.Clear();
                txtRentalId.Focus();
            }
        }

    }
}
