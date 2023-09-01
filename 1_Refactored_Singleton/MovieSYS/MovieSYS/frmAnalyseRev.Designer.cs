
namespace MovieSYS
{
    partial class frmAnalyseRev
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnYear = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chtAnalyseRev = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuAnalyseRev = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseRev)).BeginInit();
            this.mnuAnalyseRev.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Select Year";
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(183, 36);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(64, 20);
            this.btnYear.TabIndex = 24;
            this.btnYear.Text = "View";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(91, 35);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(73, 21);
            this.cboYear.TabIndex = 25;
            // 
            // chtAnalyseRev
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnalyseRev.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnalyseRev.Legends.Add(legend1);
            this.chtAnalyseRev.Location = new System.Drawing.Point(12, 73);
            this.chtAnalyseRev.Name = "chtAnalyseRev";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyseRev.Series.Add(series1);
            this.chtAnalyseRev.Size = new System.Drawing.Size(583, 310);
            this.chtAnalyseRev.TabIndex = 26;
            this.chtAnalyseRev.Text = "chart1";
            this.chtAnalyseRev.Visible = false;
            // 
            // mnuAnalyseRev
            // 
            this.mnuAnalyseRev.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuAnalyseRev.Location = new System.Drawing.Point(0, 0);
            this.mnuAnalyseRev.Name = "mnuAnalyseRev";
            this.mnuAnalyseRev.Size = new System.Drawing.Size(607, 24);
            this.mnuAnalyseRev.TabIndex = 27;
            this.mnuAnalyseRev.Text = "mnuAnalyseRev";
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
            // frmAnalyseRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 395);
            this.Controls.Add(this.mnuAnalyseRev);
            this.Controls.Add(this.chtAnalyseRev);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.lblYear);
            this.Name = "frmAnalyseRev";
            this.Text = "Analyse Yearly Revenue";
            this.Load += new System.EventHandler(this.frmAnalyseRev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseRev)).EndInit();
            this.mnuAnalyseRev.ResumeLayout(false);
            this.mnuAnalyseRev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyseRev;
        private System.Windows.Forms.MenuStrip mnuAnalyseRev;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}