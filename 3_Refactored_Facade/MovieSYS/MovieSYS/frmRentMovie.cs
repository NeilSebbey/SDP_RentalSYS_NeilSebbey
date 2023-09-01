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
    public partial class frmRentMovie : Form
    {
        frmMainMenu parent;
        Member aMember = new Member();
        Movie aMovie = new Movie();

        public frmRentMovie()
        {
            InitializeComponent();
        }

        public frmRentMovie(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmRentMovie_Load(object sender, EventArgs e)
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

        /*****************************************************
        *    Title: How do I make a textbox that only accepts numbers?
        *    Author: Matt Hamilton (edited version by Bitterblue)
        *    Site owner/sponsor: stackoverflow.com
        *    Date: Jan 20 2009
        *    Code version: edited Oct 14 2014 at 15:40
        *    Availability: https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers (Accessed 24 February 2021)
        *    Modified:  Code refactored (Identifiers renamed)
        *****************************************************/
        // Prevents a text box from entering letters (useful for numeric textboxes)
        private void txtMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnMemberId_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "")
            {
                MessageBox.Show("You must enter your member ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // retrieve matching Surname and Forename for specific Member ID
                int MemberId = Convert.ToInt32(txtMemberId.Text);
                aMember.getMember(MemberId);

                txtMemberIdSel.Text = aMember.getId().ToString("0000");
                txtSurname.Text = aMember.getSurname();
                txtForename.Text = aMember.getForename();
                txtAddress.Text = aMember.getStreet();
                txtEmail.Text = aMember.getEmail();
                grdMembers.Visible = false;

                ///Display the Member Details and Movies GroupBox
                grpMember.Visible = true;
                grpMovies.Visible = true;
            }
        }

        private void btnSurnameSearch_Click(object sender, EventArgs e)
        {
            grpMember.Visible = false;
            if (txtSurnameSearch.Text == "")
            {
                MessageBox.Show("You must enter your Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // retrieve matching Members
                grdMembers.DataSource = Member.getMatchingMembers(txtSurnameSearch.Text).Tables["MS"];
                //Display the retrieved records
                grdMembers.Visible = true;
            }
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected member and load on UI for updating
            //create an instance of Member and call a method to instantiate it's instance
            //variables
            int MemberId = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aMember.getMember(MemberId);

            //move values from instance variables to form controls
            txtMemberIdSel.Text = aMember.getId().ToString("0000");
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();
            txtAddress.Text = aMember.getStreet();
            txtEmail.Text = aMember.getEmail();

            //display the Member Details and Movies GroupBox
            grpMember.Visible = true;
            grpMovies.Visible = true;
        }

        private void btnTitleSearch_Click(object sender, EventArgs e)
        {
            // retrieve matching Movies
            grdMovies.DataSource = Movie.getMatchingAvailMovies(txtTitleSearch.Text).Tables["MVS"];
            //Display the retrieved records
            grdMovies.Visible = true;
        }

        private void grdMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected Movie and load on UI for updating
            //create an instance of Movie and call a method to instantiate it's instance
            //variables
            int MovieId = Convert.ToInt32(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aMovie.getMovie(MovieId);

            //move values from instance variables to form controls
            txtMovieId.Text = aMovie.getId().ToString("0000");
            txtTitle.Text = aMovie.getTitle();
            txtGenre.Text = aMovie.getGenre();
            txtAgeRating.Text = aMovie.getAgeRating();
            txtYear.Text = aMovie.getYear().ToString("0000");
            txtCategory.Text = aMovie.getCategory();
            txtStatus.Text = aMovie.getStatus();

            //display the Movie Details
            grpMovie.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grpCheckout.Visible = true;
            txtRentalId.Text = Rental.GetNextId().ToString("0000");
            String costPerMovie = Convert.ToDecimal(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[3].Value).ToString("00.00");

            lstCheckout.Items.Add(txtMovieId.Text + " - " + txtTitle.Text + " - " + txtCategory.Text + " - " + costPerMovie);

            // Update Cart Total
            txtCost.Text = (Convert.ToDecimal(txtCost.Text) + Convert.ToDecimal(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[3].Value)).ToString("000.00");

            // Remove movie from grid
            grdMovies.Rows.RemoveAt(grdMovies.CurrentRow.Index);

            // Count Movies being rented
            txtCheckoutCount.Text = lstCheckout.Items.Count.ToString();

            // Get next movie details and hide Movie Details GroupBox if the Movies grid (grdMovies) is empty
            if (grdMovies.CurrentCell != null)
            {
                int MovieId = Convert.ToInt32(grdMovies.Rows[grdMovies.CurrentCell.RowIndex].Cells[0].Value.ToString());
                aMovie.getMovie(MovieId);

                //move values from instance variables to form controls
                txtMovieId.Text = aMovie.getId().ToString("0000");
                txtTitle.Text = aMovie.getTitle();
                txtGenre.Text = aMovie.getGenre();
                txtAgeRating.Text = aMovie.getAgeRating();
                txtYear.Text = aMovie.getYear().ToString("0000");
                txtCategory.Text = aMovie.getCategory();
                txtStatus.Text = aMovie.getStatus();
            }
            else
            {
                grpMovie.Visible = false;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lstCheckout);
            selectedItems = lstCheckout.SelectedItems;
            String checkoutItem = lstCheckout.SelectedItem.ToString();
            String coutItemPrice = checkoutItem.Substring(checkoutItem.Length - 5);
            txtCost.Text = (Convert.ToDecimal(txtCost.Text) - Convert.ToDecimal(coutItemPrice)).ToString("000.00");

            for (int i = selectedItems.Count - 1; i >= 0; i--)
                lstCheckout.Items.Remove(selectedItems[i]);
            txtCheckoutCount.Text = lstCheckout.Items.Count.ToString();

            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            // Create instance of a rental
            Rental aRental = new Rental(Convert.ToInt32(txtRentalId.Text), Convert.ToInt32(txtMemberIdSel.Text), String.Format("{0:dd-MMM-yy}", DateTime.Now),
                String.Format("{0:dd-MMM-yy}", DateTime.Now.AddDays(1)), Convert.ToDecimal(txtCost.Text));

            // Insert record into Rentals Table
            aRental.RentMovie();




            // Create instance of a RentalItem
            RentalItem aRentalItem = new RentalItem();

            // Create instance of a movie
            Movie aMovie = new Movie();



            // Insert record into RentalItems table for each item in lstCheckout
            lstCheckout.SelectedIndex = -1;
            for (int i = 0; i <= lstCheckout.Items.Count-1; i++)
            {
                lstCheckout.SelectedIndex++;
                int MovieId = Convert.ToInt32(lstCheckout.Text.Substring(0, 4));
                aMovie.getMovie(MovieId);

                aRentalItem.setRentalId(Convert.ToInt32(txtRentalId.Text));
                aRentalItem.setMovieId(Convert.ToInt32(lstCheckout.Text.Substring(0,4)));
                aRentalItem.setCategory(aMovie.getCategory());
                aRentalItem.setReturnedDate("");
                aRentalItem.setReturnedByMemId(0);
                aRentalItem.setFine(0);

                aRentalItem.rentedMovie();

                // Set movie status to U
                aMovie.setStatus("U");
                aMovie.alterMovieStatus();
                
            }


            //display confirmation message
            MessageBox.Show("Thank you for renting movies from us.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reset the UI
            grpCheckout.Visible = false;
            grpMovie.Visible = false;
            grpMovies.Visible = false;
            grpMember.Visible = false;
            grdMembers.Visible = false;
        }

    }
}
