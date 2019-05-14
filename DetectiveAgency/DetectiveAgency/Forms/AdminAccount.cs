using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectiveAgency
{
    public partial class AdminAccount : Form
    {
        private Service editedService = new Service();
        private AppContext context;
        private List<Service> servicesArray;
        private Service newService = new Service()
        {
            name = "Новая услуга"
        };
        private Request editedRequest = new Request();
        private Request[] requestsArray;

        public AdminAccount()
        {
            InitializeComponent();
            editedService = newService;
            context = new AppContext();

            UpdateServices();

            requestsArray = context.Requests.ToArray();
            foreach(var request in requestsArray)
            {
                Запросы.Items.Add($"{context.Services.First(x => x.Id == request.serviceId).name}");
            }
        }


        private void UpdateServices()
        {
            services.Items.Clear();
            servicesArray = context.Services.ToList();
            servicesArray.Add(newService);
            foreach (var service in servicesArray)
            {
                services.Items.Add($"{service.name}");
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            editedService.price = (int)servicePrice.Value;
        }

        private void serviceSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (editedService != null)
                {
                    if (editedService == newService)
                    {
                        context.Entry(editedService).State = System.Data.Entity.EntityState.Added;
                        MessageBox.Show("Отлично, новый сервис добавлен!");
                    }
                    else
                    {
                        context.Entry(editedService).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Отлично, сервис обновлен!");
                    }
                    context.SaveChanges();
                    UpdateServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0} Exception", ex.ToString());
            }
            
        }

        private void services_SelectedIndexChanged(object sender, EventArgs e)
        {
            editedService = servicesArray[services.SelectedIndex];
            serviceName.Text = editedService.name;
            serviceDescription.Text = editedService.description;
            servicePrice.Value = editedService.price;
        }

        private void serviceName_TextChanged(object sender, EventArgs e)
        {
            editedService.name = serviceName.Text;
        }

        private void serviceDescription_TextChanged(object sender, EventArgs e)
        {
            editedService.description = serviceDescription.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void isStauts_changed(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button.Checked)
            {
                if (button == inQueue)
                {
                    editedRequest.status = Request.RequestStatus.inQueue;
                }
                if (button == inProcess)
                {
                    editedRequest.status = Request.RequestStatus.inProces;
                }
                if (button == isDone)
                {
                    editedRequest.status = Request.RequestStatus.isDone;
                }
                if (button == isBad)
                {
                    editedRequest.status = Request.RequestStatus.isBad;
                }
            }
            context.Entry(editedRequest).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editedRequest = requestsArray[Запросы.SelectedIndex];
            Account senderAccount = context.Accounts.First(x => x.id == editedRequest.senderId);
            requestSender.Text = $"{senderAccount.FirstName} {senderAccount.LastName}";
            requestAdditional.Text = editedRequest.additionalInfo;
            requestDate.Text = editedRequest.date.ToLongDateString();
            switch (editedRequest.status)
            {
                case Request.RequestStatus.inProces:
                    inProcess.Checked = true;
                    break;
                case Request.RequestStatus.inQueue:
                    inQueue.Checked = true;
                    break;
                case Request.RequestStatus.isDone:
                    isDone.Checked = true;
                    break;
                case Request.RequestStatus.isBad:
                    isBad.Checked = true;
                    break;
            }
        }

        private void serviceDelete_Click(object sender, EventArgs e)
        {
            if(editedService == newService)
            {
                MessageBox.Show("Нельзя удалить то, чего нет");
            }
            else
            {
                if(MessageBox.Show("Удалить?","Удаление сервиса", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Request[] del = context.Requests.Where(x => x.serviceId == editedService.Id).ToArray();
                    foreach(var a in del)
                    {
                        context.Requests.Remove(a);
                    }
                    context.Services.Remove(editedService);
                    context.SaveChanges();
                    UpdateServices();
                }
            }
        }

        private void saveToCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(dialog.OpenFile(), Encoding.UTF8);
                    writer.WriteLine($"serviceId,additionalinfo,senderId,status,date");
                    foreach(var r in requestsArray)
                    {
                        writer.WriteLine($"{r.serviceId},{r.additionalInfo},{r.senderId},{r.status},{'"'+r.date.ToLongDateString()+'"'}");
                    }
                    writer.Flush();
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(dialog.OpenFile());
                    while(!reader.EndOfStream)
                    {
                        string result = reader.ReadLine();
                        string[] args = result.Split(',');

                        
                    }
                }
            }
        }
    }
}
