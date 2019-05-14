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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Authorization authForm = new Authorization();
            authForm.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoAboutAgency infoForm = new InfoAboutAgency();
            infoForm.Show();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            Registration regForm = new Registration();
            regForm.Show();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            ServisesAndPrices servisesForm = new ServisesAndPrices();
            servisesForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, EventArgs e)
        {

        }

        private void reviewsButton_Click(object sender, EventArgs e)
        {
            CheckReviews reviewsForm = new CheckReviews();
            reviewsForm.Show();
        }

        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactDetails contactForm = new ContactDetails();
            contactForm.Show();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchLicense licenseForm = new WatchLicense();
            licenseForm.Show();
        }
    }
}
