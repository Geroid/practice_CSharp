namespace DetectiveAgency
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.reviewsButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationButton = new System.Windows.Forms.Button();
            this.authButton = new System.Windows.Forms.Button();
            this.priceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewsButton
            // 
            resources.ApplyResources(this.reviewsButton, "reviewsButton");
            this.reviewsButton.Name = "reviewsButton";
            this.reviewsButton.UseVisualStyleBackColor = true;
            this.reviewsButton.Click += new System.EventHandler(this.reviewsButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAgencyToolStripMenuItem,
            this.licenseToolStripMenuItem,
            this.contactDetailsToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            resources.ApplyResources(this.informationToolStripMenuItem, "informationToolStripMenuItem");
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // aboutAgencyToolStripMenuItem
            // 
            this.aboutAgencyToolStripMenuItem.Name = "aboutAgencyToolStripMenuItem";
            resources.ApplyResources(this.aboutAgencyToolStripMenuItem, "aboutAgencyToolStripMenuItem");
            this.aboutAgencyToolStripMenuItem.Click += new System.EventHandler(this.aboutAgencyToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            resources.ApplyResources(this.licenseToolStripMenuItem, "licenseToolStripMenuItem");
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            resources.ApplyResources(this.contactDetailsToolStripMenuItem, "contactDetailsToolStripMenuItem");
            this.contactDetailsToolStripMenuItem.Click += new System.EventHandler(this.contactDetailsToolStripMenuItem_Click);
            // 
            // registrationButton
            // 
            resources.ApplyResources(this.registrationButton, "registrationButton");
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // authButton
            // 
            resources.ApplyResources(this.authButton, "authButton");
            this.authButton.Name = "authButton";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // priceButton
            // 
            resources.ApplyResources(this.priceButton, "priceButton");
            this.priceButton.Name = "priceButton";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DetectiveAgency.Properties.Resources.cityscape_pixel_art_sunlight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.reviewsButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reviewsButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAgencyToolStripMenuItem;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

