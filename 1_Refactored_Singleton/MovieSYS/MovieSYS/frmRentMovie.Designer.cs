
namespace MovieSYS
{
    partial class frmRentMovie
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
            this.mnuRentMovie = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCheckout = new System.Windows.Forms.GroupBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtCheckoutCount = new System.Windows.Forms.TextBox();
            this.lblMoviesRented = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstCheckout = new System.Windows.Forms.ListBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAgeRating = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.btnMemberId = new System.Windows.Forms.Button();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.txtMemberIdSel = new System.Windows.Forms.TextBox();
            this.lblMemberIdSel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grdMovies = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpMovies = new System.Windows.Forms.GroupBox();
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.btnTitleSearch = new System.Windows.Forms.Button();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblSurnameSearch = new System.Windows.Forms.Label();
            this.txtSurnameSearch = new System.Windows.Forms.TextBox();
            this.btnSurnameSearch = new System.Windows.Forms.Button();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.grpMemberSearch = new System.Windows.Forms.GroupBox();
            this.mnuRentMovie.SuspendLayout();
            this.grpCheckout.SuspendLayout();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).BeginInit();
            this.grpMovies.SuspendLayout();
            this.grpMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.grpMemberSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRentMovie
            // 
            this.mnuRentMovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuRentMovie.Location = new System.Drawing.Point(0, 0);
            this.mnuRentMovie.Name = "mnuRentMovie";
            this.mnuRentMovie.Size = new System.Drawing.Size(719, 24);
            this.mnuRentMovie.TabIndex = 5;
            this.mnuRentMovie.Text = "mnuRentMovie";
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
            // grpCheckout
            // 
            this.grpCheckout.Controls.Add(this.txtCost);
            this.grpCheckout.Controls.Add(this.lblCost);
            this.grpCheckout.Controls.Add(this.dtpRentDate);
            this.grpCheckout.Controls.Add(this.lblRentDate);
            this.grpCheckout.Controls.Add(this.txtRentalId);
            this.grpCheckout.Controls.Add(this.lblRentalId);
            this.grpCheckout.Controls.Add(this.dtpDueDate);
            this.grpCheckout.Controls.Add(this.lblDueDate);
            this.grpCheckout.Controls.Add(this.txtCheckoutCount);
            this.grpCheckout.Controls.Add(this.lblMoviesRented);
            this.grpCheckout.Controls.Add(this.btnRemove);
            this.grpCheckout.Controls.Add(this.lstCheckout);
            this.grpCheckout.Controls.Add(this.btnRent);
            this.grpCheckout.Location = new System.Drawing.Point(25, 531);
            this.grpCheckout.Name = "grpCheckout";
            this.grpCheckout.Size = new System.Drawing.Size(670, 231);
            this.grpCheckout.TabIndex = 6;
            this.grpCheckout.TabStop = false;
            this.grpCheckout.Text = "Checkout";
            this.grpCheckout.Visible = false;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(533, 147);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(63, 20);
            this.txtCost.TabIndex = 32;
            this.txtCost.Text = "0.00";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(446, 150);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(84, 13);
            this.lblCost.TabIndex = 31;
            this.lblCost.Text = "Cost Total (€)";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CustomFormat = "dd-MMM-yy";
            this.dtpRentDate.Enabled = false;
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(533, 101);
            this.dtpRentDate.MaxDate = new System.DateTime(2038, 1, 19, 3, 14, 7, 0);
            this.dtpRentDate.MinDate = new System.DateTime(2021, 5, 9, 12, 30, 37, 351);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(111, 20);
            this.dtpRentDate.TabIndex = 29;
            this.dtpRentDate.Value = new System.DateTime(2021, 5, 9, 12, 30, 37, 351);
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Location = new System.Drawing.Point(446, 107);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(64, 13);
            this.lblRentDate.TabIndex = 27;
            this.lblRentDate.Text = "Rental Date";
            // 
            // txtRentalId
            // 
            this.txtRentalId.Location = new System.Drawing.Point(533, 75);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.ReadOnly = true;
            this.txtRentalId.Size = new System.Drawing.Size(63, 20);
            this.txtRentalId.TabIndex = 26;
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Location = new System.Drawing.Point(446, 78);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(52, 13);
            this.lblRentalId.TabIndex = 25;
            this.lblRentalId.Text = "Rental ID";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MMM-yy";
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(312, 192);
            this.dtpDueDate.MaxDate = new System.DateTime(2038, 1, 19, 3, 14, 7, 0);
            this.dtpDueDate.MinDate = new System.DateTime(2021, 5, 9, 12, 30, 37, 363);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(100, 20);
            this.dtpDueDate.TabIndex = 24;
            this.dtpDueDate.Value = new System.DateTime(2021, 5, 10, 12, 30, 37, 364);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(176, 195);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(130, 13);
            this.lblDueDate.TabIndex = 23;
            this.lblDueDate.Text = "Due Date for Return: ";
            // 
            // txtCheckoutCount
            // 
            this.txtCheckoutCount.Location = new System.Drawing.Point(113, 192);
            this.txtCheckoutCount.Name = "txtCheckoutCount";
            this.txtCheckoutCount.ReadOnly = true;
            this.txtCheckoutCount.Size = new System.Drawing.Size(47, 20);
            this.txtCheckoutCount.TabIndex = 22;
            this.txtCheckoutCount.Text = "0";
            this.txtCheckoutCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMoviesRented
            // 
            this.lblMoviesRented.AutoSize = true;
            this.lblMoviesRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviesRented.Location = new System.Drawing.Point(12, 195);
            this.lblMoviesRented.Name = "lblMoviesRented";
            this.lblMoviesRented.Size = new System.Drawing.Size(108, 13);
            this.lblMoviesRented.TabIndex = 21;
            this.lblMoviesRented.Text = "Movie(s) Rented: ";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(501, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 31);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove from Cart";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstCheckout
            // 
            this.lstCheckout.FormattingEnabled = true;
            this.lstCheckout.Location = new System.Drawing.Point(15, 29);
            this.lstCheckout.Name = "lstCheckout";
            this.lstCheckout.Size = new System.Drawing.Size(421, 147);
            this.lstCheckout.TabIndex = 19;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(501, 186);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(109, 31);
            this.btnRent.TabIndex = 18;
            this.btnRent.Text = "Rent Movie(s)";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
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
            // txtAgeRating
            // 
            this.txtAgeRating.Location = new System.Drawing.Point(67, 100);
            this.txtAgeRating.MaxLength = 30;
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.ReadOnly = true;
            this.txtAgeRating.Size = new System.Drawing.Size(44, 20);
            this.txtAgeRating.TabIndex = 24;
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
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(4, 129);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
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
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(4, 77);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Movie ID";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(77, 15);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(58, 20);
            this.txtMemberId.TabIndex = 7;
            this.txtMemberId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberId_KeyPress);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(12, 18);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(59, 13);
            this.lblMemberId.TabIndex = 8;
            this.lblMemberId.Text = "Member ID";
            // 
            // btnMemberId
            // 
            this.btnMemberId.Location = new System.Drawing.Point(166, 15);
            this.btnMemberId.Name = "btnMemberId";
            this.btnMemberId.Size = new System.Drawing.Size(55, 20);
            this.btnMemberId.TabIndex = 9;
            this.btnMemberId.Text = "OK";
            this.btnMemberId.UseVisualStyleBackColor = true;
            this.btnMemberId.Click += new System.EventHandler(this.btnMemberId_Click);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtMemberIdSel);
            this.grpMember.Controls.Add(this.lblMemberIdSel);
            this.grpMember.Controls.Add(this.txtEmail);
            this.grpMember.Controls.Add(this.txtAddress);
            this.grpMember.Controls.Add(this.lblEmail);
            this.grpMember.Controls.Add(this.lblAddress);
            this.grpMember.Controls.Add(this.txtForename);
            this.grpMember.Controls.Add(this.lblForename);
            this.grpMember.Controls.Add(this.txtSurname);
            this.grpMember.Controls.Add(this.lblSurname);
            this.grpMember.Location = new System.Drawing.Point(482, 40);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(213, 162);
            this.grpMember.TabIndex = 10;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Details";
            this.grpMember.Visible = false;
            // 
            // txtMemberIdSel
            // 
            this.txtMemberIdSel.Location = new System.Drawing.Point(76, 24);
            this.txtMemberIdSel.Name = "txtMemberIdSel";
            this.txtMemberIdSel.ReadOnly = true;
            this.txtMemberIdSel.Size = new System.Drawing.Size(57, 20);
            this.txtMemberIdSel.TabIndex = 11;
            // 
            // lblMemberIdSel
            // 
            this.lblMemberIdSel.AutoSize = true;
            this.lblMemberIdSel.Location = new System.Drawing.Point(18, 27);
            this.lblMemberIdSel.Name = "lblMemberIdSel";
            this.lblMemberIdSel.Size = new System.Drawing.Size(18, 13);
            this.lblMemberIdSel.TabIndex = 10;
            this.lblMemberIdSel.Text = "ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(76, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(123, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 104);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(76, 76);
            this.txtForename.MaxLength = 30;
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(123, 20);
            this.txtForename.TabIndex = 5;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(18, 79);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(54, 13);
            this.lblForename.TabIndex = 4;
            this.lblForename.Text = "Forename";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(76, 50);
            this.txtSurname.MaxLength = 30;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(123, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 53);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // grdMovies
            // 
            this.grdMovies.AllowUserToAddRows = false;
            this.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovies.Location = new System.Drawing.Point(15, 57);
            this.grdMovies.Name = "grdMovies";
            this.grdMovies.Size = new System.Drawing.Size(421, 223);
            this.grdMovies.TabIndex = 11;
            this.grdMovies.Visible = false;
            this.grdMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovies_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(52, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpMovies
            // 
            this.grpMovies.Controls.Add(this.grpMovie);
            this.grpMovies.Controls.Add(this.btnTitleSearch);
            this.grpMovies.Controls.Add(this.txtTitleSearch);
            this.grpMovies.Controls.Add(this.lblTitleSearch);
            this.grpMovies.Controls.Add(this.grdMovies);
            this.grpMovies.Location = new System.Drawing.Point(25, 212);
            this.grpMovies.Name = "grpMovies";
            this.grpMovies.Size = new System.Drawing.Size(670, 300);
            this.grpMovies.TabIndex = 16;
            this.grpMovies.TabStop = false;
            this.grpMovies.Text = "Select a movie to rent";
            this.grpMovies.Visible = false;
            // 
            // grpMovie
            // 
            this.grpMovie.Controls.Add(this.txtStatus);
            this.grpMovie.Controls.Add(this.lblStatus);
            this.grpMovie.Controls.Add(this.lblCategory);
            this.grpMovie.Controls.Add(this.txtCategory);
            this.grpMovie.Controls.Add(this.btnAdd);
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
            this.grpMovie.Location = new System.Drawing.Point(466, 41);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(185, 239);
            this.grpMovie.TabIndex = 31;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Movie Details";
            this.grpMovie.Visible = false;
            // 
            // btnTitleSearch
            // 
            this.btnTitleSearch.Location = new System.Drawing.Point(230, 27);
            this.btnTitleSearch.Name = "btnTitleSearch";
            this.btnTitleSearch.Size = new System.Drawing.Size(62, 20);
            this.btnTitleSearch.TabIndex = 30;
            this.btnTitleSearch.Text = "Search";
            this.btnTitleSearch.UseVisualStyleBackColor = true;
            this.btnTitleSearch.Click += new System.EventHandler(this.btnTitleSearch_Click);
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(99, 27);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(122, 20);
            this.txtTitleSearch.TabIndex = 29;
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Location = new System.Drawing.Point(12, 30);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(81, 13);
            this.lblTitleSearch.TabIndex = 28;
            this.lblTitleSearch.Text = "Search by Title:";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(100, 41);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(23, 13);
            this.lblOR.TabIndex = 17;
            this.lblOR.Text = "OR";
            // 
            // lblSurnameSearch
            // 
            this.lblSurnameSearch.AutoSize = true;
            this.lblSurnameSearch.Location = new System.Drawing.Point(12, 63);
            this.lblSurnameSearch.Name = "lblSurnameSearch";
            this.lblSurnameSearch.Size = new System.Drawing.Size(49, 13);
            this.lblSurnameSearch.TabIndex = 18;
            this.lblSurnameSearch.Text = "Surname";
            // 
            // txtSurnameSearch
            // 
            this.txtSurnameSearch.Location = new System.Drawing.Point(77, 60);
            this.txtSurnameSearch.Name = "txtSurnameSearch";
            this.txtSurnameSearch.Size = new System.Drawing.Size(83, 20);
            this.txtSurnameSearch.TabIndex = 19;
            // 
            // btnSurnameSearch
            // 
            this.btnSurnameSearch.Location = new System.Drawing.Point(166, 60);
            this.btnSurnameSearch.Name = "btnSurnameSearch";
            this.btnSurnameSearch.Size = new System.Drawing.Size(59, 22);
            this.btnSurnameSearch.TabIndex = 20;
            this.btnSurnameSearch.Text = "Search";
            this.btnSurnameSearch.UseVisualStyleBackColor = true;
            this.btnSurnameSearch.Click += new System.EventHandler(this.btnSurnameSearch_Click);
            // 
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembers.Location = new System.Drawing.Point(238, 11);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.Size = new System.Drawing.Size(203, 141);
            this.grdMembers.TabIndex = 21;
            this.grdMembers.Visible = false;
            this.grdMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellClick);
            // 
            // grpMemberSearch
            // 
            this.grpMemberSearch.Controls.Add(this.grdMembers);
            this.grpMemberSearch.Controls.Add(this.btnSurnameSearch);
            this.grpMemberSearch.Controls.Add(this.txtSurnameSearch);
            this.grpMemberSearch.Controls.Add(this.lblSurnameSearch);
            this.grpMemberSearch.Controls.Add(this.lblOR);
            this.grpMemberSearch.Controls.Add(this.btnMemberId);
            this.grpMemberSearch.Controls.Add(this.lblMemberId);
            this.grpMemberSearch.Controls.Add(this.txtMemberId);
            this.grpMemberSearch.Location = new System.Drawing.Point(25, 44);
            this.grpMemberSearch.Name = "grpMemberSearch";
            this.grpMemberSearch.Size = new System.Drawing.Size(447, 158);
            this.grpMemberSearch.TabIndex = 22;
            this.grpMemberSearch.TabStop = false;
            this.grpMemberSearch.Text = "Enter Member";
            // 
            // frmRentMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 781);
            this.Controls.Add(this.grpMemberSearch);
            this.Controls.Add(this.grpMovies);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.grpCheckout);
            this.Controls.Add(this.mnuRentMovie);
            this.Name = "frmRentMovie";
            this.Text = "Rent Movie";
            this.Load += new System.EventHandler(this.frmRentMovie_Load);
            this.mnuRentMovie.ResumeLayout(false);
            this.mnuRentMovie.PerformLayout();
            this.grpCheckout.ResumeLayout(false);
            this.grpCheckout.PerformLayout();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).EndInit();
            this.grpMovies.ResumeLayout(false);
            this.grpMovies.PerformLayout();
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.grpMemberSearch.ResumeLayout(false);
            this.grpMemberSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRentMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpCheckout;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAgeRating;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Button btnMemberId;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DataGridView grdMovies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpMovies;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstCheckout;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtCheckoutCount;
        private System.Windows.Forms.Label lblMoviesRented;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label lblTitleSearch;
        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.Button btnTitleSearch;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblSurnameSearch;
        private System.Windows.Forms.TextBox txtSurnameSearch;
        private System.Windows.Forms.Button btnSurnameSearch;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.GroupBox grpMemberSearch;
        private System.Windows.Forms.TextBox txtMemberIdSel;
        private System.Windows.Forms.Label lblMemberIdSel;
    }
}