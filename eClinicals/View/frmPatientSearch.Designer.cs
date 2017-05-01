namespace eClinicals.View
{
    partial class frmPatientSearch
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
            this.lblErrorTitle = new System.Windows.Forms.Label();
            this.picNoUserFound = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate_FirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNoUserFound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorTitle
            // 
            this.lblErrorTitle.BackColor = System.Drawing.Color.White;
            this.lblErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblErrorTitle.Location = new System.Drawing.Point(130, 140);
            this.lblErrorTitle.Name = "lblErrorTitle";
            this.lblErrorTitle.Size = new System.Drawing.Size(404, 31);
            this.lblErrorTitle.TabIndex = 105;
            this.lblErrorTitle.Text = " Tester";
            this.lblErrorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorTitle.Visible = false;
            // 
            // picNoUserFound
            // 
            this.picNoUserFound.Image = global::eClinicals.Properties.Resources.NoUserFound;
            this.picNoUserFound.Location = new System.Drawing.Point(12, 94);
            this.picNoUserFound.Name = "picNoUserFound";
            this.picNoUserFound.Size = new System.Drawing.Size(547, 227);
            this.picNoUserFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNoUserFound.TabIndex = 107;
            this.picNoUserFound.TabStop = false;
            this.picNoUserFound.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(195, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search By";
            // 
            // lblDate_FirstName
            // 
            this.lblDate_FirstName.AutoSize = true;
            this.lblDate_FirstName.Location = new System.Drawing.Point(192, 27);
            this.lblDate_FirstName.Name = "lblDate_FirstName";
            this.lblDate_FirstName.Size = new System.Drawing.Size(92, 13);
            this.lblDate_FirstName.TabIndex = 7;
            this.lblDate_FirstName.Text = "Appointment Date";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(411, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 13);
            this.lblLastName.TabIndex = 101;
            this.lblLastName.Text = "Patient Last Name";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(578, 346);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(106, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(15, 94);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.Size = new System.Drawing.Size(544, 227);
            this.dgvSearchResults.TabIndex = 5;
            this.dgvSearchResults.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(578, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;

            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(414, 53);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(195, 53);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 9, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(1990, 12, 9, 0, 0, 0, 0);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "DOB/NAME",
            "Date of Birth",
            "Name"});
            this.cbSearch.Location = new System.Drawing.Point(31, 53);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(119, 21);
            this.cbSearch.TabIndex = 0;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.BackColor = System.Drawing.Color.White;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblErrorMessage.Location = new System.Drawing.Point(131, 204);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(408, 71);
            this.lblErrorMessage.TabIndex = 110;
            this.lblErrorMessage.Visible = false;
            // 
            // frmPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 381);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblErrorTitle);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDate_FirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.picNoUserFound);
            this.Controls.Add(this.dgvSearchResults);
            this.Name = "frmPatientSearch";
            this.Text = "Search Patient by ...";
            this.Load += new System.EventHandler(this.frmPatientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNoUserFound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnOpen;
        public System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDate_FirstName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbSearch;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.DataGridView dgvSearchResults;
        public System.Windows.Forms.Label lblErrorTitle;
        private System.Windows.Forms.PictureBox picNoUserFound;
        public System.Windows.Forms.Label lblErrorMessage;
    }
}