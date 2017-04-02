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
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTop = new System.Windows.Forms.Panel();
            this.pMiddle = new System.Windows.Forms.Panel();
            this.pRight = new System.Windows.Forms.Panel();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.pMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 720);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1026, 22);
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
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1026, 24);
            this.menuStripMain.TabIndex = 8;
            this.menuStripMain.Text = "menuStrip1";
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
            this.startMenuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startMenuToolStripMenuItem.Text = "&Start Menu";
            this.startMenuToolStripMenuItem.Click += new System.EventHandler(this.startMenuToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // pTop
            // 
            this.pTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 24);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1026, 104);
            this.pTop.TabIndex = 10;
            this.pTop.Visible = false;
            // 
            // pMiddle
            // 
            this.pMiddle.BackColor = System.Drawing.Color.White;
            this.pMiddle.BackgroundImage = global::eClinicals.Properties.Resources.eclinicalLogo;
            this.pMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pMiddle.Controls.Add(this.pRight);
            this.pMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMiddle.Location = new System.Drawing.Point(0, 128);
            this.pMiddle.Name = "pMiddle";
            this.pMiddle.Size = new System.Drawing.Size(1026, 592);
            this.pMiddle.TabIndex = 12;
            // 
            // pRight
            // 
            this.pRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRight.Location = new System.Drawing.Point(826, 0);
            this.pRight.Margin = new System.Windows.Forms.Padding(0);
            this.pRight.Name = "pRight";
            this.pRight.Size = new System.Drawing.Size(200, 592);
            this.pRight.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::eClinicals.Properties.Resources.eclinicalLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1026, 742);
            this.Controls.Add(this.pMiddle);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximumSize = new System.Drawing.Size(1042, 800);
            this.MinimumSize = new System.Drawing.Size(1042, 600);
            this.Name = "frmMain";
            this.Text = "eClinicals";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.pMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStripMain;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStripMain;      
        public System.Windows.Forms.Panel pMiddle;
        public System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Panel pRight;
        private System.Windows.Forms.ToolStripMenuItem startMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}