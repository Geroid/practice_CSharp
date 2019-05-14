using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DetectiveAgency
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                Account newAccount = new Account()
                {
                    FirstName = this.FirstNameTextBox.Text,
                    LastName = this.LastNameTextBox.Text,
                    Username = this.LoginTextBox.Text,
                    Password = this.PasswordTextBox.Text,
                    Email = this.EmailTextBox.Text,
                    PhoneNumber = this.PhoneTextBox.Text,
                    Role = RoleEnum.user
                };
                context.Accounts.Add(newAccount);
                context.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно!");
            }
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
