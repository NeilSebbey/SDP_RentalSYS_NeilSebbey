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
    public partial class frmQueryRentals : Form
    {
        frmMainMenu parent;
        Member aMember = new Member();
        Movie aMovie = new Movie();
        Rental aRental = new Rental();

        public frmQueryRentals()
        {
            InitializeComponent();
        }

        public frmQueryRentals(frmMainMenu Parent)
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
            grpMember.Visible = false;
            grpMovies.Visible = false;
            grdMovies.Visible = false;
            if (txtRentalId.Text == "")
            {
                MessageBox.Show("You must enter your Rental ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // retrieve matching Rentals
                grdRentals.DataSource = Rental.GetMatchingRentals(txtRentalId.Text).Tables["RID"];
                //Display the retrieved records
                grdRentals.Visible = true;
            }
        }

        private void grdRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve FULL details for selected member and load on UI for updating
            //create an instance of Member and call a method to instantiate it's instance
            //variables
            // int RentalId = Convert.ToInt32(grdRentals.Rows[grdRentals.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aRental.GetRental(Convert.ToInt32(txtRentalId.Text));

            //move values from instance variables to form controls
            txtRentalIdSel.Text = aRental.GetId().ToString("0000");
            txtMemberId.Text = aRental.GetMemberId().ToString("0000");
            txtRentalDate.Text = aRental.GetRentalDate().ToString();
            txtDueDate.Text = aRental.GetDueDate().ToString();
            txtCost.Text = Convert.ToDecimal(aRental.GetCost()).ToString("000.00");

            // int MemberIdSel = Convert.ToInt32(grdRentals.Rows[grdRentals.CurrentCell.RowIndex].Cells[1].Value.ToString());
            aMember.getMember(aRental.GetMemberId());
            txtMemberIdSel.Text = aMember.getId().ToString("0000");
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();

            // display the Rental Details
            grpRental.Visible = true;
            grpMember.Visible = true;
            

            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // display Movies GroupBox
            grpMovies.Visible = true;

            // display list of movies within the selected Rental ID
            grdMovies.DataSource = RentalItem.getMembersRentalItems(Convert.ToInt32(txtRentalIdSel.Text).ToString(), Convert.ToInt32(txtMemberIdSel.Text).ToString()).Tables["RTD"];
            // Display the retrieved records
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

        
    }
}
