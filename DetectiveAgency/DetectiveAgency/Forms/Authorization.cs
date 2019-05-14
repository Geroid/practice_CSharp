using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectiveAgency
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void authorizateButton_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                Account user = context.Accounts.AsNoTracking().FirstOrDefault(x => x.Username == this.LoginTextBox.Text && x.Password == this.PasswordTextBox.Text);
                if(user == null)
                {
                    MessageBox.Show("Неверный логин или пароль","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                switch (user.Role)
                {
                    case RoleEnum.user:
                        new MyAccount(user).Show();
                        break;
                    case RoleEnum.admin:
                        new AdminAccount().Show();
                        break;
                }
                this.Close();

            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
