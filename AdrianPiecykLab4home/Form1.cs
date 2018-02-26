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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// sprawdzenie jezeli text box ktorys jest nieuzupelniony wyswietli sie komunikat jesli jest wszystko wpisane wyswietli sie nowe okno z dokonczeniem rejestracji gdy ja zakonczymy okno sie zamknie a otworzy nowe z oknem opcji
            /// </summary>
            if (textBoxLogin.Text!="" && textBoxPassword.Text !="")
            {
                MessageBox.Show("Dokończ Rejestracje Uzupełnij podane pola", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Question);
                UserRegistration window = new UserRegistration();
                window.Show();
                this.Hide();
 
            }
            else
            {
                MessageBox.Show("Zły Login lub Hasło", "Sprobuj jeszcze raz", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
