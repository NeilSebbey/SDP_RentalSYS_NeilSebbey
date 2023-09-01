
namespace MovieSYS
{
    partial class frmDeleteMovie
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
            this.mnuDeleteMovie = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtAgeRating = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
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
            this.mnuDeleteMovie.SuspendLayout();
            this.grpMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuDeleteMovie
            // 
            this.mnuDeleteMovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuDeleteMovie.Location = new System.Drawing.Point(0, 0);
            this.mnuDeleteMovie.Name = "mnuDeleteMovie";
            this.mnuDeleteMovie.Size = new System.Drawing.Size(413, 24);
            this.mnuDeleteMovie.TabIndex = 8;
            this.mnuDeleteMovie.Text = "mnuDeleteMovie";
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
            this.grpMovie.Controls.Add(this.txtStatus);
            this.grpMovie.Controls.Add(this.txtCategory);
            this.grpMovie.Controls.Add(this.txtAgeRating);
            this.grpMovie.Controls.Add(this.txtGenre);
            this.grpMovie.Controls.Add(this.btnDel);
            this.grpMovie.Controls.Add(this.lblStatus);
            this.grpMovie.Controls.Add(this.lblCategory);
            this.grpMovie.Controls.Add(this.txtYear);
            this.grpMovie.Controls.Add(this.lblYear);
            this.grpMovie.Controls.Add(this.lblAgeRating);
            this.grpMovie.Controls.Add(this.lblGenre);
            this.grpMovie.Controls.Add(this.txtTitle);
            this.grpMovie.Controls.Add(this.lblTitle);
            this.grpMovie.Controls.Add(this.txtId);
            this.grpMovie.Controls.Add(this.lblId);
            this.grpMovie.Location = new System.Drawing.Point(24, 201);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(364, 224);
            this.grpMovie.TabIndex = 18;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Delete a Movie";
            this.grpMovie.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(252, 144);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(44, 20);
            this.txtStatus.TabIndex = 25;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(103, 144);
            this.txtCategory.MaxLength = 2;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(68, 20);
            this.txtCategory.TabIndex = 24;
            // 
            // txtAgeRating
            // 
            this.txtAgeRating.Location = new System.Drawing.Point(103, 118);
            this.txtAgeRating.MaxLength = 2;
            this.txtAgeRating.Name = "txtAgeRating";
            this.txtAgeRating.ReadOnly = true;
            this.txtAgeRating.Size = new System.Drawing.Size(68, 20);
            this.txtAgeRating.TabIndex = 23;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(103, 92);
            this.txtGenre.MaxLength = 20;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(181, 20);
            this.txtGenre.TabIndex = 22;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(129, 179);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 31);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "Delete Movie";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(209, 147);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(32, 147);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Category";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(252, 118);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(68, 20);
            this.txtYear.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(209, 121);
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
            this.txtTitle.Location = new System.Drawing.Point(103, 66);
            this.txtTitle.MaxLength = 24;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(217, 20);
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
            this.txtId.Location = new System.Drawing.Point(103, 32);
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
            this.btnSearch.Location = new System.Drawing.Point(327, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 20);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdMovies
            // 
            this.grdMovies.AllowUserToAddRows = false;
            this.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovies.Location = new System.Drawing.Point(24, 67);
            this.grdMovies.Name = "grdMovies";
            this.grdMovies.Size = new System.Drawing.Size(364, 115);
            this.grdMovies.TabIndex = 16;
            this.grdMovies.Visible = false;
            this.grdMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMovies_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(154, 20);
            this.txtSearch.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(21, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(110, 13);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search Movie by Title";
            // 
            // frmDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 444);
            this.Controls.Add(this.grpMovie);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grdMovies);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.mnuDeleteMovie);
            this.Name = "frmDeleteMovie";
            this.Text = "Delete Movie";
            this.mnuDeleteMovie.ResumeLayout(false);
            this.mnuDeleteMovie.PerformLayout();
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuDeleteMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAgeRating;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtYear;
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
    }
}