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
    public partial class NewsBlog : Form
    {
        public NewsBlog()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
