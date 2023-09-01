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
    public partial class frmAddMovie : Form
    {
        frmMainMenu parent;
        public frmAddMovie()
        {
            InitializeComponent();
        }

        public frmAddMovie(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            //Get Movie Id
            txtId.Text = Movie.getNextId().ToString("0000");

            loadGenres();
            loadAgeRating();
            loadCategories();
            //loadStatus();
            txtStatus.Text = "A";
            if (txtStatus.Text.Equals("A"))
            {
                txtStatusDesc.Text = "Available";
            }
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

        public void loadGenres()
        {
            // Load Genres into UI from A-Z into the Combo box
            DataSet ds = Utility.getGenres();
            for (int i = 0; i < ds.Tables["GS"].Rows.Count; i++)
                cboGenre.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                " - " + ds.Tables[0].Rows[i][1].ToString());
        }
        public void loadAgeRating()
        {
            // Load Age Ratings into UI from A-Z into the Combo box
            DataSet ds = Utility.getAgeRating();
            for (int i = 0; i < ds.Tables["ARS"].Rows.Count; i++)
                cboAgeRating.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                "  - " + ds.Tables[0].Rows[i][1].ToString());
        }
        public void loadCategories()
        {
            // Load Categories into UI from A-Z into the Combo box
            DataSet ds = Utility.getCategories();
            for (int i = 0; i < ds.Tables["CTS"].Rows.Count; i++)
                cboCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                " - " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate the data entered
            if (txtTitle.Text == "" || cboGenre.Text == "" || cboAgeRating.Text == "" ||
                cboCategory.Text == "" || txtStatus.Text == "")
            {
                MessageBox.Show("You must enter one of the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //add the movie to the database
                Movie aMovie = new Movie(Convert.ToInt32(txtId.Text),
                txtTitle.Text, cboGenre.Text.Substring(0,2), cboAgeRating.Text.Substring(0, 2),
                Convert.ToInt32(String.Format("{0:yyyy}", dtpYear.Value)), cboCategory.Text.Substring(0, 2), txtStatus.Text);
                aMovie.addMovie();

                //display confirmation message
                MessageBox.Show(txtTitle.Text + ", " + cboGenre.Text + " - Movie Id " + txtId.Text + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //reset the UI
                txtId.Clear();
                txtId.Text = Movie.getNextId().ToString("0000");
                txtTitle.Clear();
                cboGenre.SelectedIndex = -1;
                cboAgeRating.SelectedIndex = -1;
                dtpYear.Value = System.DateTime.Today;
                cboCategory.SelectedIndex = -1;
                txtStatus.Text = "A";
                if (txtStatus.Text.Equals("A"))
                {
                    txtStatusDesc.Text = "Available";
                }

                txtTitle.Focus();
            }
        }

    }
}
