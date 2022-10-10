using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Success_App
{
    public partial class Login_Form : Form
    {
        static private string username = "admin";
        static private string password = "password";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == username && textBox_password.Text == password)
            { 
                Advisor_Form advisor_form = new Advisor_Form();
                advisor_form.update_gpa(4.5);
                advisor_form.Show();
                this.Close();
            }
            else lbl_login_status.Text = "Invalid username or password! Please retry.";
        }

        private void btn_hint_Click(object sender, EventArgs e)
        {
            lbl_login_status.Text = "Username is admin, Password is password :)";
        }
    }
}
