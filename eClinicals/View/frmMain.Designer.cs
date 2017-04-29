namespace eClinicals.View
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTop = new System.Windows.Forms.Panel();
            this.pMiddle = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.cmsNurse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateReporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ucAppointmentSummary = new eClinicals.View.ucAppointmentSummary();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.pMiddle.SuspendLayout();
            this.cmsNurse.SuspendLayout();
            this.cmsAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 728);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1184, 22);
            this.statusStripMain.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Enabled = false;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1184, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenuToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // startMenuToolStripMenuItem
            // 
            this.startMenuToolStripMenuItem.Name = "startMenuToolStripMenuItem";
            this.startMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.startMenuToolStripMenuItem.Text = "&Start Menu";
            this.startMenuToolStripMenuItem.Click += new System.EventHandler(this.startMenuToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pTop
            // 
            this.pTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 24);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1184, 104);
            this.pTop.TabIndex = 10;
            this.pTop.Visible = false;
            // 
            // pMiddle
            // 
            this.pMiddle.BackColor = System.Drawing.Color.White;
            this.pMiddle.BackgroundImage = global::eClinicals.Properties.Resources.eclinicalLogo;
            this.pMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pMiddle.Controls.Add(this.ucAppointmentSummary);
            this.pMiddle.Controls.Add(this.pRight);
            this.pMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMiddle.Location = new System.Drawing.Point(0, 128);
            this.pMiddle.Name = "pMiddle";
            this.pMiddle.Size = new System.Drawing.Size(1184, 600);
            this.pMiddle.TabIndex = 12;
            // 
            // pRight
            // 
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(984, 0);
            this.pRight.Margin = new System.Windows.Forms.Padding(0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(200, 600);
            this.pRight.TabIndex = 0;
            // 
            // cmsNurse
            // 
            this.cmsNurse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.cmsNurse.Name = "contextMenuStrip1";
            this.cmsNurse.Size = new System.Drawing.Size(138, 70);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.testToolStripMenuItem.Text = "Registration";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // nurseNotification
            // 
            this.nurseNotification.ContextMenuStrip = this.cmsNurse;
            this.nurseNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("nurseNotification.Icon")));
            this.nurseNotification.Visible = true;
            this.nurseNotification.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // cmsAdmin
            // 
            this.cmsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReporToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsAdmin.Name = "cmsAdmin";
            this.cmsAdmin.Size = new System.Drawing.Size(160, 70);
            // 
            // generateReporToolStripMenuItem
            // 
            this.generateReporToolStripMenuItem.Name = "generateReporToolStripMenuItem";
            this.generateReporToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateReporToolStripMenuItem.Text = "Generate Report";
            this.generateReporToolStripMenuItem.Click += new System.EventHandler(this.generateReporToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminNotification
            // 
            this.adminNotification.ContextMenuStrip = this.cmsAdmin;
            this.adminNotification.Text = "notifyIcon1";
            this.adminNotification.Visible = true;
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // ucAppointmentSummary
            // 
            this.ucAppointmentSummary.BackColor = System.Drawing.Color.White;
            this.ucAppointmentSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAppointmentSummary.Location = new System.Drawing.Point(0, 0);
            this.ucAppointmentSummary.Name = "ucAppointmentSummary";
            this.ucAppointmentSummary.Size = new System.Drawing.Size(984, 600);
            this.ucAppointmentSummary.TabIndex = 1;
            this.ucAppointmentSummary.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::eClinicals.Properties.Resources.eclinicalLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.Controls.Add(this.pMiddle);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1042, 726);
            this.Name = "frmMain";
            this.Text = "eClinicals";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.pMiddle.ResumeLayout(false);
            this.cmsNurse.ResumeLayout(false);
            this.cmsAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStripMain;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStripMain;
        public System.Windows.Forms.Panel pMiddle;
        public System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.ToolStripMenuItem startMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        public ucAppointmentSummary ucAppointmentSummary;
        private System.Windows.Forms.ContextMenuStrip cmsNurse;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon nurseNotification;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsAdmin;
        private System.Windows.Forms.ToolStripMenuItem generateReporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon adminNotification;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}