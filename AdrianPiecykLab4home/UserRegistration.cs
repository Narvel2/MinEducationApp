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
    public partial class UserRegistration : Form
    {
        /// <summary>
        /// umozliwienie korzystania z bazy danych
        /// </summary>
        AdrianPiecykLab4homeDataContext context = new AdrianPiecykLab4homeDataContext();
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
           
            /// <summary>
            /// Tworzenie nowego studenta i wpisywanie do bazy danych wartosci ktore odpowiednio znajduja sie w textBoxach
            /// </summary>
            Student student = new Student();
            student.Name = textBoxName.Text;
            student.Surname = textBoxSurname.Text;
            student.Sex = textBoxSex.Text;
            student.StudentNumber = textBoxStudentNumber.Text;
            student.Street = textBoxStreet.Text;
            student.DateOfBirth =textBoxDateOfBirth.Text;
            student.PESEL = textBoxPesel.Text;
            student.Email = textBoxEmail.Text;
            student.NameOfMother = textBoxNameOfMother.Text;
            student.NameOfFather = textBoxNameOfFather.Text;
            student.PlaceOfResistance = textBoxPlaceOfResistance.Text;
            student.NumberOfHouse =textBoxNumberOfHouse.Text;
            student.Voivodeship = textBoxVoivodeship.Text;
            context.Students.InsertOnSubmit(student);
            context.SubmitChanges();
            MessageBox.Show("Studencie jesteś już w naszej bazie danych", "Good", MessageBoxButtons.OK, MessageBoxIcon.Question);
            OptionWindow optionwindow = new OptionWindow(student);
            optionwindow.Show();
            this.Hide();
        

        }
    }
}
