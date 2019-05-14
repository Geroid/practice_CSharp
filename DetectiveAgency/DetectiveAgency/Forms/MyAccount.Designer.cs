namespace DetectiveAgency
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.reviewButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.seviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.requestsBox = new System.Windows.Forms.ListBox();
            this.BloglinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(543, 407);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(123, 23);
            this.reviewButton.TabIndex = 0;
            this.reviewButton.Text = "Оставить отзыв";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(12, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(0, 13);
            this.helloLabel.TabIndex = 1;
            // 
            // seviceComboBox
            // 
            this.seviceComboBox.FormattingEnabled = true;
            this.seviceComboBox.Location = new System.Drawing.Point(15, 73);
            this.seviceComboBox.Name = "seviceComboBox";
            this.seviceComboBox.Size = new System.Drawing.Size(223, 21);
            this.seviceComboBox.TabIndex = 2;
            this.seviceComboBox.SelectedIndexChanged += new System.EventHandler(this.seviceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дополнительная информация";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 171);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(163, 290);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбирите услугу";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(299, 97);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Обращения";
            // 
            // requestsBox
            // 
            this.requestsBox.FormattingEnabled = true;
            this.requestsBox.Location = new System.Drawing.Point(302, 113);
            this.requestsBox.Name = "requestsBox";
            this.requestsBox.Size = new System.Drawing.Size(226, 173);
            this.requestsBox.TabIndex = 8;
            this.requestsBox.SelectedIndexChanged += new System.EventHandler(this.requestsBox_SelectedIndexChanged);
            // 
            // BloglinkLabel
            // 
            this.BloglinkLabel.AutoSize = true;
            this.BloglinkLabel.LinkColor = System.Drawing.Color.SeaGreen;
            this.BloglinkLabel.Location = new System.Drawing.Point(371, 36);
            this.BloglinkLabel.Name = "BloglinkLabel";
            this.BloglinkLabel.Size = new System.Drawing.Size(88, 13);
            this.BloglinkLabel.TabIndex = 9;
            this.BloglinkLabel.TabStop = true;
            this.BloglinkLabel.Text = "Новостной блог";
            this.BloglinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BloglinkLabel_LinkClicked);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DetectiveAgency.Properties.Resources.DFVNu_uWsAEp9lO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 442);
            this.Controls.Add(this.BloglinkLabel);
            this.Controls.Add(this.requestsBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seviceComboBox);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.reviewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyAccount";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.ComboBox seviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox requestsBox;
        private System.Windows.Forms.LinkLabel BloglinkLabel;
    }
}