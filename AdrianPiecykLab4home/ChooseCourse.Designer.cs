namespace AdrianPiecykLab4home
{
    partial class ChooseCourse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCourse));
            this.comboBoxChooseCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseLecturer = new System.Windows.Forms.ComboBox();
            this.labelChooseCourse = new System.Windows.Forms.Label();
            this.labelChooseLecturer = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBoxChooseCourse
            // 
            this.comboBoxChooseCourse.FormattingEnabled = true;
            this.comboBoxChooseCourse.Location = new System.Drawing.Point(228, 106);
            this.comboBoxChooseCourse.Name = "comboBoxChooseCourse";
            this.comboBoxChooseCourse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseCourse.TabIndex = 0;
            // 
            // comboBoxChooseLecturer
            // 
            this.comboBoxChooseLecturer.FormattingEnabled = true;
            this.comboBoxChooseLecturer.Location = new System.Drawing.Point(228, 150);
            this.comboBoxChooseLecturer.Name = "comboBoxChooseLecturer";
            this.comboBoxChooseLecturer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseLecturer.TabIndex = 1;
            // 
            // labelChooseCourse
            // 
            this.labelChooseCourse.AutoSize = true;
            this.labelChooseCourse.Location = new System.Drawing.Point(154, 109);
            this.labelChooseCourse.Name = "labelChooseCourse";
            this.labelChooseCourse.Size = new System.Drawing.Size(68, 13);
            this.labelChooseCourse.TabIndex = 3;
            this.labelChooseCourse.Text = "Wybierz kurs";
            // 
            // labelChooseLecturer
            // 
            this.labelChooseLecturer.AutoSize = true;
            this.labelChooseLecturer.Location = new System.Drawing.Point(104, 153);
            this.labelChooseLecturer.Name = "labelChooseLecturer";
            this.labelChooseLecturer.Size = new System.Drawing.Size(118, 13);
            this.labelChooseLecturer.TabIndex = 4;
            this.labelChooseLecturer.Text = "Wybierz prowadzącego";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(246, 193);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Zapisz wybór";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(50, 322);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(154, 322);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 13);
            this.labelDate.TabIndex = 9;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // ChooseCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 372);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelChooseLecturer);
            this.Controls.Add(this.labelChooseCourse);
            this.Controls.Add(this.comboBoxChooseLecturer);
            this.Controls.Add(this.comboBoxChooseCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseCourse";
            this.Text = "ChooseCourse";
            this.Load += new System.EventHandler(this.ChooseCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseCourse;
        private System.Windows.Forms.ComboBox comboBoxChooseLecturer;
        private System.Windows.Forms.Label labelChooseCourse;
        private System.Windows.Forms.Label labelChooseLecturer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerClock;
    }
}