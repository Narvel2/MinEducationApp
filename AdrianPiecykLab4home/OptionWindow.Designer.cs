namespace AdrianPiecykLab4home
{
    partial class OptionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionWindow));
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonShowCourses = new System.Windows.Forms.Button();
            this.buttonShowLecturers = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowAddedCourses = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchStudent = new System.Windows.Forms.Button();
            this.buttonRemoveEnrollment = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonGenerateFIle = new System.Windows.Forms.Button();
            this.textBoxExport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.BackgroundColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.dataGridViewShow, "dataGridViewShow");
            this.dataGridViewShow.Name = "dataGridViewShow";
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.labelInfo.Name = "labelInfo";
            // 
            // buttonShowCourses
            // 
            resources.ApplyResources(this.buttonShowCourses, "buttonShowCourses");
            this.buttonShowCourses.Name = "buttonShowCourses";
            this.buttonShowCourses.UseVisualStyleBackColor = true;
            this.buttonShowCourses.Click += new System.EventHandler(this.buttonShowCourses_Click);
            // 
            // buttonShowLecturers
            // 
            resources.ApplyResources(this.buttonShowLecturers, "buttonShowLecturers");
            this.buttonShowLecturers.Name = "buttonShowLecturers";
            this.buttonShowLecturers.UseVisualStyleBackColor = true;
            this.buttonShowLecturers.Click += new System.EventHandler(this.buttonShowLecturers_Click);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowAddedCourses
            // 
            resources.ApplyResources(this.buttonShowAddedCourses, "buttonShowAddedCourses");
            this.buttonShowAddedCourses.Name = "buttonShowAddedCourses";
            this.buttonShowAddedCourses.UseVisualStyleBackColor = true;
            this.buttonShowAddedCourses.Click += new System.EventHandler(this.buttonShowAddedCourses_Click);
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.Name = "textBoxSearch";
            // 
            // buttonSearchStudent
            // 
            this.buttonSearchStudent.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.buttonSearchStudent, "buttonSearchStudent");
            this.buttonSearchStudent.Name = "buttonSearchStudent";
            this.buttonSearchStudent.UseVisualStyleBackColor = false;
            this.buttonSearchStudent.Click += new System.EventHandler(this.buttonSearchStudent_Click);
            // 
            // buttonRemoveEnrollment
            // 
            resources.ApplyResources(this.buttonRemoveEnrollment, "buttonRemoveEnrollment");
            this.buttonRemoveEnrollment.Name = "buttonRemoveEnrollment";
            this.buttonRemoveEnrollment.UseVisualStyleBackColor = true;
            this.buttonRemoveEnrollment.Click += new System.EventHandler(this.buttonRemoveEnrollment_Click);
            // 
            // buttonLogout
            // 
            resources.ApplyResources(this.buttonLogout, "buttonLogout");
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonGenerateFIle
            // 
            resources.ApplyResources(this.buttonGenerateFIle, "buttonGenerateFIle");
            this.buttonGenerateFIle.Name = "buttonGenerateFIle";
            this.buttonGenerateFIle.UseVisualStyleBackColor = true;
            this.buttonGenerateFIle.Click += new System.EventHandler(this.buttonGenerateFIle_Click);
            // 
            // textBoxExport
            // 
            resources.ApplyResources(this.textBoxExport, "textBoxExport");
            this.textBoxExport.Name = "textBoxExport";
            // 
            // OptionWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxExport);
            this.Controls.Add(this.buttonGenerateFIle);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonRemoveEnrollment);
            this.Controls.Add(this.buttonSearchStudent);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonShowAddedCourses);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonShowLecturers);
            this.Controls.Add(this.buttonShowCourses);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionWindow";
            this.Load += new System.EventHandler(this.OptionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonShowCourses;
        private System.Windows.Forms.Button buttonShowLecturers;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowAddedCourses;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchStudent;
        private System.Windows.Forms.Button buttonRemoveEnrollment;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonGenerateFIle;
        private System.Windows.Forms.TextBox textBoxExport;
    }
}