
namespace MovieSYS
{
    partial class frmAnalyseCat
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
            this.mnuAnalyseCat = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chtAnalyseCat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnYear = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.mnuAnalyseCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAnalyseCat
            // 
            this.mnuAnalyseCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain,
            this.mnuExit});
            this.mnuAnalyseCat.Location = new System.Drawing.Point(0, 0);
            this.mnuAnalyseCat.Name = "mnuAnalyseCat";
            this.mnuAnalyseCat.Size = new System.Drawing.Size(610, 24);
            this.mnuAnalyseCat.TabIndex = 6;
            this.mnuAnalyseCat.Text = "mnuAnalyseCat";
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
            // chtAnalyseCat
            // 
            chartArea1.Name = "ChartArea1";
            this.chtAnalyseCat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtAnalyseCat.Legends.Add(legend1);
            this.chtAnalyseCat.Location = new System.Drawing.Point(12, 71);
            this.chtAnalyseCat.Name = "chtAnalyseCat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtAnalyseCat.Series.Add(series1);
            this.chtAnalyseCat.Size = new System.Drawing.Size(583, 310);
            this.chtAnalyseCat.TabIndex = 30;
            this.chtAnalyseCat.Text = "chart1";
            this.chtAnalyseCat.Visible = false;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(100, 31);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(136, 21);
            this.cboCategory.TabIndex = 29;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(255, 32);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(64, 20);
            this.btnYear.TabIndex = 28;
            this.btnYear.Text = "View";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 13);
            this.lblCategory.TabIndex = 27;
            this.lblCategory.Text = "Select Category";
            // 
            // frmAnalyseCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 400);
            this.Controls.Add(this.chtAnalyseCat);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.mnuAnalyseCat);
            this.Name = "frmAnalyseCat";
            this.Text = "Analyse Categories";
            this.Load += new System.EventHandler(this.frmAnalyseCat_Load);
            this.mnuAnalyseCat.ResumeLayout(false);
            this.mnuAnalyseCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtAnalyseCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnalyseCat;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAnalyseCat;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label lblCategory;
    }
}