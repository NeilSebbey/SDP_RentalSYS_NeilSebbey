﻿
namespace MovieSYS
{
    partial class frmQueryRentals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuQueryRentals = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMovies = new System.Windows.Forms.GroupBox();
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAgeRating = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.grdMovies = new System.Windows.Forms.DataGridView();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtMemberIdSel = new System.Windows.Forms.TextBox();
            this.lblMemberIdSel = new System.Windows.Forms.Label();
            this.grpRentalIdSearch = new System.Windows.Forms.GroupBox();
            this.grdRentals = new System.Windows.Forms.DataGridView();
            this.btnRentalId = new System.Windows.Forms.Button();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.grpRental = new System.Windows.Forms.GroupBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtRentalIdSel = new System.Windows.Forms.TextBox();
            this.lblRentalIdSel = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtRentalDate = new System.Windows.Forms.TextBox();
            this.lblRentalDate = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.mnuQueryRentals.SuspendLayout();
            this.grpMovies.SuspendLayout();
            this.grpMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).BeginInit();
            this.grpMember.SuspendLayout();
            this.grpRentalIdSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentals)).BeginInit();
            this.grpRental.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQueryRentals
            // 
            this.mnuQueryRentals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuQueryRentals.Location = new System.Drawing.Point(0, 0);
            this.mnuQueryRentals.Name = "mnuQueryRentals";
            this.mnuQueryRentals.Size = new System.Drawing.Size(694, 24);
            this.mnuQueryRentals.TabIndex = 7;
            this.mnuQueryRentals.Text = "mnuQueryRentals";
            // 
            // mnuMain
            // 
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(80, 20);
            this.mnuMain.Text = "Main Menu";
            this.mnuMain.Click += new System.EventHandler(this.mnuMain_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.grpMovie);
            this.grpMovies.Controls.Add(this.grdMovies);
            this.grpMovies.Location = new System.Drawing.Point(12, 290);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(665, 247);
            this.grpMovies.TabIndex = 25;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "List of your rented movies";
            this.grpMovies.Visible = false;
            // 
            // grpMovie
            // 
            this.grpMovie.Controls.Add(this.txtStatus);
            this.grpMovie.Controls.Add(this.lblStatus);
            this.grpMovie.Controls.Add(this.lblCategory);
            this.grpMovie.Controls.Add(this.txtCategory);
            this.grpMovie.Controls.Add(this.txtYear);
            this.grpMovie.Controls.Add(this.txtTitle);
            this.grpMovie.Controls.Add(this.txtAgeRating);
            this.grpMovie.Controls.Add(this.lblYear);
            this.grpMovie.Controls.Add(this.lblTitle);
            this.grpMovie.Controls.Add(this.txtGenre);
            this.grpMovie.Controls.Add(this.lblId);
            this.grpMovie.Controls.Add(this.lblAgeRating);
            this.grpMovie.Controls.Add(this.txtMovieId);
            this.grpMovie.Controls.Add(this.lblGenre);
            this.grpMovie.Location = new System.Drawing.Point(457, 19);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(199, 214);
            this.grpMovie.TabIndex = 31;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Movie Details";
            this.grpMovie.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(67, 178);
            this.txtStatus.MaxLength = 30;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(44, 20);
            this.txtStatus.TabIndex = 27;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(4, 155);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(67, 152);
            this.txtCategory.MaxLength = 30;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(44, 20);
            this.txtCategory.TabIndex = 26;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(67, 126);
            this.txtYear.MaxLength = 30;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(71, 20);
            this.txtYear.TabIndex = 25;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(67, 48);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(111, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAgeRating
            // 
            this.txtAgeRating.Location = new System.Drawing.Point(67, 100);
            this.txtAgeRating.MaxLength = 30;
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.ReadOnly = true;
            this.txtAgeRating.Size = new System.Drawing.Size(44, 20);
            this.txtAgeRating.TabIndex = 24;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(4, 129);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(67, 74);
            this.txtGenre.MaxLength = 30;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(111, 20);
            this.txtGenre.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Movie ID";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(4, 103);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 6;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // txtMovieId
            // 
            this.txtMovieId.Location = new System.Drawing.Point(67, 19);
            this.txtMovieId.MaxLength = 4;
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.ReadOnly = true;
            this.txtMovieId.Size = new System.Drawing.Size(58, 20);
            this.txtMovieId.TabIndex = 1;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(4, 77);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // grdMovies
            // 
            this.grdMovies.AllowUserToAddRows = false;
            this.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovies.Location = new System.Drawing.Point(15, 19);
            this.grdMovies.Name = "grdMovies";
            this.grdMovies.Size = new System.Drawing.Size(421, 214);
            this.grdMovies.TabIndex = 11;
            this.grdMovies.Visible = false;
            this.grdMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovies_CellClick);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtForename);
            this.grpMember.Controls.Add(this.lblForename);
            this.grpMember.Controls.Add(this.txtSurname);
            this.grpMember.Controls.Add(this.lblSurname);
            this.grpMember.Controls.Add(this.txtMemberIdSel);
            this.grpMember.Controls.Add(this.lblMemberIdSel);
            this.grpMember.Location = new System.Drawing.Point(12, 204);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(450, 80);
            this.grpMember.TabIndex = 45;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Details";
            this.grpMember.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(189, 47);
            this.txtForename.MaxLength = 24;
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(120, 20);
            this.txtForename.TabIndex = 41;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(116, 50);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 40;
            this.lblForename.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(189, 21);
            this.txtSurname.MaxLength = 24;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(120, 20);
            this.txtSurname.TabIndex = 39;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(116, 24);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 38;
            this.lblSurname.Text = "Surname";
            // 
            // txtMemberIdSel
            // 
            this.txtMemberIdSel.Location = new System.Drawing.Point(44, 21);
            this.txtMemberIdSel.MaxLength = 4;
            this.txtMemberIdSel.Name = "txtMemberIdSel";
            this.txtMemberIdSel.ReadOnly = true;
            this.txtMemberIdSel.Size = new System.Drawing.Size(58, 20);
            this.txtMemberIdSel.TabIndex = 37;
            // 
            // lblMemberIdSel
            // 
            this.lblMemberIdSel.AutoSize = true;
            this.lblMemberIdSel.Location = new System.Drawing.Point(17, 24);
            this.lblMemberIdSel.Name = "lblMemberIdSel";
            this.lblMemberIdSel.Size = new System.Drawing.Size(21, 13);
            this.lblMemberIdSel.TabIndex = 34;
            this.lblMemberIdSel.Text = "ID:";
            // 
            // grpRentalIdSearch
            // 
            this.grpRentalIdSearch.Controls.Add(this.grdRentals);
            this.grpRentalIdSearch.Controls.Add(this.btnRentalId);
            this.grpRentalIdSearch.Controls.Add(this.lblRentalId);
            this.grpRentalIdSearch.Controls.Add(this.txtRentalId);
            this.grpRentalIdSearch.Location = new System.Drawing.Point(12, 36);
            this.grpRentalIdSearch.Name = "grpRentalIdSearch";
            this.grpRentalIdSearch.Size = new System.Drawing.Size(450, 162);
            this.grpRentalIdSearch.TabIndex = 44;
            this.grpRentalIdSearch.TabStop = false;
            this.grpRentalIdSearch.Text = "Enter your Rental ID";
            // 
            // grdRentals
            // 
            this.grdRentals.AllowUserToAddRows = false;
            this.grdRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRentals.Location = new System.Drawing.Point(15, 40);
            this.grdRentals.Name = "grdRentals";
            this.grdRentals.Size = new System.Drawing.Size(421, 106);
            this.grdRentals.TabIndex = 21;
            this.grdRentals.Visible = false;
            this.grdRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentals_CellClick);
            // 
            // btnRentalId
            // 
            this.btnRentalId.Location = new System.Drawing.Point(166, 15);
            this.btnRentalId.Name = "btnRentalId";
            this.btnRentalId.Size = new System.Drawing.Size(55, 20);
            this.btnRentalId.TabIndex = 9;
            this.btnRentalId.Text = "OK";
            this.btnRentalId.UseVisualStyleBackColor = true;
            this.btnRentalId.Click += new System.EventHandler(this.btnRentalId_Click);
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Location = new System.Drawing.Point(12, 18);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(52, 13);
            this.lblRentalId.TabIndex = 8;
            this.lblRentalId.Text = "Rental ID";
            // 
            // txtRentalId
            // 
            this.txtRentalId.Location = new System.Drawing.Point(77, 15);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.Size = new System.Drawing.Size(58, 20);
            this.txtRentalId.TabIndex = 7;
            this.txtRentalId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentalId_KeyPress);
            // 
            // grpRental
            // 
            this.grpRental.Controls.Add(this.btnView);
            this.grpRental.Controls.Add(this.txtMemberId);
            this.grpRental.Controls.Add(this.lblMemberId);
            this.grpRental.Controls.Add(this.txtRentalIdSel);
            this.grpRental.Controls.Add(this.lblRentalIdSel);
            this.grpRental.Controls.Add(this.txtCost);
            this.grpRental.Controls.Add(this.txtDueDate);
            this.grpRental.Controls.Add(this.lblCost);
            this.grpRental.Controls.Add(this.lblDueDate);
            this.grpRental.Controls.Add(this.txtRentalDate);
            this.grpRental.Controls.Add(this.lblRentalDate);
            this.grpRental.Location = new System.Drawing.Point(468, 36);
            this.grpRental.Name = "grpRental";
            this.grpRental.Size = new System.Drawing.Size(209, 248);
            this.grpRental.TabIndex = 43;
            this.grpRental.TabStop = false;
            this.grpRental.Text = "Rental Details";
            this.grpRental.Visible = false;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(91, 49);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(57, 20);
            this.txtMemberId.TabIndex = 13;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(14, 52);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(59, 13);
            this.lblMemberId.TabIndex = 12;
            this.lblMemberId.Text = "Member ID";
            // 
            // txtRentalIdSel
            // 
            this.txtRentalIdSel.Location = new System.Drawing.Point(91, 23);
            this.txtRentalIdSel.Name = "txtRentalIdSel";
            this.txtRentalIdSel.ReadOnly = true;
            this.txtRentalIdSel.Size = new System.Drawing.Size(57, 20);
            this.txtRentalIdSel.TabIndex = 11;
            // 
            // lblRentalIdSel
            // 
            this.lblRentalIdSel.AutoSize = true;
            this.lblRentalIdSel.Location = new System.Drawing.Point(14, 26);
            this.lblRentalIdSel.Name = "lblRentalIdSel";
            this.lblRentalIdSel.Size = new System.Drawing.Size(52, 13);
            this.lblRentalIdSel.TabIndex = 10;
            this.lblRentalIdSel.Text = "Rental ID";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(91, 126);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(96, 20);
            this.txtCost.TabIndex = 9;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(91, 100);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(96, 20);
            this.txtDueDate.TabIndex = 8;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(14, 129);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(43, 13);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost (€)";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(14, 103);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(53, 13);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date";
            // 
            // txtRentalDate
            // 
            this.txtRentalDate.Location = new System.Drawing.Point(91, 75);
            this.txtRentalDate.MaxLength = 30;
            this.txtRentalDate.Name = "txtRentalDate";
            this.txtRentalDate.ReadOnly = true;
            this.txtRentalDate.Size = new System.Drawing.Size(96, 20);
            this.txtRentalDate.TabIndex = 5;
            // 
            // lblRentalDate
            // 
            this.lblRentalDate.AutoSize = true;
            this.lblRentalDate.Location = new System.Drawing.Point(14, 78);
            this.lblRentalDate.Name = "lblRentalDate";
            this.lblRentalDate.Size = new System.Drawing.Size(64, 13);
            this.lblRentalDate.TabIndex = 4;
            this.lblRentalDate.Text = "Rental Date";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(42, 173);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(137, 51);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View Your Rentals";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmQueryRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 545);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.grpRentalIdSearch);
            this.Controls.Add(this.grpRental);
            this.Controls.Add(this.grpMovies);
            this.Controls.Add(this.mnuQueryRentals);
            this.Name = "frmQueryRentals";
            this.Text = "Query Rentals";
            this.mnuQueryRentals.ResumeLayout(false);
            this.mnuQueryRentals.PerformLayout();
            this.grpMovies.ResumeLayout(false);
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.grpRentalIdSearch.ResumeLayout(false);
            this.grpRentalIdSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentals)).EndInit();
            this.grpRental.ResumeLayout(false);
            this.grpRental.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQueryRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpMovies;
        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAgeRating;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DataGridView grdMovies;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtMemberIdSel;
        private System.Windows.Forms.Label lblMemberIdSel;
        private System.Windows.Forms.GroupBox grpRentalIdSearch;
        private System.Windows.Forms.DataGridView grdRentals;
        private System.Windows.Forms.Button btnRentalId;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.GroupBox grpRental;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtRentalIdSel;
        private System.Windows.Forms.Label lblRentalIdSel;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtRentalDate;
        private System.Windows.Forms.Label lblRentalDate;
        private System.Windows.Forms.Button btnView;
    }
}