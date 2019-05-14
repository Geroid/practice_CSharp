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
    public partial class MyAccount : Form
    {
        private Account user;
        private Request newRequest = new Request();
        private AppContext context;

        Service[] services;

        public MyAccount(object user)
        {
            InitializeComponent();
            this.user = user as Account;
            helloLabel.Text = $"Добро пожаловать, {this.user.FirstName} {this.user.LastName}!";
            context = new AppContext();

            services = context.Services.ToArray();
            foreach(var service in services)
            {
                seviceComboBox.Items.Add($"{service.name} - Цена: {service.price}");
            }

            Request[] requests = context.Requests.Where<Request>(x => x.senderId == this.user.id).ToArray();
            foreach(var request in requests)
            {
                requestsBox.Items.Add($"{context.Services.First(x => x.Id == request.serviceId).name} {request.date.ToShortDateString()} {request.status.ToString()}");
            }

            newRequest = new Request()
            {
                senderId = this.user.id,
                additionalInfo = "",
                status = Request.RequestStatus.inQueue,
                date = DateTime.Now
            };
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            new WriteReview(user).Show();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            context.Requests.Add(newRequest);
            context.SaveChanges();
        }

        private void seviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newRequest.serviceId = services[seviceComboBox.SelectedIndex].Id;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newRequest.additionalInfo = textBox1.Text;
        }

        private void requestsBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BloglinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewsBlog nBlog = new NewsBlog();
            nBlog.Show();
        }
    }
}
