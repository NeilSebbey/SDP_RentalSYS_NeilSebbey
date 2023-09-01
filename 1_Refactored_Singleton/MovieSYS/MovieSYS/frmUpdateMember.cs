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
    public partial class frmUpdateMember : Form
    {
        frmMainMenu parent;
        Member aMember = new Member();
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public frmUpdateMember(frmMainMenu Parent)
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
            // retrieve matching Members
            grdMembers.DataSource = Member.getMatchingMembers(txtSearch.Text).Tables["MS"];
            //Display the retrieved records
            grdMembers.Visible = true;
        }

        private void grdMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Utility.loadCombo(cboCounty, "SELECT * FROM Counties ORDER BY Name");

            //retrieve FULL details for selected member and load on UI for updating
            //create an instance of Member and call a method to instantiate it's instance
            //variables
            int Id = Convert.ToInt32(grdMembers.Rows[grdMembers.CurrentCell.RowIndex].Cells[0].Value.ToString());
            aMember.getMember(Id);

            //County ComboBox data
            cboCounty.SelectedIndex = 0;
            while (!aMember.getCounty().Equals(cboCounty.Text.Substring(0, 2)))
            {
                cboCounty.SelectedIndex++;
            }

            //move values from instance variables to form controls
            txtId.Text = aMember.getId().ToString("0000");
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();
            txtPhone.Text = aMember.getPhone().ToString("0000000000");
            txtStreet.Text = aMember.getStreet();
            txtTown.Text = aMember.getTown();
            cboCounty.SelectedItem = aMember.getCounty();
            txtEircode.Text = aMember.getEircode();
            txtEmail.Text = aMember.getEmail();
            //display the widget for updating
            grpMember.Visible = true;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            //validate the data
            if (txtSurname.Text == "" || txtForename.Text == "" || txtPhone.Text == "" ||
                txtStreet.Text == "" || txtTown.Text == "" || cboCounty.Text == "" ||
                txtEircode.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("You must enter one of the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Update data in Widget File
                //instantiate an instance of an Widget with values in form controls
                aMember.setSurname(txtSurname.Text);
                aMember.setForename(txtForename.Text);
                aMember.setPhone(Convert.ToInt32(txtPhone.Text));
                aMember.setStreet(txtStreet.Text);
                aMember.setTown(txtTown.Text);
                aMember.setCounty(cboCounty.Text.Substring(0, 2));
                aMember.setEircode(txtEircode.Text);
                aMember.setEmail(txtEmail.Text);
                //invoke the updateWidget() method
                aMember.updateMember();
                //display confirmation message
                MessageBox.Show("Thank you, " + txtForename.Text + " (" + txtId.Text + "). Your member details have been updated successfully.", "Success!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                //Reset UI
                grpMember.Visible = false;
                grdMembers.Visible = false;
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        public void loadCounties()
        {
            // Load County Code into UI from A-Z into the Combo box
            DataSet ds = Utility.getCounties();
            for (int i = 0; i < ds.Tables["CS"].Rows.Count; i++)
                cboCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString() +
                " " + ds.Tables[0].Rows[i][1].ToString());
        }

    }
}
