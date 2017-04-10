namespace eClinicals.View
{
    partial class frmRegistration
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
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError_firstName = new System.Windows.Forms.Label();
            this.lblError_lastName = new System.Windows.Forms.Label();
            this.lblError_ssn = new System.Windows.Forms.Label();
            this.lblError_address = new System.Windows.Forms.Label();
            this.lblError_city = new System.Windows.Forms.Label();
            this.lblError_state = new System.Windows.Forms.Label();
            this.lblError_zip = new System.Windows.Forms.Label();
            this.lblError_phone = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(184, 227);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(68, 20);
            this.txtZipcode.TabIndex = 8;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(336, 48);
            this.txtSSN.MaxLength = 9;
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(144, 20);
            this.txtSSN.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(577, 98);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Doctor",
            "Administrator",
            "Nurse",
            "Patient"});
            this.cbUserType.Location = new System.Drawing.Point(577, 142);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(97, 21);
            this.cbUserType.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(515, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "User Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Phone";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(124, 319);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(163, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbState
            // 
            this.cbState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cbState.Location = new System.Drawing.Point(183, 183);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(54, 21);
            this.cbState.Sorted = true;
            this.cbState.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Zip";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(184, 139);
            this.txtCity.MaxLength = 100;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 20);
            this.txtCity.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(577, 45);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(112, 20);
            this.dtpDOB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbGender.Location = new System.Drawing.Point(486, 46);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(64, 21);
            this.cbGender.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SSN#";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(183, 48);
            this.txtLastName.MaxLength = 45;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(184, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(314, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(34, 48);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // lblError_firstName
            // 
            this.lblError_firstName.AutoSize = true;
            this.lblError_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_firstName.ForeColor = System.Drawing.Color.Red;
            this.lblError_firstName.Location = new System.Drawing.Point(34, 75);
            this.lblError_firstName.Name = "lblError_firstName";
            this.lblError_firstName.Size = new System.Drawing.Size(0, 16);
            this.lblError_firstName.TabIndex = 17;
            // 
            // lblError_lastName
            // 
            this.lblError_lastName.AutoSize = true;
            this.lblError_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_lastName.ForeColor = System.Drawing.Color.Red;
            this.lblError_lastName.Location = new System.Drawing.Point(188, 75);
            this.lblError_lastName.Name = "lblError_lastName";
            this.lblError_lastName.Size = new System.Drawing.Size(0, 16);
            this.lblError_lastName.TabIndex = 18;
            // 
            // lblError_ssn
            // 
            this.lblError_ssn.AutoSize = true;
            this.lblError_ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_ssn.ForeColor = System.Drawing.Color.Red;
            this.lblError_ssn.Location = new System.Drawing.Point(341, 73);
            this.lblError_ssn.Name = "lblError_ssn";
            this.lblError_ssn.Size = new System.Drawing.Size(0, 16);
            this.lblError_ssn.TabIndex = 19;
            // 
            // lblError_address
            // 
            this.lblError_address.AutoSize = true;
            this.lblError_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_address.ForeColor = System.Drawing.Color.Red;
            this.lblError_address.Location = new System.Drawing.Point(188, 118);
            this.lblError_address.Name = "lblError_address";
            this.lblError_address.Size = new System.Drawing.Size(0, 16);
            this.lblError_address.TabIndex = 20;
            // 
            // lblError_city
            // 
            this.lblError_city.AutoSize = true;
            this.lblError_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_city.ForeColor = System.Drawing.Color.Red;
            this.lblError_city.Location = new System.Drawing.Point(188, 162);
            this.lblError_city.Name = "lblError_city";
            this.lblError_city.Size = new System.Drawing.Size(0, 16);
            this.lblError_city.TabIndex = 21;
            // 
            // lblError_state
            // 
            this.lblError_state.AutoSize = true;
            this.lblError_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_state.ForeColor = System.Drawing.Color.Red;
            this.lblError_state.Location = new System.Drawing.Point(188, 207);
            this.lblError_state.Name = "lblError_state";
            this.lblError_state.Size = new System.Drawing.Size(0, 16);
            this.lblError_state.TabIndex = 22;
            // 
            // lblError_zip
            // 
            this.lblError_zip.AutoSize = true;
            this.lblError_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_zip.ForeColor = System.Drawing.Color.Red;
            this.lblError_zip.Location = new System.Drawing.Point(188, 250);
            this.lblError_zip.Name = "lblError_zip";
            this.lblError_zip.Size = new System.Drawing.Size(0, 16);
            this.lblError_zip.TabIndex = 23;
            // 
            // lblError_phone
            // 
            this.lblError_phone.AutoSize = true;
            this.lblError_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_phone.ForeColor = System.Drawing.Color.Red;
            this.lblError_phone.Location = new System.Drawing.Point(581, 120);
            this.lblError_phone.Name = "lblError_phone";
            this.lblError_phone.Size = new System.Drawing.Size(0, 16);
            this.lblError_phone.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(728, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "(###) ### - ####";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label13.Location = new System.Drawing.Point(372, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "numbers only";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(258, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "#####";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 363);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblError_phone);
            this.Controls.Add(this.lblError_zip);
            this.Controls.Add(this.lblError_state);
            this.Controls.Add(this.lblError_city);
            this.Controls.Add(this.lblError_address);
            this.Controls.Add(this.lblError_ssn);
            this.Controls.Add(this.lblError_lastName);
            this.Controls.Add(this.lblError_firstName);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox cbState;
        public System.Windows.Forms.ComboBox cbUserType;
    
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtSSN;
        public System.Windows.Forms.TextBox txtZipcode;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblError_firstName;
        public System.Windows.Forms.Label lblError_lastName;
        public System.Windows.Forms.Label lblError_ssn;
        public System.Windows.Forms.Label lblError_address;
        public System.Windows.Forms.Label lblError_city;
        public System.Windows.Forms.Label lblError_state;
        public System.Windows.Forms.Label lblError_zip;
        public System.Windows.Forms.Label lblError_phone;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
    }
}