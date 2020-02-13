using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoHelper;
using LLIB.Models;
using LLIB.Data;




namespace LLIB.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LLIB.Data.LibraryContext _context;

        public LoginForm()
        {
            _context = new LibraryContext();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = Crypto.HashPassword("123123");


        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtMail.Text))
            {
                MessageBox.Show("E-poçt yazın");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))

            {

                MessageBox.Show("Şifrə yazın");
                return;
            }
            User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtMail.Text);
            if (user != null && Crypto.VerifyHashedPassword(user.Password, TxtPassword.Text)) ;
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Hide();
                return;
            }

            MessageBox.Show("E-poçt və ya şifrə yanlışdır");
        }
    

    


    
    
















        
    }
}










        
    

