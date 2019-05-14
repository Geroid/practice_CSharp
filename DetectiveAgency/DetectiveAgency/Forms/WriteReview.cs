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
    public partial class WriteReview : Form
    {
        private Account user;
        public WriteReview()
        {
            InitializeComponent();
        }
        public WriteReview(object user)
        {
            InitializeComponent();
            this.user = user as Account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(AppContext context = new AppContext())
            {
                Review r = new Review()
                {
                    text = textBox.Text,
                    date = DateTime.Now,
                };
                context.Reviews.Add(r);
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
