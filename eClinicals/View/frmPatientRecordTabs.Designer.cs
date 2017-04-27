namespace eClinicals.View
{
    partial class frmPatientRecordTabs
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
            System.Windows.Forms.Label appointmentIDLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label doctorIDLabel;
            System.Windows.Forms.Label appointmentDoctorLabel;
            System.Windows.Forms.Label appointmentReasonLabel;
            System.Windows.Forms.Label appointmentDateLabel;
            System.Windows.Forms.Label label35;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRecordTabs));
            this.lblSummary = new System.Windows.Forms.Label();
            this.tabPatientRecord = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.ucAlertPersonal = new eClinicals.View.ucAlert();
            this.label24 = new System.Windows.Forms.Label();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblError_phone = new System.Windows.Forms.Label();
            this.lblError_zip = new System.Windows.Forms.Label();
            this.lblError_state = new System.Windows.Forms.Label();
            this.lblError_city = new System.Windows.Forms.Label();
            this.lblError_address = new System.Windows.Forms.Label();
            this.lblError_ssn = new System.Windows.Forms.Label();
            this.lblError_lastName = new System.Windows.Forms.Label();
            this.lblError_firstName = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.tabSetAppointments = new System.Windows.Forms.TabPage();
            this.ucAlertSetApp = new eClinicals.View.ucAlert();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel_SetAppointment = new System.Windows.Forms.Button();
            this.btnOk_SetAppointment = new System.Windows.Forms.Button();
            this.dtpAppointmentTime_SetAppointment = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentDate_SetAppointment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbReason_SetAppointment = new System.Windows.Forms.ComboBox();
            this.cbDoctor_SetAppointment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabViewAppointments = new System.Windows.Forms.TabPage();
            this.ucAlertViewApp = new eClinicals.View.ucAlert();
            this.gbEditAppointment = new System.Windows.Forms.GroupBox();
            this.cbAppDoctor = new System.Windows.Forms.ComboBox();
            this.cbAppReason = new System.Windows.Forms.ComboBox();
            this.dtAppTime = new System.Windows.Forms.DateTimePicker();
            this.btnAppEditCancel = new System.Windows.Forms.Button();
            this.btnCommitEdit = new System.Windows.Forms.Button();
            this.doctorIDTextBox = new System.Windows.Forms.TextBox();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.gbShowAppontment = new System.Windows.Forms.GroupBox();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnShowAllAppointments = new System.Windows.Forms.Button();
            this.btnShowFutureAppointments = new System.Windows.Forms.Button();
            this.btnShowPastAppointments = new System.Windows.Forms.Button();
            this.btnShowCurrentAppointments = new System.Windows.Forms.Button();
            this.gbBeginRoutineCheck = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.btnSelectAppointment = new System.Windows.Forms.Button();
            this.gbSelectEditApp = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.gbViewAppointments = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dgViewAppointments_ViewAppointments = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabRoutineCheck = new System.Windows.Forms.TabPage();
            this.ucAlertRoutineCheck = new eClinicals.View.ucAlert();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.cbSymptoms_RoutineCheck = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDatePerformed_RoutineCheck = new System.Windows.Forms.DateTimePicker();
            this.txtPulse = new System.Windows.Forms.TextBox();
            this.txtBodyTemp = new System.Windows.Forms.TextBox();
            this.txtDiastolic = new System.Windows.Forms.TextBox();
            this.txtSystolic = new System.Windows.Forms.TextBox();
            this.btnCancel_RoutineCheck = new System.Windows.Forms.Button();
            this.btnOk_RoutineCheck = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgPreviousReadings__RoutineCheck = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabOrderTests = new System.Windows.Forms.TabPage();
            this.ucAlertOrderTest = new eClinicals.View.ucAlert();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbSelectTest_OrderTest = new System.Windows.Forms.ComboBox();
            this.cbSelectDoctor_OrderTest = new System.Windows.Forms.ComboBox();
            this.btnCancel_OrderTest = new System.Windows.Forms.Button();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpPerformedDate_OrderTest = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabTestsResults = new System.Windows.Forms.TabPage();
            this.ucAlertTestResults = new eClinicals.View.ucAlert();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgTestResults_TestResults = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabDiagnosis = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblFinalDiagnosis = new System.Windows.Forms.Label();
            this.lblInitDiagnosis = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.rbInitialDiagnosis = new System.Windows.Forms.RadioButton();
            this.rbFinalDiagnosis = new System.Windows.Forms.RadioButton();
            this.btnCommitTest = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbDiagnosis_TestResults = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new eClinicals._CS6232_g5DataSetTableAdapters.TableAdapterManager();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            appointmentIDLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            appointmentDoctorLabel = new System.Windows.Forms.Label();
            appointmentReasonLabel = new System.Windows.Forms.Label();
            appointmentDateLabel = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            this.tabPatientRecord.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.tabSetAppointments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabViewAppointments.SuspendLayout();
            this.gbEditAppointment.SuspendLayout();
            this.gbShowAppontment.SuspendLayout();
            this.gbBeginRoutineCheck.SuspendLayout();
            this.gbSelectEditApp.SuspendLayout();
            this.gbViewAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAppointments_ViewAppointments)).BeginInit();
            this.tabRoutineCheck.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousReadings__RoutineCheck)).BeginInit();
            this.tabOrderTests.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabTestsResults.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestResults_TestResults)).BeginInit();
            this.tabDiagnosis.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Location = new System.Drawing.Point(6, 30);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(83, 13);
            appointmentIDLabel.TabIndex = 37;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Location = new System.Drawing.Point(131, 182);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(57, 13);
            patientIDLabel.TabIndex = 45;
            patientIDLabel.Text = "Patient ID:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Location = new System.Drawing.Point(131, 156);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(56, 13);
            doctorIDLabel.TabIndex = 43;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // appointmentDoctorLabel
            // 
            appointmentDoctorLabel.AutoSize = true;
            appointmentDoctorLabel.Location = new System.Drawing.Point(375, 48);
            appointmentDoctorLabel.Name = "appointmentDoctorLabel";
            appointmentDoctorLabel.Size = new System.Drawing.Size(104, 13);
            appointmentDoctorLabel.TabIndex = 35;
            appointmentDoctorLabel.Text = "Appointment Doctor:";
            // 
            // appointmentReasonLabel
            // 
            appointmentReasonLabel.AutoSize = true;
            appointmentReasonLabel.Location = new System.Drawing.Point(370, 17);
            appointmentReasonLabel.Name = "appointmentReasonLabel";
            appointmentReasonLabel.Size = new System.Drawing.Size(109, 13);
            appointmentReasonLabel.TabIndex = 39;
            appointmentReasonLabel.Text = "Appointment Reason:";
            // 
            // appointmentDateLabel
            // 
            appointmentDateLabel.AutoSize = true;
            appointmentDateLabel.Location = new System.Drawing.Point(128, 19);
            appointmentDateLabel.Name = "appointmentDateLabel";
            appointmentDateLabel.Size = new System.Drawing.Size(95, 13);
            appointmentDateLabel.TabIndex = 33;
            appointmentDateLabel.Text = "Appointment Date:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new System.Drawing.Point(128, 43);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(92, 13);
            label35.TabIndex = 49;
            label35.Text = "Appointment Time";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(6, 180);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(121, 13);
            this.lblSummary.TabIndex = 52;
            this.lblSummary.Text = "Show selected summary";
            this.lblSummary.Visible = false;
            // 
            // tabPatientRecord
            // 
            this.tabPatientRecord.Controls.Add(this.tabPersonal);
            this.tabPatientRecord.Controls.Add(this.tabSetAppointments);
            this.tabPatientRecord.Controls.Add(this.tabViewAppointments);
            this.tabPatientRecord.Controls.Add(this.tabRoutineCheck);
            this.tabPatientRecord.Controls.Add(this.tabOrderTests);
            this.tabPatientRecord.Controls.Add(this.tabTestsResults);
            this.tabPatientRecord.Controls.Add(this.tabDiagnosis);
            this.tabPatientRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatientRecord.ItemSize = new System.Drawing.Size(100, 30);
            this.tabPatientRecord.Location = new System.Drawing.Point(0, 0);
            this.tabPatientRecord.Name = "tabPatientRecord";
            this.tabPatientRecord.SelectedIndex = 0;
            this.tabPatientRecord.Size = new System.Drawing.Size(1091, 606);
            this.tabPatientRecord.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPatientRecord.TabIndex = 0;
            // 
            // tabPersonal
            // 
            this.tabPersonal.AutoScroll = true;
            this.tabPersonal.Controls.Add(this.ucAlertPersonal);
            this.tabPersonal.Controls.Add(this.label24);
            this.tabPersonal.Controls.Add(this.btnEditPerson);
            this.tabPersonal.Controls.Add(this.label21);
            this.tabPersonal.Controls.Add(this.label22);
            this.tabPersonal.Controls.Add(this.lblError_phone);
            this.tabPersonal.Controls.Add(this.lblError_zip);
            this.tabPersonal.Controls.Add(this.lblError_state);
            this.tabPersonal.Controls.Add(this.lblError_city);
            this.tabPersonal.Controls.Add(this.lblError_address);
            this.tabPersonal.Controls.Add(this.lblError_ssn);
            this.tabPersonal.Controls.Add(this.lblError_lastName);
            this.tabPersonal.Controls.Add(this.lblError_firstName);
            this.tabPersonal.Controls.Add(this.txtZipcode);
            this.tabPersonal.Controls.Add(this.txtSSN);
            this.tabPersonal.Controls.Add(this.txtPhone);
            this.tabPersonal.Controls.Add(this.label25);
            this.tabPersonal.Controls.Add(this.btnCancel);
            this.tabPersonal.Controls.Add(this.btnUpdate);
            this.tabPersonal.Controls.Add(this.cbState);
            this.tabPersonal.Controls.Add(this.label26);
            this.tabPersonal.Controls.Add(this.label27);
            this.tabPersonal.Controls.Add(this.txtCity);
            this.tabPersonal.Controls.Add(this.label28);
            this.tabPersonal.Controls.Add(this.label29);
            this.tabPersonal.Controls.Add(this.dtpDOB);
            this.tabPersonal.Controls.Add(this.label30);
            this.tabPersonal.Controls.Add(this.cbGender);
            this.tabPersonal.Controls.Add(this.label31);
            this.tabPersonal.Controls.Add(this.txtLastName);
            this.tabPersonal.Controls.Add(this.label32);
            this.tabPersonal.Controls.Add(this.txtAddress);
            this.tabPersonal.Controls.Add(this.label33);
            this.tabPersonal.Controls.Add(this.txtFirstName);
            this.tabPersonal.Controls.Add(this.label34);
            this.tabPersonal.Controls.Add(this.lblPatientID);
            this.tabPersonal.Location = new System.Drawing.Point(4, 34);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(1083, 568);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            this.tabPersonal.Click += new System.EventHandler(this.tabPersonal_Click);
            // 
            // ucAlertPersonal
            // 
            this.ucAlertPersonal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertPersonal.Location = new System.Drawing.Point(8, 45);
            this.ucAlertPersonal.Name = "ucAlertPersonal";
            this.ucAlertPersonal.Size = new System.Drawing.Size(1034, 456);
            this.ucAlertPersonal.TabIndex = 65;
            this.ucAlertPersonal.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label24.Location = new System.Drawing.Point(735, 185);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 64;
            this.label24.Text = "### ###  ####";
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(302, 378);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(163, 29);
            this.btnEditPerson.TabIndex = 63;
            this.btnEditPerson.Text = "Enable Update";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label21.Location = new System.Drawing.Point(266, 317);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 62;
            this.label21.Text = "#####";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label22.Location = new System.Drawing.Point(380, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 61;
            this.label22.Text = "numbers only";
            // 
            // lblError_phone
            // 
            this.lblError_phone.AutoSize = true;
            this.lblError_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_phone.ForeColor = System.Drawing.Color.Red;
            this.lblError_phone.Location = new System.Drawing.Point(589, 203);
            this.lblError_phone.Name = "lblError_phone";
            this.lblError_phone.Size = new System.Drawing.Size(0, 16);
            this.lblError_phone.TabIndex = 59;
            // 
            // lblError_zip
            // 
            this.lblError_zip.AutoSize = true;
            this.lblError_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_zip.ForeColor = System.Drawing.Color.Red;
            this.lblError_zip.Location = new System.Drawing.Point(196, 333);
            this.lblError_zip.Name = "lblError_zip";
            this.lblError_zip.Size = new System.Drawing.Size(0, 16);
            this.lblError_zip.TabIndex = 58;
            // 
            // lblError_state
            // 
            this.lblError_state.AutoSize = true;
            this.lblError_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_state.ForeColor = System.Drawing.Color.Red;
            this.lblError_state.Location = new System.Drawing.Point(196, 290);
            this.lblError_state.Name = "lblError_state";
            this.lblError_state.Size = new System.Drawing.Size(0, 16);
            this.lblError_state.TabIndex = 57;
            // 
            // lblError_city
            // 
            this.lblError_city.AutoSize = true;
            this.lblError_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_city.ForeColor = System.Drawing.Color.Red;
            this.lblError_city.Location = new System.Drawing.Point(196, 245);
            this.lblError_city.Name = "lblError_city";
            this.lblError_city.Size = new System.Drawing.Size(0, 16);
            this.lblError_city.TabIndex = 56;
            // 
            // lblError_address
            // 
            this.lblError_address.AutoSize = true;
            this.lblError_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_address.ForeColor = System.Drawing.Color.Red;
            this.lblError_address.Location = new System.Drawing.Point(196, 201);
            this.lblError_address.Name = "lblError_address";
            this.lblError_address.Size = new System.Drawing.Size(0, 16);
            this.lblError_address.TabIndex = 55;
            // 
            // lblError_ssn
            // 
            this.lblError_ssn.AutoSize = true;
            this.lblError_ssn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_ssn.ForeColor = System.Drawing.Color.Red;
            this.lblError_ssn.Location = new System.Drawing.Point(349, 156);
            this.lblError_ssn.Name = "lblError_ssn";
            this.lblError_ssn.Size = new System.Drawing.Size(0, 16);
            this.lblError_ssn.TabIndex = 54;
            // 
            // lblError_lastName
            // 
            this.lblError_lastName.AutoSize = true;
            this.lblError_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_lastName.ForeColor = System.Drawing.Color.Red;
            this.lblError_lastName.Location = new System.Drawing.Point(196, 158);
            this.lblError_lastName.Name = "lblError_lastName";
            this.lblError_lastName.Size = new System.Drawing.Size(0, 16);
            this.lblError_lastName.TabIndex = 53;
            // 
            // lblError_firstName
            // 
            this.lblError_firstName.AutoSize = true;
            this.lblError_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError_firstName.ForeColor = System.Drawing.Color.Red;
            this.lblError_firstName.Location = new System.Drawing.Point(42, 158);
            this.lblError_firstName.Name = "lblError_firstName";
            this.lblError_firstName.Size = new System.Drawing.Size(0, 16);
            this.lblError_firstName.TabIndex = 52;
            // 
            // txtZipcode
            // 
            this.txtZipcode.Enabled = false;
            this.txtZipcode.Location = new System.Drawing.Point(192, 310);
            this.txtZipcode.MaxLength = 5;
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(68, 20);
            this.txtZipcode.TabIndex = 41;
            // 
            // txtSSN
            // 
            this.txtSSN.Enabled = false;
            this.txtSSN.Location = new System.Drawing.Point(344, 131);
            this.txtSSN.MaxLength = 9;
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(144, 20);
            this.txtSSN.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(585, 181);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 20);
            this.txtPhone.TabIndex = 42;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(523, 181);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "Phone";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(438, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(171, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 23);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.Enabled = false;
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
            this.cbState.Location = new System.Drawing.Point(191, 266);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(54, 21);
            this.cbState.Sorted = true;
            this.cbState.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(129, 269);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 49;
            this.label26.Text = "State";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(130, 310);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 46;
            this.label27.Text = "Zip";
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(192, 222);
            this.txtCity.MaxLength = 100;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(182, 20);
            this.txtCity.TabIndex = 38;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(129, 225);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 13);
            this.label28.TabIndex = 44;
            this.label28.Text = "City";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(584, 112);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 13);
            this.label29.TabIndex = 43;
            this.label29.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(585, 128);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(112, 20);
            this.dtpDOB.TabIndex = 36;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(497, 113);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 40;
            this.label30.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.cbGender.Location = new System.Drawing.Point(494, 129);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(64, 21);
            this.cbGender.TabIndex = 34;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(338, 114);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(36, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "SSN#";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(191, 131);
            this.txtLastName.MaxLength = 45;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(144, 20);
            this.txtLastName.TabIndex = 31;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(188, 114);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 13);
            this.label32.TabIndex = 32;
            this.label32.Text = "Last Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(192, 178);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(314, 20);
            this.txtAddress.TabIndex = 37;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(129, 181);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(42, 131);
            this.txtFirstName.MaxLength = 45;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtFirstName.TabIndex = 30;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(39, 114);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 13);
            this.label34.TabIndex = 28;
            this.label34.Text = "First Name";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(39, 88);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(60, 13);
            this.lblPatientID.TabIndex = 4;
            this.lblPatientID.Text = "Patient ID: ";
            // 
            // tabSetAppointments
            // 
            this.tabSetAppointments.Controls.Add(this.ucAlertSetApp);
            this.tabSetAppointments.Controls.Add(this.groupBox2);
            this.tabSetAppointments.Controls.Add(this.groupBox1);
            this.tabSetAppointments.Location = new System.Drawing.Point(4, 34);
            this.tabSetAppointments.Name = "tabSetAppointments";
            this.tabSetAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetAppointments.Size = new System.Drawing.Size(1083, 568);
            this.tabSetAppointments.TabIndex = 1;
            this.tabSetAppointments.Text = "Set Appointment";
            this.tabSetAppointments.UseVisualStyleBackColor = true;
            // 
            // ucAlertSetApp
            // 
            this.ucAlertSetApp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertSetApp.Location = new System.Drawing.Point(8, 45);
            this.ucAlertSetApp.Name = "ucAlertSetApp";
            this.ucAlertSetApp.Size = new System.Drawing.Size(812, 456);
            this.ucAlertSetApp.TabIndex = 13;
            this.ucAlertSetApp.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel_SetAppointment);
            this.groupBox2.Controls.Add(this.btnOk_SetAppointment);
            this.groupBox2.Controls.Add(this.dtpAppointmentTime_SetAppointment);
            this.groupBox2.Controls.Add(this.dtpAppointmentDate_SetAppointment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(75, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 225);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel_SetAppointment
            // 
            this.btnCancel_SetAppointment.Location = new System.Drawing.Point(141, 171);
            this.btnCancel_SetAppointment.Name = "btnCancel_SetAppointment";
            this.btnCancel_SetAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_SetAppointment.TabIndex = 5;
            this.btnCancel_SetAppointment.Text = "Cancel";
            this.btnCancel_SetAppointment.UseVisualStyleBackColor = true;
            // 
            // btnOk_SetAppointment
            // 
            this.btnOk_SetAppointment.Location = new System.Drawing.Point(19, 171);
            this.btnOk_SetAppointment.Name = "btnOk_SetAppointment";
            this.btnOk_SetAppointment.Size = new System.Drawing.Size(75, 23);
            this.btnOk_SetAppointment.TabIndex = 4;
            this.btnOk_SetAppointment.Text = "OK";
            this.btnOk_SetAppointment.UseVisualStyleBackColor = true;
            // 
            // dtpAppointmentTime_SetAppointment
            // 
            this.dtpAppointmentTime_SetAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentTime_SetAppointment.Location = new System.Drawing.Point(141, 94);
            this.dtpAppointmentTime_SetAppointment.Name = "dtpAppointmentTime_SetAppointment";
            this.dtpAppointmentTime_SetAppointment.ShowUpDown = true;
            this.dtpAppointmentTime_SetAppointment.Size = new System.Drawing.Size(103, 20);
            this.dtpAppointmentTime_SetAppointment.TabIndex = 3;
            this.dtpAppointmentTime_SetAppointment.Value = new System.DateTime(2017, 4, 1, 23, 40, 0, 0);
            // 
            // dtpAppointmentDate_SetAppointment
            // 
            this.dtpAppointmentDate_SetAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate_SetAppointment.Location = new System.Drawing.Point(141, 27);
            this.dtpAppointmentDate_SetAppointment.Name = "dtpAppointmentDate_SetAppointment";
            this.dtpAppointmentDate_SetAppointment.Size = new System.Drawing.Size(103, 20);
            this.dtpAppointmentDate_SetAppointment.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Appointment Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Appointment Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbReason_SetAppointment);
            this.groupBox1.Controls.Add(this.cbDoctor_SetAppointment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbReason_SetAppointment
            // 
            this.cbReason_SetAppointment.FormattingEnabled = true;
            this.cbReason_SetAppointment.Location = new System.Drawing.Point(141, 27);
            this.cbReason_SetAppointment.Name = "cbReason_SetAppointment";
            this.cbReason_SetAppointment.Size = new System.Drawing.Size(368, 21);
            this.cbReason_SetAppointment.TabIndex = 17;
            // 
            // cbDoctor_SetAppointment
            // 
            this.cbDoctor_SetAppointment.FormattingEnabled = true;
            this.cbDoctor_SetAppointment.Location = new System.Drawing.Point(141, 63);
            this.cbDoctor_SetAppointment.Name = "cbDoctor_SetAppointment";
            this.cbDoctor_SetAppointment.Size = new System.Drawing.Size(368, 21);
            this.cbDoctor_SetAppointment.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reasons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set Appointment";
            // 
            // tabViewAppointments
            // 
            this.tabViewAppointments.AutoScroll = true;
            this.tabViewAppointments.Controls.Add(this.ucAlertViewApp);
            this.tabViewAppointments.Controls.Add(this.gbEditAppointment);
            this.tabViewAppointments.Controls.Add(this.gbShowAppontment);
            this.tabViewAppointments.Controls.Add(this.gbBeginRoutineCheck);
            this.tabViewAppointments.Controls.Add(this.gbSelectEditApp);
            this.tabViewAppointments.Controls.Add(this.gbViewAppointments);
            this.tabViewAppointments.Location = new System.Drawing.Point(4, 34);
            this.tabViewAppointments.Name = "tabViewAppointments";
            this.tabViewAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppointments.Size = new System.Drawing.Size(1083, 568);
            this.tabViewAppointments.TabIndex = 2;
            this.tabViewAppointments.Text = "View Appointment";
            this.tabViewAppointments.UseVisualStyleBackColor = true;
            // 
            // ucAlertViewApp
            // 
            this.ucAlertViewApp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertViewApp.Location = new System.Drawing.Point(961, 37);
            this.ucAlertViewApp.Name = "ucAlertViewApp";
            this.ucAlertViewApp.Size = new System.Drawing.Size(920, 501);
            this.ucAlertViewApp.TabIndex = 48;
            this.ucAlertViewApp.Visible = false;
            // 
            // gbEditAppointment
            // 
            this.gbEditAppointment.Controls.Add(this.cbAppDoctor);
            this.gbEditAppointment.Controls.Add(this.cbAppReason);
            this.gbEditAppointment.Controls.Add(label35);
            this.gbEditAppointment.Controls.Add(this.dtAppTime);
            this.gbEditAppointment.Controls.Add(this.btnAppEditCancel);
            this.gbEditAppointment.Controls.Add(this.btnCommitEdit);
            this.gbEditAppointment.Controls.Add(appointmentDateLabel);
            this.gbEditAppointment.Controls.Add(this.doctorIDTextBox);
            this.gbEditAppointment.Controls.Add(this.dtpAppDate);
            this.gbEditAppointment.Controls.Add(appointmentReasonLabel);
            this.gbEditAppointment.Controls.Add(appointmentDoctorLabel);
            this.gbEditAppointment.Controls.Add(doctorIDLabel);
            this.gbEditAppointment.Controls.Add(patientIDLabel);
            this.gbEditAppointment.Controls.Add(this.txtAppID);
            this.gbEditAppointment.Controls.Add(appointmentIDLabel);
            this.gbEditAppointment.Controls.Add(this.patientIDTextBox);
            this.gbEditAppointment.Location = new System.Drawing.Point(8, 369);
            this.gbEditAppointment.Name = "gbEditAppointment";
            this.gbEditAppointment.Size = new System.Drawing.Size(710, 118);
            this.gbEditAppointment.TabIndex = 47;
            this.gbEditAppointment.TabStop = false;
            this.gbEditAppointment.Text = "Edit Appointment";
            // 
            // cbAppDoctor
            // 
            this.cbAppDoctor.FormattingEnabled = true;
            this.cbAppDoctor.Location = new System.Drawing.Point(485, 45);
            this.cbAppDoctor.Name = "cbAppDoctor";
            this.cbAppDoctor.Size = new System.Drawing.Size(200, 21);
            this.cbAppDoctor.TabIndex = 51;
            // 
            // cbAppReason
            // 
            this.cbAppReason.FormattingEnabled = true;
            this.cbAppReason.Location = new System.Drawing.Point(485, 14);
            this.cbAppReason.Name = "cbAppReason";
            this.cbAppReason.Size = new System.Drawing.Size(200, 21);
            this.cbAppReason.TabIndex = 50;
            // 
            // dtAppTime
            // 
            this.dtAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtAppTime.Location = new System.Drawing.Point(260, 41);
            this.dtAppTime.Name = "dtAppTime";
            this.dtAppTime.Size = new System.Drawing.Size(86, 20);
            this.dtAppTime.TabIndex = 48;
            // 
            // btnAppEditCancel
            // 
            this.btnAppEditCancel.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.btnAppEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppEditCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAppEditCancel.Location = new System.Drawing.Point(563, 80);
            this.btnAppEditCancel.Name = "btnAppEditCancel";
            this.btnAppEditCancel.Size = new System.Drawing.Size(136, 32);
            this.btnAppEditCancel.TabIndex = 47;
            this.btnAppEditCancel.Text = "Cancel ";
            this.btnAppEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnCommitEdit
            // 
            this.btnCommitEdit.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.btnCommitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommitEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCommitEdit.Location = new System.Drawing.Point(421, 80);
            this.btnCommitEdit.Name = "btnCommitEdit";
            this.btnCommitEdit.Size = new System.Drawing.Size(136, 32);
            this.btnCommitEdit.TabIndex = 18;
            this.btnCommitEdit.Text = "Commit ";
            this.btnCommitEdit.UseVisualStyleBackColor = true;
            // 
            // doctorIDTextBox
            // 
            this.doctorIDTextBox.Location = new System.Drawing.Point(260, 153);
            this.doctorIDTextBox.Name = "doctorIDTextBox";
            this.doctorIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.doctorIDTextBox.TabIndex = 44;
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppDate.Location = new System.Drawing.Point(260, 15);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(86, 20);
            this.dtpAppDate.TabIndex = 34;
            // 
            // txtAppID
            // 
            this.txtAppID.Enabled = false;
            this.txtAppID.Location = new System.Drawing.Point(9, 48);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(80, 20);
            this.txtAppID.TabIndex = 38;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Location = new System.Drawing.Point(260, 179);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.patientIDTextBox.TabIndex = 46;
            // 
            // gbShowAppontment
            // 
            this.gbShowAppontment.Controls.Add(this.lblSummary);
            this.gbShowAppontment.Controls.Add(this.btnSummary);
            this.gbShowAppontment.Controls.Add(this.btnShowAllAppointments);
            this.gbShowAppontment.Controls.Add(this.btnShowFutureAppointments);
            this.gbShowAppontment.Controls.Add(this.btnShowPastAppointments);
            this.gbShowAppontment.Controls.Add(this.btnShowCurrentAppointments);
            this.gbShowAppontment.Location = new System.Drawing.Point(739, 46);
            this.gbShowAppontment.Name = "gbShowAppontment";
            this.gbShowAppontment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbShowAppontment.Size = new System.Drawing.Size(193, 221);
            this.gbShowAppontment.TabIndex = 19;
            this.gbShowAppontment.TabStop = false;
            this.gbShowAppontment.Text = "Show Appointments";
            // 
            // btnSummary
            // 
            this.btnSummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSummary.BackgroundImage")));
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSummary.Location = new System.Drawing.Point(7, 193);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(168, 22);
            this.btnSummary.TabIndex = 16;
            this.btnSummary.Text = "Show Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Visible = false;
            // 
            // btnShowAllAppointments
            // 
            this.btnShowAllAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowAllAppointments.BackgroundImage")));
            this.btnShowAllAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAppointments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowAllAppointments.Location = new System.Drawing.Point(6, 23);
            this.btnShowAllAppointments.Name = "btnShowAllAppointments";
            this.btnShowAllAppointments.Size = new System.Drawing.Size(169, 32);
            this.btnShowAllAppointments.TabIndex = 4;
            this.btnShowAllAppointments.Text = "Show All Appointments";
            this.btnShowAllAppointments.UseVisualStyleBackColor = true;
            // 
            // btnShowFutureAppointments
            // 
            this.btnShowFutureAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowFutureAppointments.BackgroundImage")));
            this.btnShowFutureAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFutureAppointments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowFutureAppointments.Location = new System.Drawing.Point(6, 66);
            this.btnShowFutureAppointments.Name = "btnShowFutureAppointments";
            this.btnShowFutureAppointments.Size = new System.Drawing.Size(169, 32);
            this.btnShowFutureAppointments.TabIndex = 14;
            this.btnShowFutureAppointments.Text = "Show Future Appointments";
            this.btnShowFutureAppointments.UseVisualStyleBackColor = true;
            // 
            // btnShowPastAppointments
            // 
            this.btnShowPastAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPastAppointments.BackgroundImage")));
            this.btnShowPastAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPastAppointments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowPastAppointments.Location = new System.Drawing.Point(6, 147);
            this.btnShowPastAppointments.Name = "btnShowPastAppointments";
            this.btnShowPastAppointments.Size = new System.Drawing.Size(169, 32);
            this.btnShowPastAppointments.TabIndex = 15;
            this.btnShowPastAppointments.Text = "Show Past Appointments";
            this.btnShowPastAppointments.UseVisualStyleBackColor = true;
            // 
            // btnShowCurrentAppointments
            // 
            this.btnShowCurrentAppointments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowCurrentAppointments.BackgroundImage")));
            this.btnShowCurrentAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCurrentAppointments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowCurrentAppointments.Location = new System.Drawing.Point(6, 109);
            this.btnShowCurrentAppointments.Name = "btnShowCurrentAppointments";
            this.btnShowCurrentAppointments.Size = new System.Drawing.Size(169, 32);
            this.btnShowCurrentAppointments.TabIndex = 15;
            this.btnShowCurrentAppointments.Text = "Show Current Appointments";
            this.btnShowCurrentAppointments.UseVisualStyleBackColor = true;
            // 
            // gbBeginRoutineCheck
            // 
            this.gbBeginRoutineCheck.Controls.Add(this.label38);
            this.gbBeginRoutineCheck.Controls.Add(this.btnSelectAppointment);
            this.gbBeginRoutineCheck.Enabled = false;
            this.gbBeginRoutineCheck.Location = new System.Drawing.Point(734, 273);
            this.gbBeginRoutineCheck.Name = "gbBeginRoutineCheck";
            this.gbBeginRoutineCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbBeginRoutineCheck.Size = new System.Drawing.Size(198, 88);
            this.gbBeginRoutineCheck.TabIndex = 19;
            this.gbBeginRoutineCheck.TabStop = false;
            this.gbBeginRoutineCheck.Text = "Routine Check";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label38.Location = new System.Drawing.Point(6, 27);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(187, 16);
            this.label38.TabIndex = 18;
            this.label38.Text = "Only current appointments";
            // 
            // btnSelectAppointment
            // 
            this.btnSelectAppointment.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.btnSelectAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectAppointment.Location = new System.Drawing.Point(6, 46);
            this.btnSelectAppointment.Name = "btnSelectAppointment";
            this.btnSelectAppointment.Size = new System.Drawing.Size(169, 32);
            this.btnSelectAppointment.TabIndex = 3;
            this.btnSelectAppointment.Text = "Begin Check";
            this.btnSelectAppointment.UseVisualStyleBackColor = true;
            // 
            // gbSelectEditApp
            // 
            this.gbSelectEditApp.Controls.Add(this.label37);
            this.gbSelectEditApp.Controls.Add(this.btnEditAppointment);
            this.gbSelectEditApp.Enabled = false;
            this.gbSelectEditApp.Location = new System.Drawing.Point(733, 369);
            this.gbSelectEditApp.Name = "gbSelectEditApp";
            this.gbSelectEditApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbSelectEditApp.Size = new System.Drawing.Size(199, 84);
            this.gbSelectEditApp.TabIndex = 18;
            this.gbSelectEditApp.TabStop = false;
            this.gbSelectEditApp.Text = "Edit Seleted Appointment";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label37.Location = new System.Drawing.Point(10, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(178, 16);
            this.label37.TabIndex = 5;
            this.label37.Text = "Only future appointments";
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.BackgroundImage = global::eClinicals.Properties.Resources.footer_image;
            this.btnEditAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppointment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditAppointment.Location = new System.Drawing.Point(6, 43);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(169, 32);
            this.btnEditAppointment.TabIndex = 17;
            this.btnEditAppointment.Text = "Edit Appointment";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            // 
            // gbViewAppointments
            // 
            this.gbViewAppointments.Controls.Add(this.label20);
            this.gbViewAppointments.Controls.Add(this.dgViewAppointments_ViewAppointments);
            this.gbViewAppointments.Controls.Add(this.label6);
            this.gbViewAppointments.Location = new System.Drawing.Point(8, 44);
            this.gbViewAppointments.Name = "gbViewAppointments";
            this.gbViewAppointments.Size = new System.Drawing.Size(710, 317);
            this.gbViewAppointments.TabIndex = 13;
            this.gbViewAppointments.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(56, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(536, 24);
            this.label20.TabIndex = 3;
            this.label20.Text = "Select an appointment below to begin a routine checkup";
            // 
            // dgViewAppointments_ViewAppointments
            // 
            this.dgViewAppointments_ViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAppointments_ViewAppointments.Location = new System.Drawing.Point(96, 68);
            this.dgViewAppointments_ViewAppointments.Name = "dgViewAppointments_ViewAppointments";
            this.dgViewAppointments_ViewAppointments.Size = new System.Drawing.Size(462, 228);
            this.dgViewAppointments_ViewAppointments.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "View Appointments";
            // 
            // tabRoutineCheck
            // 
            this.tabRoutineCheck.Controls.Add(this.ucAlertRoutineCheck);
            this.tabRoutineCheck.Controls.Add(this.groupBox7);
            this.tabRoutineCheck.Controls.Add(this.groupBox5);
            this.tabRoutineCheck.Location = new System.Drawing.Point(4, 34);
            this.tabRoutineCheck.Name = "tabRoutineCheck";
            this.tabRoutineCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoutineCheck.Size = new System.Drawing.Size(1083, 568);
            this.tabRoutineCheck.TabIndex = 3;
            this.tabRoutineCheck.Text = "Routine Check";
            this.tabRoutineCheck.UseVisualStyleBackColor = true;
            // 
            // ucAlertRoutineCheck
            // 
            this.ucAlertRoutineCheck.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertRoutineCheck.Location = new System.Drawing.Point(810, 146);
            this.ucAlertRoutineCheck.Name = "ucAlertRoutineCheck";
            this.ucAlertRoutineCheck.Size = new System.Drawing.Size(843, 508);
            this.ucAlertRoutineCheck.TabIndex = 16;
            this.ucAlertRoutineCheck.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.dtpDatePerformed_RoutineCheck);
            this.groupBox7.Controls.Add(this.txtPulse);
            this.groupBox7.Controls.Add(this.txtBodyTemp);
            this.groupBox7.Controls.Add(this.txtDiastolic);
            this.groupBox7.Controls.Add(this.txtSystolic);
            this.groupBox7.Controls.Add(this.btnCancel_RoutineCheck);
            this.groupBox7.Controls.Add(this.btnOk_RoutineCheck);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(39, 88);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(755, 221);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.cbSymptoms_RoutineCheck);
            this.groupBox12.Location = new System.Drawing.Point(531, 36);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(218, 56);
            this.groupBox12.TabIndex = 26;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Symptoms";
            // 
            // cbSymptoms_RoutineCheck
            // 
            this.cbSymptoms_RoutineCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymptoms_RoutineCheck.FormattingEnabled = true;
            this.cbSymptoms_RoutineCheck.Location = new System.Drawing.Point(6, 19);
            this.cbSymptoms_RoutineCheck.Name = "cbSymptoms_RoutineCheck";
            this.cbSymptoms_RoutineCheck.Size = new System.Drawing.Size(200, 21);
            this.cbSymptoms_RoutineCheck.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Performed Date";
            // 
            // dtpDatePerformed_RoutineCheck
            // 
            this.dtpDatePerformed_RoutineCheck.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePerformed_RoutineCheck.Location = new System.Drawing.Point(34, 89);
            this.dtpDatePerformed_RoutineCheck.Name = "dtpDatePerformed_RoutineCheck";
            this.dtpDatePerformed_RoutineCheck.Size = new System.Drawing.Size(137, 20);
            this.dtpDatePerformed_RoutineCheck.TabIndex = 22;
            // 
            // txtPulse
            // 
            this.txtPulse.Location = new System.Drawing.Point(409, 134);
            this.txtPulse.MaxLength = 5;
            this.txtPulse.Name = "txtPulse";
            this.txtPulse.Size = new System.Drawing.Size(100, 20);
            this.txtPulse.TabIndex = 21;
            // 
            // txtBodyTemp
            // 
            this.txtBodyTemp.Location = new System.Drawing.Point(409, 100);
            this.txtBodyTemp.MaxLength = 5;
            this.txtBodyTemp.Name = "txtBodyTemp";
            this.txtBodyTemp.Size = new System.Drawing.Size(100, 20);
            this.txtBodyTemp.TabIndex = 20;
            // 
            // txtDiastolic
            // 
            this.txtDiastolic.Location = new System.Drawing.Point(409, 70);
            this.txtDiastolic.MaxLength = 5;
            this.txtDiastolic.Name = "txtDiastolic";
            this.txtDiastolic.Size = new System.Drawing.Size(100, 20);
            this.txtDiastolic.TabIndex = 19;
            // 
            // txtSystolic
            // 
            this.txtSystolic.Location = new System.Drawing.Point(409, 36);
            this.txtSystolic.MaxLength = 5;
            this.txtSystolic.Name = "txtSystolic";
            this.txtSystolic.Size = new System.Drawing.Size(100, 20);
            this.txtSystolic.TabIndex = 18;
            // 
            // btnCancel_RoutineCheck
            // 
            this.btnCancel_RoutineCheck.Location = new System.Drawing.Point(409, 181);
            this.btnCancel_RoutineCheck.Name = "btnCancel_RoutineCheck";
            this.btnCancel_RoutineCheck.Size = new System.Drawing.Size(150, 25);
            this.btnCancel_RoutineCheck.TabIndex = 17;
            this.btnCancel_RoutineCheck.Text = "Cancel";
            this.btnCancel_RoutineCheck.UseVisualStyleBackColor = true;
            // 
            // btnOk_RoutineCheck
            // 
            this.btnOk_RoutineCheck.Location = new System.Drawing.Point(236, 181);
            this.btnOk_RoutineCheck.Name = "btnOk_RoutineCheck";
            this.btnOk_RoutineCheck.Size = new System.Drawing.Size(150, 25);
            this.btnOk_RoutineCheck.TabIndex = 16;
            this.btnOk_RoutineCheck.Text = "&OK";
            this.btnOk_RoutineCheck.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(240, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Pulse (bpm)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(240, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Body Temperature";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(240, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Diastolic BP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(240, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Systolic BP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, -4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Routine Check Results";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgPreviousReadings__RoutineCheck);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(39, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(755, 244);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // dgPreviousReadings__RoutineCheck
            // 
            this.dgPreviousReadings__RoutineCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreviousReadings__RoutineCheck.Location = new System.Drawing.Point(19, 23);
            this.dgPreviousReadings__RoutineCheck.Name = "dgPreviousReadings__RoutineCheck";
            this.dgPreviousReadings__RoutineCheck.Size = new System.Drawing.Size(684, 204);
            this.dgPreviousReadings__RoutineCheck.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Previous Readings";
            // 
            // tabOrderTests
            // 
            this.tabOrderTests.Controls.Add(this.ucAlertOrderTest);
            this.tabOrderTests.Controls.Add(this.groupBox6);
            this.tabOrderTests.Location = new System.Drawing.Point(4, 34);
            this.tabOrderTests.Name = "tabOrderTests";
            this.tabOrderTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderTests.Size = new System.Drawing.Size(1083, 568);
            this.tabOrderTests.TabIndex = 4;
            this.tabOrderTests.Text = "Order Tests";
            this.tabOrderTests.UseVisualStyleBackColor = true;
            // 
            // ucAlertOrderTest
            // 
            this.ucAlertOrderTest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertOrderTest.Location = new System.Drawing.Point(8, 45);
            this.ucAlertOrderTest.Name = "ucAlertOrderTest";
            this.ucAlertOrderTest.Size = new System.Drawing.Size(814, 446);
            this.ucAlertOrderTest.TabIndex = 14;
            this.ucAlertOrderTest.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbSelectTest_OrderTest);
            this.groupBox6.Controls.Add(this.cbSelectDoctor_OrderTest);
            this.groupBox6.Controls.Add(this.btnCancel_OrderTest);
            this.groupBox6.Controls.Add(this.btnOrderTest);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.dtpPerformedDate_OrderTest);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(87, 55);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(524, 187);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // cbSelectTest_OrderTest
            // 
            this.cbSelectTest_OrderTest.FormattingEnabled = true;
            this.cbSelectTest_OrderTest.Items.AddRange(new object[] {
            "WBC",
            "LDL",
            "Flu test",
            "Hepatitis A",
            "Hepatitis B",
            "Hepatitis C"});
            this.cbSelectTest_OrderTest.Location = new System.Drawing.Point(19, 47);
            this.cbSelectTest_OrderTest.Name = "cbSelectTest_OrderTest";
            this.cbSelectTest_OrderTest.Size = new System.Drawing.Size(183, 21);
            this.cbSelectTest_OrderTest.TabIndex = 15;
            // 
            // cbSelectDoctor_OrderTest
            // 
            this.cbSelectDoctor_OrderTest.FormattingEnabled = true;
            this.cbSelectDoctor_OrderTest.Items.AddRange(new object[] {
            "DOC 1",
            "DOC 2",
            "DOC 3",
            "DOC 4",
            "DOC 5"});
            this.cbSelectDoctor_OrderTest.Location = new System.Drawing.Point(19, 97);
            this.cbSelectDoctor_OrderTest.Name = "cbSelectDoctor_OrderTest";
            this.cbSelectDoctor_OrderTest.Size = new System.Drawing.Size(183, 21);
            this.cbSelectDoctor_OrderTest.TabIndex = 14;
            this.cbSelectDoctor_OrderTest.Visible = false;
            // 
            // btnCancel_OrderTest
            // 
            this.btnCancel_OrderTest.Location = new System.Drawing.Point(340, 143);
            this.btnCancel_OrderTest.Name = "btnCancel_OrderTest";
            this.btnCancel_OrderTest.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_OrderTest.TabIndex = 4;
            this.btnCancel_OrderTest.Text = "Cancel";
            this.btnCancel_OrderTest.UseVisualStyleBackColor = true;
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(210, 143);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(75, 23);
            this.btnOrderTest.TabIndex = 3;
            this.btnOrderTest.Text = "Order Test";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Performed Date";
            // 
            // dtpPerformedDate_OrderTest
            // 
            this.dtpPerformedDate_OrderTest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerformedDate_OrderTest.Location = new System.Drawing.Point(278, 44);
            this.dtpPerformedDate_OrderTest.Name = "dtpPerformedDate_OrderTest";
            this.dtpPerformedDate_OrderTest.Size = new System.Drawing.Size(137, 20);
            this.dtpPerformedDate_OrderTest.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Doctor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Select a test";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, -3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Order Test";
            // 
            // tabTestsResults
            // 
            this.tabTestsResults.Controls.Add(this.ucAlertTestResults);
            this.tabTestsResults.Controls.Add(this.groupBox3);
            this.tabTestsResults.Location = new System.Drawing.Point(4, 34);
            this.tabTestsResults.Name = "tabTestsResults";
            this.tabTestsResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestsResults.Size = new System.Drawing.Size(1083, 568);
            this.tabTestsResults.TabIndex = 5;
            this.tabTestsResults.Text = "Test Results";
            this.tabTestsResults.UseVisualStyleBackColor = true;
            // 
            // ucAlertTestResults
            // 
            this.ucAlertTestResults.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ucAlertTestResults.Location = new System.Drawing.Point(8, 45);
            this.ucAlertTestResults.Name = "ucAlertTestResults";
            this.ucAlertTestResults.Size = new System.Drawing.Size(833, 490);
            this.ucAlertTestResults.TabIndex = 24;
            this.ucAlertTestResults.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgTestResults_TestResults);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(79, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 304);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // dgTestResults_TestResults
            // 
            this.dgTestResults_TestResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestResults_TestResults.Location = new System.Drawing.Point(6, 23);
            this.dgTestResults_TestResults.Name = "dgTestResults_TestResults";
            this.dgTestResults_TestResults.Size = new System.Drawing.Size(637, 275);
            this.dgTestResults_TestResults.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, -4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Test Results";
            // 
            // tabDiagnosis
            // 
            this.tabDiagnosis.Controls.Add(this.groupBox9);
            this.tabDiagnosis.Controls.Add(this.groupBox4);
            this.tabDiagnosis.Controls.Add(this.groupBox10);
            this.tabDiagnosis.Controls.Add(this.btnCommitTest);
            this.tabDiagnosis.Controls.Add(this.groupBox8);
            this.tabDiagnosis.Location = new System.Drawing.Point(4, 34);
            this.tabDiagnosis.Name = "tabDiagnosis";
            this.tabDiagnosis.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnosis.Size = new System.Drawing.Size(1083, 568);
            this.tabDiagnosis.TabIndex = 6;
            this.tabDiagnosis.Text = "Diagnosis";
            this.tabDiagnosis.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblInitDiagnosis);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(392, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 61);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Initial Diagnosis ";
            // 
            // lblFinalDiagnosis
            // 
            this.lblFinalDiagnosis.AutoSize = true;
            this.lblFinalDiagnosis.Location = new System.Drawing.Point(29, 33);
            this.lblFinalDiagnosis.Name = "lblFinalDiagnosis";
            this.lblFinalDiagnosis.Size = new System.Drawing.Size(216, 16);
            this.lblFinalDiagnosis.TabIndex = 30;
            this.lblFinalDiagnosis.Text = "Final Diagnosis will show here";
            // 
            // lblInitDiagnosis
            // 
            this.lblInitDiagnosis.AutoSize = true;
            this.lblInitDiagnosis.Location = new System.Drawing.Point(29, 29);
            this.lblInitDiagnosis.Name = "lblInitDiagnosis";
            this.lblInitDiagnosis.Size = new System.Drawing.Size(202, 16);
            this.lblInitDiagnosis.TabIndex = 29;
            this.lblInitDiagnosis.Text = "Init Diagnosis will show here";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.rbInitialDiagnosis);
            this.groupBox10.Controls.Add(this.rbFinalDiagnosis);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(23, 141);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(292, 61);
            this.groupBox10.TabIndex = 26;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Diagnosis Type";
            // 
            // rbInitialDiagnosis
            // 
            this.rbInitialDiagnosis.AutoSize = true;
            this.rbInitialDiagnosis.Checked = true;
            this.rbInitialDiagnosis.Location = new System.Drawing.Point(6, 23);
            this.rbInitialDiagnosis.Name = "rbInitialDiagnosis";
            this.rbInitialDiagnosis.Size = new System.Drawing.Size(137, 20);
            this.rbInitialDiagnosis.TabIndex = 25;
            this.rbInitialDiagnosis.TabStop = true;
            this.rbInitialDiagnosis.Text = "Initial Diagnosis";
            this.rbInitialDiagnosis.UseVisualStyleBackColor = true;
            // 
            // rbFinalDiagnosis
            // 
            this.rbFinalDiagnosis.AutoSize = true;
            this.rbFinalDiagnosis.Enabled = false;
            this.rbFinalDiagnosis.Location = new System.Drawing.Point(148, 23);
            this.rbFinalDiagnosis.Name = "rbFinalDiagnosis";
            this.rbFinalDiagnosis.Size = new System.Drawing.Size(134, 20);
            this.rbFinalDiagnosis.TabIndex = 24;
            this.rbFinalDiagnosis.Text = "Final Diagnosis";
            this.rbFinalDiagnosis.UseVisualStyleBackColor = true;
            // 
            // btnCommitTest
            // 
            this.btnCommitTest.Location = new System.Drawing.Point(23, 306);
            this.btnCommitTest.Name = "btnCommitTest";
            this.btnCommitTest.Size = new System.Drawing.Size(292, 39);
            this.btnCommitTest.TabIndex = 28;
            this.btnCommitTest.Text = "Commit Test";
            this.btnCommitTest.UseVisualStyleBackColor = true;
            this.btnCommitTest.Click += new System.EventHandler(this.btnCommitTest_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbDiagnosis_TestResults);
            this.groupBox8.Location = new System.Drawing.Point(23, 220);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(292, 56);
            this.groupBox8.TabIndex = 25;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Diagnosis";
            // 
            // cbDiagnosis_TestResults
            // 
            this.cbDiagnosis_TestResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiagnosis_TestResults.FormattingEnabled = true;
            this.cbDiagnosis_TestResults.Location = new System.Drawing.Point(6, 19);
            this.cbDiagnosis_TestResults.Name = "cbDiagnosis_TestResults";
            this.cbDiagnosis_TestResults.Size = new System.Drawing.Size(274, 21);
            this.cbDiagnosis_TestResults.TabIndex = 16;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.contactTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eClinicals._CS6232_g5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblFinalDiagnosis);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(392, 284);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(292, 61);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Final Diagnosis ";
            // 
            // frmPatientRecordTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 606);
            this.Controls.Add(this.tabPatientRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientRecordTabs";
            this.Text = "frmPatientRecordTabs";
            this.tabPatientRecord.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.tabSetAppointments.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabViewAppointments.ResumeLayout(false);
            this.gbEditAppointment.ResumeLayout(false);
            this.gbEditAppointment.PerformLayout();
            this.gbShowAppontment.ResumeLayout(false);
            this.gbShowAppontment.PerformLayout();
            this.gbBeginRoutineCheck.ResumeLayout(false);
            this.gbBeginRoutineCheck.PerformLayout();
            this.gbSelectEditApp.ResumeLayout(false);
            this.gbSelectEditApp.PerformLayout();
            this.gbViewAppointments.ResumeLayout(false);
            this.gbViewAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAppointments_ViewAppointments)).EndInit();
            this.tabRoutineCheck.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousReadings__RoutineCheck)).EndInit();
            this.tabOrderTests.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabTestsResults.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestResults_TestResults)).EndInit();
            this.tabDiagnosis.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabPatientRecord;
        public System.Windows.Forms.TabPage tabPersonal;
        public System.Windows.Forms.TabPage tabViewAppointments;
        public System.Windows.Forms.TabPage tabRoutineCheck;
        public System.Windows.Forms.TabPage tabOrderTests;
        public System.Windows.Forms.TabPage tabTestsResults;
        public System.Windows.Forms.TabPage tabSetAppointments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel_SetAppointment;
        public System.Windows.Forms.DateTimePicker dtpAppointmentTime_SetAppointment;
        public System.Windows.Forms.DateTimePicker dtpAppointmentDate_SetAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.DateTimePicker dtpPerformedDate_OrderTest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnCancel_OrderTest;
        public System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Button btnCancel_RoutineCheck;
        public System.Windows.Forms.Button btnOk_RoutineCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dgPreviousReadings__RoutineCheck;
        public System.Windows.Forms.TextBox txtPulse;
        public System.Windows.Forms.TextBox txtBodyTemp;
        public System.Windows.Forms.TextBox txtDiastolic;
        public System.Windows.Forms.TextBox txtSystolic;
        public System.Windows.Forms.DataGridView dgViewAppointments_ViewAppointments;
        public System.Windows.Forms.ComboBox cbSelectDoctor_OrderTest;
        public System.Windows.Forms.ComboBox cbSelectTest_OrderTest;
        public System.Windows.Forms.ComboBox cbReason_SetAppointment;
        public System.Windows.Forms.ComboBox cbDoctor_SetAppointment;
        public System.Windows.Forms.Button btnOk_SetAppointment;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DataGridView dgTestResults_TestResults;
        private _CS6232_g5DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Label lblPatientID;
        public System.Windows.Forms.TextBox txtZipcode;
        public System.Windows.Forms.TextBox txtSSN;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cbState;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        public System.Windows.Forms.ComboBox cbGender;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Button btnEditPerson;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label lblError_phone;
        public System.Windows.Forms.Label lblError_zip;
        public System.Windows.Forms.Label lblError_state;
        public System.Windows.Forms.Label lblError_city;
        public System.Windows.Forms.Label lblError_address;
        public System.Windows.Forms.Label lblError_ssn;
        public System.Windows.Forms.Label lblError_lastName;
        public System.Windows.Forms.Label lblError_firstName;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label27;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label29;
        public System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.Label label32;
        public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Label label34;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Button btnSelectAppointment;
        public System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.TextBox doctorIDTextBox;
        public System.Windows.Forms.DateTimePicker dtpAppDate;
        public System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TextBox patientIDTextBox;
        public System.Windows.Forms.GroupBox gbEditAppointment;
        public System.Windows.Forms.GroupBox gbViewAppointments;
        public System.Windows.Forms.Button btnShowAllAppointments;
        public System.Windows.Forms.Button btnShowCurrentAppointments;
        public System.Windows.Forms.Button btnShowFutureAppointments;
        public System.Windows.Forms.Button btnCommitEdit;
        public System.Windows.Forms.GroupBox gbBeginRoutineCheck;
        public System.Windows.Forms.GroupBox gbSelectEditApp;
        public System.Windows.Forms.GroupBox gbShowAppontment;
        public System.Windows.Forms.Button btnAppEditCancel;
        public System.Windows.Forms.DateTimePicker dtAppTime;
        public System.Windows.Forms.ComboBox cbAppDoctor;
        public System.Windows.Forms.ComboBox cbAppReason;
        public ucAlert ucAlertPersonal;
        public ucAlert ucAlertSetApp;
        public ucAlert ucAlertRoutineCheck;
        public ucAlert ucAlertOrderTest;
        public ucAlert ucAlertViewApp;
        public ucAlert ucAlertTestResults;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        public System.Windows.Forms.Button btnShowPastAppointments;
        public System.Windows.Forms.TabPage tabDiagnosis;
        private System.Windows.Forms.GroupBox groupBox10;
        public System.Windows.Forms.RadioButton rbInitialDiagnosis;
        public System.Windows.Forms.RadioButton rbFinalDiagnosis;
        public System.Windows.Forms.Button btnCommitTest;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.ComboBox cbDiagnosis_TestResults;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dtpDatePerformed_RoutineCheck;
        public System.Windows.Forms.Button btnSummary;
        public System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.ComboBox cbSymptoms_RoutineCheck;
        public System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Label lblFinalDiagnosis;
        public System.Windows.Forms.Label lblInitDiagnosis;
    }
}