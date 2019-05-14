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
    public partial class CheckReviews : Form
    {
        private Review[] reviews;
        private int currentIndex = 0;
        private AppContext context;

        public CheckReviews()
        {
            InitializeComponent();
            context = new AppContext();
            reviews = context.Reviews.ToArray();
            DrawReview();
        }
        private void DrawReview()
        {
            textLabel.Text = reviews[currentIndex].text;
            dateLabel.Text = reviews[currentIndex].date.ToShortDateString();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= reviews.Length) currentIndex = 0;
            DrawReview();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = reviews.Length - 1;
            DrawReview();
        }
    }
}
