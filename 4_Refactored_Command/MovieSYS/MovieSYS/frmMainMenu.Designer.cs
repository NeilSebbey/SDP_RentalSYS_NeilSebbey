
namespace MovieSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblWelcomeMsg = new System.Windows.Forms.Label();
            this.picMainPic2 = new System.Windows.Forms.PictureBox();
            this.picMainPic = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseRev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg.Location = new System.Drawing.Point(153, 296);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(254, 25);
            this.lblWelcomeMsg.TabIndex = 11;
            this.lblWelcomeMsg.Text = "Dreamovie Rental Club";
            // 
            // picMainPic2
            // 
            this.picMainPic2.Image = ((System.Drawing.Image)(resources.GetObject("picMainPic2.Image")));
            this.picMainPic2.Location = new System.Drawing.Point(273, 27);
            this.picMainPic2.Name = "picMainPic2";
            this.picMainPic2.Size = new System.Drawing.Size(296, 294);
            this.picMainPic2.TabIndex = 10;
            this.picMainPic2.TabStop = false;
            // 
            // picMainPic
            // 
            this.picMainPic.Image = ((System.Drawing.Image)(resources.GetObject("picMainPic.Image")));
            this.picMainPic.Location = new System.Drawing.Point(0, 27);
            this.picMainPic.Name = "picMainPic";
            this.picMainPic.Size = new System.Drawing.Size(278, 294);
            this.picMainPic.TabIndex = 9;
            this.picMainPic.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersToolStripMenuItem,
            this.mnuMovies,
            this.mnuRentals,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(569, 24);
            this.mnuMain.TabIndex = 8;
            this.mnuMain.Text = "menuStrip1";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(198, 22);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(198, 22);
            this.mnuUpdateMember.Text = "Update Member Details";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuMovies
            // 
            this.mnuMovies.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMovie,
            this.mnuUpdateMovie,
            this.mnuDeleteMovie,
            this.mnuQueryMovie});
            this.mnuMovies.Name = "mnuMovies";
            this.mnuMovies.Size = new System.Drawing.Size(57, 20);
            this.mnuMovies.Text = "Movies";
            // 
            // mnuAddMovie
            // 
            this.mnuAddMovie.Name = "mnuAddMovie";
            this.mnuAddMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuAddMovie.Text = "Add Movie";
            this.mnuAddMovie.Click += new System.EventHandler(this.mnuAddMovie_Click);
            // 
            // mnuUpdateMovie
            // 
            this.mnuUpdateMovie.Name = "mnuUpdateMovie";
            this.mnuUpdateMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuUpdateMovie.Text = "Update Movie";
            this.mnuUpdateMovie.Click += new System.EventHandler(this.mnuUpdateMovie_Click);
            // 
            // mnuDeleteMovie
            // 
            this.mnuDeleteMovie.Name = "mnuDeleteMovie";
            this.mnuDeleteMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuDeleteMovie.Text = "Delete Movie";
            this.mnuDeleteMovie.Click += new System.EventHandler(this.mnuDeleteMovie_Click);
            // 
            // mnuQueryMovie
            // 
            this.mnuQueryMovie.Name = "mnuQueryMovie";
            this.mnuQueryMovie.Size = new System.Drawing.Size(148, 22);
            this.mnuQueryMovie.Text = "Query Movie";
            this.mnuQueryMovie.Click += new System.EventHandler(this.mnuQueryMovie_Click);
            // 
            // mnuRentals
            // 
            this.mnuRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentMovie,
            this.mnuReturnMovie,
            this.mnuQueryRentals});
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Size = new System.Drawing.Size(57, 20);
            this.mnuRentals.Text = "Rentals";
            // 
            // mnuRentMovie
            // 
            this.mnuRentMovie.Name = "mnuRentMovie";
            this.mnuRentMovie.Size = new System.Drawing.Size(180, 22);
            this.mnuRentMovie.Text = "Rent Movie";
            this.mnuRentMovie.Click += new System.EventHandler(this.mnuRentMovie_Click);
            // 
            // mnuReturnMovie
            // 
            this.mnuReturnMovie.Name = "mnuReturnMovie";
            this.mnuReturnMovie.Size = new System.Drawing.Size(180, 22);
            this.mnuReturnMovie.Text = "Return Movie";
            this.mnuReturnMovie.Click += new System.EventHandler(this.mnuReturnMovie_Click);
            // 
            // mnuQueryRentals
            // 
            this.mnuQueryRentals.Name = "mnuQueryRentals";
            this.mnuQueryRentals.Size = new System.Drawing.Size(180, 22);
            this.mnuQueryRentals.Text = "Query Rentals";
            this.mnuQueryRentals.Click += new System.EventHandler(this.mnuQueryRentals_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseRev,
            this.mnuAnalyseCat});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuAnalyseRev
            // 
            this.mnuAnalyseRev.Name = "mnuAnalyseRev";
            this.mnuAnalyseRev.Size = new System.Drawing.Size(197, 22);
            this.mnuAnalyseRev.Text = "Analyse Yearly Revenue";
            this.mnuAnalyseRev.Click += new System.EventHandler(this.mnuAnalyseRev_Click);
            // 
            // mnuAnalyseCat
            // 
            this.mnuAnalyseCat.Name = "mnuAnalyseCat";
            this.mnuAnalyseCat.Size = new System.Drawing.Size(197, 22);
            this.mnuAnalyseCat.Text = "Analyse Categories";
            this.mnuAnalyseCat.Click += new System.EventHandler(this.mnuAnalyseCat_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 320);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Controls.Add(this.picMainPic2);
            this.Controls.Add(this.picMainPic);
            this.Controls.Add(this.mnuMain);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMainPic)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMsg;
        private System.Windows.Forms.PictureBox picMainPic2;
        private System.Windows.Forms.PictureBox picMainPic;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuMovies;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuRentMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnMovie;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseRev;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseCat;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}

