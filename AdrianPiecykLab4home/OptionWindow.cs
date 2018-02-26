using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace AdrianPiecykLab4home
{
    public partial class OptionWindow : Form
    {
        /// <summary>
        /// Otwieranie LINQ
        /// </summary>
        AdrianPiecykLab4homeDataContext dc = new AdrianPiecykLab4homeDataContext();
        Student stud = new Student();
        public OptionWindow(Student stu)
        {
            InitializeComponent();
            stud = stu;
        }

        /// <summary>
        /// Pokazywanie wykladowcow
        /// </summary>
        private void buttonShowLecturers_Click(object sender, EventArgs e)
        {
            var lecturers = from lecturer in dc.Lecturers select new { Nazwa = lecturer.Name, Surname = lecturer.Surname, Degree = lecturer.Degree };
            dataGridViewShow.DataSource = lecturers;
            labelInfo.Text = "Oto wszyscy prowadzący";

        }
        /// <summary>
        /// Pokazywanie Kursow
        /// </summary>
        private void buttonShowCourses_Click(object sender, EventArgs e)
        {
            var courses = from course in dc.Courses select new { NameOfCourse = course.NameOfCourse, ECTSPoints = course.ECTSPoints, CourseHours = course.CourseHours, PlacesID = course.Place.Building };
            dataGridViewShow.DataSource = courses;
            labelInfo.Text = "Oto wszystkie kursy";
        }
        /// <summary>
        /// Tworzenie nowego okna i przekazywanie obiektu w konstruktorze
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ChooseCourse chooseCourse = new ChooseCourse(stud);
            chooseCourse.Show();
        }
        /// <summary>
        /// Wyswietlanie w dataGridView
        /// </summary>
        public void ShowAdded()
        {
            var enroll = from enr in dc.Enrollments select new { StudentID = enr.Student.Name, CoursesID = (enr.Course.NameOfCourse + " ," + enr.Course.ECTSPoints + " pkt ECTS ," + enr.Course.CourseHours + " godz zajęć "), LecturerID = (enr.Lecturer.Name + " " + enr.Lecturer.Surname + " " + enr.Lecturer.Degree), Data = enr.Data, };
            dataGridViewShow.DataSource = enroll;

        }

        /// <summary>
        /// Wyswietlanie
        /// </summary>
        private void buttonShowAddedCourses_Click(object sender, EventArgs e)
        {
            ShowAdded();
        }
        /// <summary>
        /// Wyszukiwanie studenta po imieniu lub nazwisku wpisywanym w textboxie
        /// </summary>
        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            var searchStudent = from student in dc.Students where student.Name == textBoxSearch.Text || student.Surname == textBoxSearch.Text select student;
            dataGridViewShow.DataSource = searchStudent;
        }
        /// <summary>
        /// Usuwanie obecnego Enrollmenta zarowno z bazy jak i datagridview
        /// </summary>
        private void buttonRemoveEnrollment_Click(object sender, EventArgs e)
        {
            Enrollment user = (from element in dc.Enrollments
                               where element.StudentID != null
                               orderby element.ID descending
                               select element).FirstOrDefault();

            dc.Enrollments.DeleteOnSubmit(user);
            dc.SubmitChanges();

            ShowAdded();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Tworzenie pliku csv i do ktorego wrzucam dataGridView obecne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenerateFIle_Click(object sender, EventArgs e)
        {
            int count_row = dataGridViewShow.RowCount;
            int count_cell = dataGridViewShow.Rows[0].Cells.Count;

            for (int row_index = 0; row_index <= count_row - 2; row_index++)
            {
                for (int cell_index = 0; cell_index <= count_cell - 1; cell_index++)
                {             
                    textBoxExport.Text = textBoxExport.Text + dataGridViewShow.Rows[row_index].Cells[cell_index].Value.ToString() + " ";
                }
                textBoxExport.Text = textBoxExport.Text + "\r\n";

            }
            System.IO.File.WriteAllText(@"c:\Users\Adrian\Desktop\c# dane\export.csv", textBoxExport.Text);
            MessageBox.Show("Udało się zapisać,Gratulacje", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void OptionWindow_Load(object sender, EventArgs e)
        {
        
        }
    }
}