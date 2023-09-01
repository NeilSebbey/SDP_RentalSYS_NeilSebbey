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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        // Members
        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember nextForm = new frmAddMember(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            frmUpdateMember nextForm = new frmUpdateMember(this);
            this.Hide();
            nextForm.Show();
        }

        // Movies
        private void mnuAddMovie_Click(object sender, EventArgs e)
        {
            frmAddMovie nextForm = new frmAddMovie(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateMovie_Click(object sender, EventArgs e)
        {
            frmUpdateMovie nextForm = new frmUpdateMovie(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuDeleteMovie_Click(object sender, EventArgs e)
        {
            frmDeleteMovie nextForm = new frmDeleteMovie(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuQueryMovie_Click(object sender, EventArgs e)
        {
            frmQueryMovie nextForm = new frmQueryMovie(this);
            this.Hide();
            nextForm.Show();
        }

        // Rentals
        private void mnuRentMovie_Click(object sender, EventArgs e)
        {
            frmRentMovie nextForm = new frmRentMovie(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuReturnMovie_Click(object sender, EventArgs e)
        {
            frmReturnMovie nextForm = new frmReturnMovie(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuQueryRentals_Click(object sender, EventArgs e)
        {
            frmQueryRentals nextForm = new frmQueryRentals(this);
            this.Hide();
            nextForm.Show();
        }

        // Admin
        private void mnuAnalyseRev_Click(object sender, EventArgs e)
        {
            frmAnalyseRev nextForm = new frmAnalyseRev(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAnalyseCat_Click(object sender, EventArgs e)
        {
            frmAnalyseCat nextForm = new frmAnalyseCat(this);
            this.Hide();
            nextForm.Show();
        }

        // Exit
        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Ask user if they wish to exit
            DialogResult dialog1 = (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if (dialog1 == DialogResult.Yes)
                Application.Exit();
        }

    }
}
