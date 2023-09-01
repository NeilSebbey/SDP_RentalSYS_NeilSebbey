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
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS
{
    public partial class frmAddMember : Form
    {
        frmMainMenu parent;
        
        public frmAddMember()
        {
            InitializeComponent();
        }

        public frmAddMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {

            //Get Member Id
            txtId.Text = Member.getNextId().ToString("0000");

            loadCounties();
        }

        public void loadCounties()
        {
            // Load County Code into UI from A-Z into the Combo box
            DataSet ds = Utility.getCounties();
            for (int i = 0; i < ds.Tables["CS"].Rows.Count; i++)
                cboCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                " - " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate the data entered
            /// If fields are blank
            if (txtSurname.Text == "" || txtForename.Text == "" || txtPhone.Text == "" ||
                txtStreet.Text == "" || txtTown.Text == "" || cboCounty.Text == "" ||
                txtEircode.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("You must enter one of the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                /*****************************************************
                *    Title: Allow only alphabetic name in text box in c#
                *    Author: user3002030
                *    Site owner/sponsor: stackoverflow.com
                *    Date: Jun 19 2015
                *    Code version: Jun 19 2015 at 11:53
                *    Availability: https://stackoverflow.com/questions/30937396/allow-only-alphabetic-name-in-text-box-in-c-sharp (Accessed 17 March 2021)
                *    Modified:  Code refactored (Identifiers renamed)
                *****************************************************/
                /// If Surname and/or Forename starts with a number
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSurname.Text, "^[a-zA-Z ]") ||
                   !System.Text.RegularExpressions.Regex.IsMatch(txtForename.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("You must enter alphabetical characters on the Surname and/or Forename field(s)", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSurname.Text.Remove(txtSurname.Text.Length - 1);
                    txtForename.Text.Remove(txtForename.Text.Length - 1);
                }
                else
                {
                    //add the team to the database
                    Member aMember = new Member(Convert.ToInt32(txtId.Text),
                    txtSurname.Text, txtForename.Text, Convert.ToInt32(txtPhone.Text),
                    txtStreet.Text, txtTown.Text, cboCounty.Text.Substring(0, 2), txtEircode.Text,
                    txtEmail.Text);
                    aMember.addMember();

                    //display confirmation message
                    MessageBox.Show(txtSurname.Text + ", " + txtForename.Text + " - Member Id " + txtId.Text + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //reset the UI
                    txtSurname.Clear();
                    txtForename.Clear();
                    txtPhone.Clear();
                    txtStreet.Clear();
                    txtTown.Clear();
                    txtEircode.Clear();
                    txtEmail.Clear();
                    cboCounty.SelectedIndex = -1;
                    txtId.Text = Member.getNextId().ToString("0000");
                    txtSurname.Focus();
                }
            }
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
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
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
    }
}
