namespace DetectiveAgency
{
    partial class AdminAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccount));
            this.serviceSave = new System.Windows.Forms.Button();
            this.serviceDescription = new System.Windows.Forms.TextBox();
            this.servicePrice = new System.Windows.Forms.NumericUpDown();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.services = new System.Windows.Forms.ListBox();
            this.Запросы = new System.Windows.Forms.ListBox();
            this.requestSender = new System.Windows.Forms.Label();
            this.requestAdditional = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.isBad = new System.Windows.Forms.RadioButton();
            this.isDone = new System.Windows.Forms.RadioButton();
            this.inProcess = new System.Windows.Forms.RadioButton();
            this.inQueue = new System.Windows.Forms.RadioButton();
            this.requestDate = new System.Windows.Forms.Label();
            this.serviceDelete = new System.Windows.Forms.Button();
            this.saveToCSV = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servicePrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceSave
            // 
            this.serviceSave.Location = new System.Drawing.Point(138, 158);
            this.serviceSave.Name = "serviceSave";
            this.serviceSave.Size = new System.Drawing.Size(73, 23);
            this.serviceSave.TabIndex = 0;
            this.serviceSave.Text = "Сохранить";
            this.serviceSave.UseVisualStyleBackColor = true;
            this.serviceSave.Click += new System.EventHandler(this.serviceSave_Click);
            // 
            // serviceDescription
            // 
            this.serviceDescription.Location = new System.Drawing.Point(138, 34);
            this.serviceDescription.Multiline = true;
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.Size = new System.Drawing.Size(147, 92);
            this.serviceDescription.TabIndex = 2;
            this.serviceDescription.TextChanged += new System.EventHandler(this.serviceDescription_TextChanged);
            // 
            // servicePrice
            // 
            this.servicePrice.Location = new System.Drawing.Point(138, 135);
            this.servicePrice.Name = "servicePrice";
            this.servicePrice.Size = new System.Drawing.Size(147, 20);
            this.servicePrice.TabIndex = 3;
            this.servicePrice.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(138, 8);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(147, 20);
            this.serviceName.TabIndex = 4;
            this.serviceName.TextChanged += new System.EventHandler(this.serviceName_TextChanged);
            // 
            // services
            // 
            this.services.FormattingEnabled = true;
            this.services.Location = new System.Drawing.Point(12, 8);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(120, 173);
            this.services.TabIndex = 5;
            this.services.SelectedIndexChanged += new System.EventHandler(this.services_SelectedIndexChanged);
            // 
            // Запросы
            // 
            this.Запросы.FormattingEnabled = true;
            this.Запросы.Location = new System.Drawing.Point(291, 8);
            this.Запросы.Name = "Запросы";
            this.Запросы.Size = new System.Drawing.Size(120, 173);
            this.Запросы.TabIndex = 6;
            this.Запросы.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // requestSender
            // 
            this.requestSender.Location = new System.Drawing.Point(413, 158);
            this.requestSender.Name = "requestSender";
            this.requestSender.Size = new System.Drawing.Size(150, 23);
            this.requestSender.TabIndex = 7;
            this.requestSender.Text = "Имя отправителя";
            this.requestSender.Click += new System.EventHandler(this.label1_Click);
            // 
            // requestAdditional
            // 
            this.requestAdditional.Location = new System.Drawing.Point(414, 37);
            this.requestAdditional.Name = "requestAdditional";
            this.requestAdditional.Size = new System.Drawing.Size(149, 108);
            this.requestAdditional.TabIndex = 9;
            this.requestAdditional.Text = "Дополнительная информация";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.isBad);
            this.panel1.Controls.Add(this.isDone);
            this.panel1.Controls.Add(this.inProcess);
            this.panel1.Controls.Add(this.inQueue);
            this.panel1.Location = new System.Drawing.Point(590, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 105);
            this.panel1.TabIndex = 10;
            // 
            // isBad
            // 
            this.isBad.AutoSize = true;
            this.isBad.Location = new System.Drawing.Point(4, 74);
            this.isBad.Name = "isBad";
            this.isBad.Size = new System.Drawing.Size(104, 17);
            this.isBad.TabIndex = 3;
            this.isBad.Text = "Ложная заявка";
            this.isBad.UseVisualStyleBackColor = true;
            this.isBad.CheckedChanged += new System.EventHandler(this.isStauts_changed);
            // 
            // isDone
            // 
            this.isDone.AutoSize = true;
            this.isDone.Location = new System.Drawing.Point(4, 51);
            this.isDone.Name = "isDone";
            this.isDone.Size = new System.Drawing.Size(60, 17);
            this.isDone.TabIndex = 2;
            this.isDone.Text = "Готово";
            this.isDone.UseVisualStyleBackColor = true;
            this.isDone.CheckedChanged += new System.EventHandler(this.isStauts_changed);
            // 
            // inProcess
            // 
            this.inProcess.AutoSize = true;
            this.inProcess.Location = new System.Drawing.Point(3, 26);
            this.inProcess.Name = "inProcess";
            this.inProcess.Size = new System.Drawing.Size(85, 17);
            this.inProcess.TabIndex = 1;
            this.inProcess.Text = "В Процессе";
            this.inProcess.UseVisualStyleBackColor = true;
            this.inProcess.CheckedChanged += new System.EventHandler(this.isStauts_changed);
            // 
            // inQueue
            // 
            this.inQueue.AutoSize = true;
            this.inQueue.Checked = true;
            this.inQueue.Location = new System.Drawing.Point(3, 3);
            this.inQueue.Name = "inQueue";
            this.inQueue.Size = new System.Drawing.Size(78, 17);
            this.inQueue.TabIndex = 0;
            this.inQueue.TabStop = true;
            this.inQueue.Text = "В Очереди";
            this.inQueue.UseVisualStyleBackColor = true;
            this.inQueue.CheckedChanged += new System.EventHandler(this.isStauts_changed);
            // 
            // requestDate
            // 
            this.requestDate.Location = new System.Drawing.Point(414, 11);
            this.requestDate.Name = "requestDate";
            this.requestDate.Size = new System.Drawing.Size(150, 23);
            this.requestDate.TabIndex = 11;
            this.requestDate.Text = "Дата запроса";
            // 
            // serviceDelete
            // 
            this.serviceDelete.Location = new System.Drawing.Point(212, 158);
            this.serviceDelete.Name = "serviceDelete";
            this.serviceDelete.Size = new System.Drawing.Size(73, 23);
            this.serviceDelete.TabIndex = 12;
            this.serviceDelete.Text = "Удалить";
            this.serviceDelete.UseVisualStyleBackColor = true;
            this.serviceDelete.Click += new System.EventHandler(this.serviceDelete_Click);
            // 
            // saveToCSV
            // 
            this.saveToCSV.Location = new System.Drawing.Point(414, 190);
            this.saveToCSV.Name = "saveToCSV";
            this.saveToCSV.Size = new System.Drawing.Size(149, 23);
            this.saveToCSV.TabIndex = 13;
            this.saveToCSV.Text = "Сохранить в CSV";
            this.saveToCSV.UseVisualStyleBackColor = true;
            this.saveToCSV.Click += new System.EventHandler(this.saveToCSV_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 188);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(120, 23);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Загрузить...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DetectiveAgency.Properties.Resources.Darkside_Detective_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 373);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveToCSV);
            this.Controls.Add(this.serviceDelete);
            this.Controls.Add(this.requestDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.requestAdditional);
            this.Controls.Add(this.requestSender);
            this.Controls.Add(this.Запросы);
            this.Controls.Add(this.services);
            this.Controls.Add(this.serviceName);
            this.Controls.Add(this.servicePrice);
            this.Controls.Add(this.serviceDescription);
            this.Controls.Add(this.serviceSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAccount";
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.servicePrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serviceSave;
        private System.Windows.Forms.TextBox serviceDescription;
        private System.Windows.Forms.NumericUpDown servicePrice;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.ListBox services;
        private System.Windows.Forms.ListBox Запросы;
        private System.Windows.Forms.Label requestSender;
        private System.Windows.Forms.Label requestAdditional;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton isBad;
        private System.Windows.Forms.RadioButton isDone;
        private System.Windows.Forms.RadioButton inProcess;
        private System.Windows.Forms.RadioButton inQueue;
        private System.Windows.Forms.Label requestDate;
        private System.Windows.Forms.Button serviceDelete;
        private System.Windows.Forms.Button saveToCSV;
        private System.Windows.Forms.Button loadButton;
    }
}