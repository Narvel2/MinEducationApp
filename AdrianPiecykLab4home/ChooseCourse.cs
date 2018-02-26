using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdrianPiecykLab4home
{
    public partial class ChooseCourse : Form
    {
       
        AdrianPiecykLab4homeDataContext obj = new AdrianPiecykLab4homeDataContext();
        Student newStudent = new Student();

        public ChooseCourse(Student copy)
        {
            
            InitializeComponent();
            newStudent = copy;

        }

        /// <summary>
        /// Wybieranie kursu w textBoxie
        /// </summary>
        private void ChooseCourse_Load(object sender, EventArgs e)
        {
            var itemCourse = obj.Courses;
            comboBoxChooseCourse.DataSource = itemCourse;
            comboBoxChooseCourse.DisplayMember = "NameOfCourse";
            var itemLecturer = obj.Lecturers;
            comboBoxChooseLecturer.DataSource = itemLecturer;
            comboBoxChooseLecturer.DisplayMember = "Surname";
            timerClock.Start();
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }
   
        private void buttonSave_Click(object sender, EventArgs e)
        {   
            ///Do tabeli Enrollment odpowiednim rekordom przypisuje wartosci wybrane w comboboxie
            var courseToAdd = comboBoxChooseCourse.SelectedItem;
            Enrollment newEnrollment = new Enrollment();
            newEnrollment.CoursesID = (courseToAdd as Course).ID;   
            var lecturerToAdd = comboBoxChooseLecturer.SelectedItem;
            newEnrollment.LecturersID = (lecturerToAdd as Lecturer).ID;
            newEnrollment.StudentID = newStudent.ID;
            newEnrollment.Data = labelTime.Text+" "+labelDate.Text;
            obj.Enrollments.InsertOnSubmit(newEnrollment);
            obj.SubmitChanges();
            MessageBox.Show("Udało się zapisać na kurs możesz \t\n możesz to sprawdzić w odpowiedniej zakładce", "Good", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();

        }
        /// <summary>
        /// Timer do obslugi aktualnego czasu i daty
        /// </summary>
        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timerClock.Start();
        }
    }
}
