
namespace MovieSYS
{
    partial class frmUpdateMovie
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
            this.mnuUpdateMovie = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.txtStatusDesc = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboAgeRating = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdMovies = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.mnuUpdateMovie.SuspendLayout();
            this.grpMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuUpdateMovie
            // 
            this.mnuUpdateMovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuUpdateMovie.Location = new System.Drawing.Point(0, 0);
            this.mnuUpdateMovie.Name = "mnuUpdateMovie";
            this.mnuUpdateMovie.Size = new System.Drawing.Size(411, 24);
            this.mnuUpdateMovie.TabIndex = 7;
            this.mnuUpdateMovie.Text = "mnuUpdateMovie";
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
            // grpMovie
            // 
            this.grpMovie.Controls.Add(this.txtStatusDesc);
            this.grpMovie.Controls.Add(this.txtStatus);
            this.grpMovie.Controls.Add(this.dtpYear);
            this.grpMovie.Controls.Add(this.cboCategory);
            this.grpMovie.Controls.Add(this.cboAgeRating);
            this.grpMovie.Controls.Add(this.cboGenre);
            this.grpMovie.Controls.Add(this.btnUpd);
            this.grpMovie.Controls.Add(this.lblStatus);
            this.grpMovie.Controls.Add(this.lblCategory);
            this.grpMovie.Controls.Add(this.lblYear);
            this.grpMovie.Controls.Add(this.lblAgeRating);
            this.grpMovie.Controls.Add(this.lblGenre);
            this.grpMovie.Controls.Add(this.txtTitle);
            this.grpMovie.Controls.Add(this.lblTitle);
            this.grpMovie.Controls.Add(this.txtId);
            this.grpMovie.Controls.Add(this.lblId);
            this.grpMovie.Location = new System.Drawing.Point(23, 205);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(364, 288);
            this.grpMovie.TabIndex = 14;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Update Movie Details";
            this.grpMovie.Visible = false;
            // 
            // txtStatusDesc
            // 
            this.txtStatusDesc.Location = new System.Drawing.Point(187, 196);
            this.txtStatusDesc.Name = "txtStatusDesc";
            this.txtStatusDesc.ReadOnly = true;
            this.txtStatusDesc.Size = new System.Drawing.Size(137, 20);
            this.txtStatusDesc.TabIndex = 23;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(143, 196);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(38, 20);
            this.txtStatus.TabIndex = 22;
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(143, 145);
            this.dtpYear.MaxDate = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
            this.dtpYear.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.ShowUpDown = true;
            this.dtpYear.Size = new System.Drawing.Size(68, 20);
            this.dtpYear.TabIndex = 10;
            this.dtpYear.Value = new System.DateTime(2021, 5, 9, 0, 0, 0, 0);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(143, 170);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(181, 21);
            this.cboCategory.TabIndex = 21;
            // 
            // cboAgeRating
            // 
            this.cboAgeRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAgeRating.FormattingEnabled = true;
            this.cboAgeRating.Location = new System.Drawing.Point(143, 118);
            this.cboAgeRating.Name = "cboAgeRating";
            this.cboAgeRating.Size = new System.Drawing.Size(181, 21);
            this.cboAgeRating.TabIndex = 20;
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(143, 92);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(181, 21);
            this.cboGenre.TabIndex = 19;
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(129, 241);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(109, 31);
            this.btnUpd.TabIndex = 18;
            this.btnUpd.Text = "Update Movie";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(31, 199);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(31, 173);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(31, 147);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(31, 121);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(60, 13);
            this.lblAgeRating.TabIndex = 6;
            this.lblAgeRating.Text = "Age Rating";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(31, 95);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(143, 66);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(181, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(31, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 32);
            this.txtId.MaxLength = 4;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Movie ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 20);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdMovies
            // 
            this.grdMovies.AllowUserToAddRows = false;
            this.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovies.Location = new System.Drawing.Point(23, 67);
            this.grdMovies.Name = "grdMovies";
            this.grdMovies.Size = new System.Drawing.Size(364, 115);
            this.grdMovies.TabIndex = 12;
            this.grdMovies.Visible = false;
            this.grdMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovies_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(110, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search Movie by Title";
            // 
            // frmUpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 512);
            this.Controls.Add(this.grpMovie);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdMovies);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuUpdateMovie);
            this.Name = "frmUpdateMovie";
            this.Text = "Update Movie";
            this.mnuUpdateMovie.ResumeLayout(false);
            this.mnuUpdateMovie.PerformLayout();
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboAgeRating;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdMovies;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtStatusDesc;
    }
}