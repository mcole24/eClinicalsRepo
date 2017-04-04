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
            this.tabPatientRecord = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.tabSetAppointments = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel_SetAppointment = new System.Windows.Forms.Button();
            this.btnOk_SetAppointment = new System.Windows.Forms.Button();
            this.dtpAppointmentTime_SetAppointment = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentDate_SetAppointment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabViewAppointments = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgViewAppointments_ViewAppointments = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabRoutineCheck = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel_RoutineCheck = new System.Windows.Forms.Button();
            this.btnOk_RoutineCheck = new System.Windows.Forms.Button();
            this.clbSymptoms_RoutineCheck = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgPreviousReadings__RoutineCheck = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabOrderTests = new System.Windows.Forms.TabPage();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgTestResults_TestResults = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDoctor_SetAppointment = new System.Windows.Forms.ComboBox();
            this.cbReason_SetAppointment = new System.Windows.Forms.ComboBox();
            this.tabPatientRecord.SuspendLayout();
            this.tabSetAppointments.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabViewAppointments.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAppointments_ViewAppointments)).BeginInit();
            this.tabRoutineCheck.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreviousReadings__RoutineCheck)).BeginInit();
            this.tabOrderTests.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabTestsResults.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestResults_TestResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPatientRecord
            // 
            this.tabPatientRecord.Controls.Add(this.tabPersonal);
            this.tabPatientRecord.Controls.Add(this.tabSetAppointments);
            this.tabPatientRecord.Controls.Add(this.tabViewAppointments);
            this.tabPatientRecord.Controls.Add(this.tabRoutineCheck);
            this.tabPatientRecord.Controls.Add(this.tabOrderTests);
            this.tabPatientRecord.Controls.Add(this.tabTestsResults);
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
            this.tabPersonal.Location = new System.Drawing.Point(4, 34);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonal.Size = new System.Drawing.Size(1083, 568);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            this.tabPersonal.UseVisualStyleBackColor = true;
            // 
            // tabSetAppointments
            // 
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
            this.tabViewAppointments.Controls.Add(this.groupBox4);
            this.tabViewAppointments.Location = new System.Drawing.Point(4, 34);
            this.tabViewAppointments.Name = "tabViewAppointments";
            this.tabViewAppointments.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAppointments.Size = new System.Drawing.Size(1083, 568);
            this.tabViewAppointments.TabIndex = 2;
            this.tabViewAppointments.Text = "View Appointment";
            this.tabViewAppointments.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgViewAppointments_ViewAppointments);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(56, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(710, 462);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // dgViewAppointments_ViewAppointments
            // 
            this.dgViewAppointments_ViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewAppointments_ViewAppointments.Location = new System.Drawing.Point(19, 34);
            this.dgViewAppointments_ViewAppointments.Name = "dgViewAppointments_ViewAppointments";
            this.dgViewAppointments_ViewAppointments.Size = new System.Drawing.Size(685, 410);
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.btnCancel_RoutineCheck);
            this.groupBox7.Controls.Add(this.btnOk_RoutineCheck);
            this.groupBox7.Controls.Add(this.clbSymptoms_RoutineCheck);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(39, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(755, 251);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 175);
            this.textBox4.MaxLength = 5;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 141);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 111);
            this.textBox2.MaxLength = 5;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 77);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // btnCancel_RoutineCheck
            // 
            this.btnCancel_RoutineCheck.Location = new System.Drawing.Point(408, 222);
            this.btnCancel_RoutineCheck.Name = "btnCancel_RoutineCheck";
            this.btnCancel_RoutineCheck.Size = new System.Drawing.Size(150, 25);
            this.btnCancel_RoutineCheck.TabIndex = 17;
            this.btnCancel_RoutineCheck.Text = "Cancel";
            this.btnCancel_RoutineCheck.UseVisualStyleBackColor = true;
            // 
            // btnOk_RoutineCheck
            // 
            this.btnOk_RoutineCheck.Location = new System.Drawing.Point(235, 222);
            this.btnOk_RoutineCheck.Name = "btnOk_RoutineCheck";
            this.btnOk_RoutineCheck.Size = new System.Drawing.Size(150, 25);
            this.btnOk_RoutineCheck.TabIndex = 16;
            this.btnOk_RoutineCheck.Text = "&OK";
            this.btnOk_RoutineCheck.UseVisualStyleBackColor = true;
            // 
            // clbSymptoms_RoutineCheck
            // 
            this.clbSymptoms_RoutineCheck.FormattingEnabled = true;
            this.clbSymptoms_RoutineCheck.Items.AddRange(new object[] {
            "Headache",
            "Discharge",
            "Back Pain",
            "Cough",
            "Fatigue",
            "Night Sweats",
            "No symptoms"});
            this.clbSymptoms_RoutineCheck.Location = new System.Drawing.Point(484, 77);
            this.clbSymptoms_RoutineCheck.Name = "clbSymptoms_RoutineCheck";
            this.clbSymptoms_RoutineCheck.Size = new System.Drawing.Size(219, 139);
            this.clbSymptoms_RoutineCheck.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(480, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 24);
            this.label19.TabIndex = 6;
            this.label19.Text = "Symptoms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(79, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Pulse (bpm)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(79, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Body Temperature";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(79, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Diastolic BP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(79, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Systolic BP";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 1;
            this.label14.Text = "Check Up";
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
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Previouse Readings";
            // 
            // tabOrderTests
            // 
            this.tabOrderTests.Controls.Add(this.groupBox6);
            this.tabOrderTests.Location = new System.Drawing.Point(4, 34);
            this.tabOrderTests.Name = "tabOrderTests";
            this.tabOrderTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderTests.Size = new System.Drawing.Size(1083, 568);
            this.tabOrderTests.TabIndex = 4;
            this.tabOrderTests.Text = "Order Tests";
            this.tabOrderTests.UseVisualStyleBackColor = true;
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
            // 
            // btnCancel_OrderTest
            // 
            this.btnCancel_OrderTest.Location = new System.Drawing.Point(340, 143);
            this.btnCancel_OrderTest.Name = "btnCancel_OrderTest";
            this.btnCancel_OrderTest.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_OrderTest.TabIndex = 4;
            this.btnCancel_OrderTest.Text = "Cancel";
            this.btnCancel_OrderTest.UseVisualStyleBackColor = true;
            this.btnCancel_OrderTest.Click += new System.EventHandler(this.btnCancel_OrderTest_Click);
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(210, 143);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(75, 23);
            this.btnOrderTest.TabIndex = 3;
            this.btnOrderTest.Text = "Order Test";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            this.btnOrderTest.Click += new System.EventHandler(this.btnOrderTest_Click);
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
            this.tabTestsResults.Controls.Add(this.groupBox3);
            this.tabTestsResults.Location = new System.Drawing.Point(4, 34);
            this.tabTestsResults.Name = "tabTestsResults";
            this.tabTestsResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestsResults.Size = new System.Drawing.Size(1083, 568);
            this.tabTestsResults.TabIndex = 5;
            this.tabTestsResults.Text = "Test Results";
            this.tabTestsResults.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgTestResults_TestResults);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(42, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 462);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // dgTestResults_TestResults
            // 
            this.dgTestResults_TestResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestResults_TestResults.Location = new System.Drawing.Point(19, 34);
            this.dgTestResults_TestResults.Name = "dgTestResults_TestResults";
            this.dgTestResults_TestResults.Size = new System.Drawing.Size(447, 410);
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
            // cbDoctor_SetAppointment
            // 
            this.cbDoctor_SetAppointment.FormattingEnabled = true;
            this.cbDoctor_SetAppointment.Location = new System.Drawing.Point(141, 63);
            this.cbDoctor_SetAppointment.Name = "cbDoctor_SetAppointment";
            this.cbDoctor_SetAppointment.Size = new System.Drawing.Size(368, 21);
            this.cbDoctor_SetAppointment.TabIndex = 17;
            // 
            // cbReason_SetAppointment
            // 
            this.cbReason_SetAppointment.FormattingEnabled = true;
            this.cbReason_SetAppointment.Location = new System.Drawing.Point(141, 27);
            this.cbReason_SetAppointment.Name = "cbReason_SetAppointment";
            this.cbReason_SetAppointment.Size = new System.Drawing.Size(368, 21);
            this.cbReason_SetAppointment.TabIndex = 17;
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
            this.tabSetAppointments.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabViewAppointments.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewAppointments_ViewAppointments)).EndInit();
            this.tabRoutineCheck.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private System.Windows.Forms.Button btnOk_SetAppointment;
        public System.Windows.Forms.DateTimePicker dtpAppointmentTime_SetAppointment;
        public System.Windows.Forms.DateTimePicker dtpAppointmentDate_SetAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgTestResults_TestResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btnCancel_RoutineCheck;
        public System.Windows.Forms.Button btnOk_RoutineCheck;
        public System.Windows.Forms.CheckedListBox clbSymptoms_RoutineCheck;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dgPreviousReadings__RoutineCheck;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dgViewAppointments_ViewAppointments;
        public System.Windows.Forms.ComboBox cbSelectDoctor_OrderTest;
        public System.Windows.Forms.ComboBox cbSelectTest_OrderTest;
        public System.Windows.Forms.ComboBox cbReason_SetAppointment;
        public System.Windows.Forms.ComboBox cbDoctor_SetAppointment;
    }
}