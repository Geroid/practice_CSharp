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
    public partial class ServisesAndPrices : Form
    {
        public ServisesAndPrices()
        {
            InitializeComponent();
            using(AppContext context = new AppContext())
            {
                listBox1.Items.AddRange(context.Services.ToArray());
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem as Service).description;

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
