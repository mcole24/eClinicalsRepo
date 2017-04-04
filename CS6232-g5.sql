-- DROP DATABASE [CS6232-g5];
-- CREATE DATABASE [CS6232-g5];

USE [CS6232-g5];

CREATE TABLE contact (
	contactID INT PRIMARY KEY IDENTITY,
	lName VARCHAR(45) NOT NULL,
	fName VARCHAR(45) NOT NULL,
	dob DATE NOT NULL,
	mailingAddressStreet VARCHAR(100) NOT NULL,
	mailingAddressCity VARCHAR(100) NOT NULL,
	mailingAddressState CHAR(2) NOT NULL,
	mailingAddressZip CHAR(5) NOT NULL,
	phoneNumber VARCHAR(20) NOT NULL,
	gender CHAR(1),
	SSN CHAR(9) NOT NULL UNIQUE,
	userType INT NOT NULL
);

/*

userType definitions -- 
1. Doctor
2. Clinic Administrator
3. Nurse
4. Patient

*/

CREATE TABLE logins (
	contactID INT NOT NULL,
	userName VARCHAR(45) PRIMARY KEY,
	password VARCHAR(45)
	FOREIGN KEY (contactID) REFERENCES contact(contactID)
);

CREATE TABLE patient(
	patientID INT PRIMARY KEY IDENTITY,
	contactID INT NOT NULL, 
	FOREIGN KEY (contactID) REFERENCES contact(contactID)
);

CREATE TABLE nurse (
  nurseID INT PRIMARY KEY IDENTITY NOT NULL,
  contactID INT NOT NULL,
  FOREIGN KEY (contactID) REFERENCES contact(contactID)
);

CREATE TABLE doctor (
  doctorID INT PRIMARY KEY IDENTITY NOT NULL,
  contactID INT NOT NULL,
  FOREIGN KEY (contactID) REFERENCES contact(contactID)
);

CREATE TABLE clinic_administrator (
  administratorID INT PRIMARY KEY IDENTITY NOT NULL,
  contactID INT NOT NULL,
  FOREIGN KEY (contactID) REFERENCES contact(contactID)
);

CREATE TABLE specialty (
  specialtyID INT PRIMARY KEY IDENTITY NOT NULL,
  specialtyType VARCHAR(45) NOT NULL,
);

CREATE TABLE doctor_specialty (
  doctorID INT NOT NULL,
  specialtyID INT NOT NULL,
  PRIMARY KEY (doctorID, specialtyID),
  FOREIGN KEY (doctorID) REFERENCES doctor(doctorID),
  FOREIGN KEY (specialtyID) REFERENCES specialty(specialtyID)
);


CREATE TABLE appointment_reason (
  appointmentReasonID INT PRIMARY KEY IDENTITY NOT NULL,
  appointmentReason VARCHAR(45) NOT NULL,
);


CREATE TABLE appointment (
  appointmentID INT PRIMARY KEY IDENTITY NOT NULL,
  appointmentDate DATETIME NOT NULL,
  patientID INT NOT NULL,
  doctorID INT NOT NULL,
  appointmentReasonID INT NOT NULL,
  FOREIGN KEY (patientID) REFERENCES patient(patientID),
  FOREIGN KEY (doctorID) REFERENCES doctor(doctorID),
  FOREIGN KEY (appointmentReasonID) REFERENCES appointment_reason(appointmentReasonID)
);


CREATE TABLE visit (
  visitID INT PRIMARY KEY IDENTITY NOT NULL,
  appointmentID INT NOT NULL,
  nurseID INT NOT NULL,
  visitTime DATETIME NOT NULL,
  systolicBP INT NOT NULL,
  diastolicBP INT NOT NULL,
  bodyTemperature DECIMAL(4,1) NOT NULL,
  pulse INT NOT NULL,
  FOREIGN KEY (nurseID) REFERENCES nurse(nurseID),
  FOREIGN KEY (appointmentID) REFERENCES appointment(appointmentID)
);

CREATE TABLE symptom (
  symptomID INT PRIMARY KEY IDENTITY NOT NULL,
  symptomType VARCHAR(45) NOT NULL,
);

CREATE TABLE visit_symptom (
  visitID INT NOT NULL,
  symptomID INT NOT NULL,
  PRIMARY KEY (visitID, symptomID),
  FOREIGN KEY (visitID) REFERENCES visit(visitID),
  FOREIGN KEY (symptomID) REFERENCES symptom(symptomID)
);

CREATE TABLE lab_test (
  testCode INT PRIMARY KEY IDENTITY NOT NULL,
  testType VARCHAR(45) NOT NULL,
);

CREATE TABLE visit_lab_test (
  testID INT PRIMARY KEY IDENTITY,
  testCode INT NOT NULL,
  visitID INT NOT NULL,
  result BIT NULL,
  testDateCompleted DATE NULL,
  FOREIGN KEY (testCode) REFERENCES lab_test(testCode),
  FOREIGN KEY (visitID) REFERENCES visit(visitID)
);


CREATE TABLE diagnosis (
  diagnosisID INT PRIMARY KEY IDENTITY NOT NULL,
  diagnosisType VARCHAR(45) NOT NULL,
);

CREATE TABLE visit_has_diagnosis (
  visitID INT NOT NULL,
  diagnosisID INT NOT NULL,
  initialDiagnosis BIT NOT NULL,
  finalDiagnosis BIT,
  PRIMARY KEY (visitID, diagnosisID),
  FOREIGN KEY (visitID) REFERENCES visit(visitID),
  FOREIGN KEY (diagnosisID) REFERENCES diagnosis(diagnosisID)
);

INSERT INTO contact VALUES
('Syed', 'Amber', '1979-01-16', '123 Main Street', 'Atlanta', 'GA', '30308', '678-770-1234', 'F', '123456789', 1), 
('Carter', 'Maya', '1977-10-10', '500 Self Street', 'Marietta', 'GA', '30068', '770-679-9900', 'F', '234567891', 1), 
('Simon', 'Timothy', '1965-07-29', '15 Maine Lane', 'Atlanta', 'GA', '30909', '470-674-6759', 'M', '345678912', 1), 
('Wynn', 'Jasmine', '1990-10-19', '15 Antler Dr', 'Norcross', 'GA', '30092', '770-404-0076', 'F', '456789123', 2),
('Woods', 'Courtney', '1990-11-28', '25 Ashley  Circle', 'Norcross', 'GA', '30092', '404-388-3729', 'F', '567891234', 3), 
('DeWalt', 'DeAndra', '1990-02-02', '50 Graves Road', 'Doraville', 'GA', '30096', '404-470-6789', 'F', '678912345', 3),
('Robinson', 'Bianca', '1990-12-09', '2309 Ashley Club Circle', 'Norcross', 'GA', '30092', '678-895-5648', 'F', '789123456', 4),
('Williams', 'Jeffrey', '1970-09-18', '50 Bellwood Circle', 'Morrow', 'GA', '30260', '678-895-9846', 'M', '891234567', 4),
('Williams', 'Nicki', '1960-05-18', '50 Bellwood Circle', 'Morrow', 'GA', '30260', '678-895-9846', 'F', '912345678', 4),
('Graham', 'Lamar', '1983-02-15', '123 Main Circle', 'Norcross', 'GA', '30092', '770-678-4040', 'M', '012345678', 4),
('Gasque', 'Xzavia', '1991-10-09', '123 Story Circle', 'Atlanta', 'GA', '30308', '404-678-3030', 'F', '147258369', 4),
('Mitchell', 'Marvin', '1981-09-04', '123 Story Circle', 'Atlanta', 'GA', '30308', '470-678-3456', 'M', '369258147', 4);

INSERT INTO logins VALUES
(1, 'asyed1', 'testpassword123'),
(2, 'mcarter2', 'testpassword123'),
(3, 'tsimon', 'testpassword123'),
(4, 'jwynn1', 'testpassword123'),
(5, 'cwoods6', 'testpassword123'),
(6, 'ddewalt', 'testpassword123');

INSERT INTO doctor VALUES
(1),
(2),
(3);

INSERT INTO clinic_administrator VALUES
(4);

INSERT INTO nurse VALUES
(5),
(6);

INSERT INTO patient VALUES
(7),
(8),
(9),
(10),
(11),
(12);

INSERT INTO specialty VALUES
('Internal Medicine'), 
('Pediatric Medicine'), 
('Family Medicine'), 
('Gastroenterology');

INSERT INTO doctor_specialty VALUES
(1, 1), 
(2, 3), 
(3, 2);

INSERT INTO appointment_reason VALUES
('New Patient'), 
('Annual Visit'), 
('Follow-Up'), 
('Sick Visit');

INSERT INTO appointment VALUES
('2016-11-28 08:30:00', 1, 1, 2),
('2016-11-28 08:45:00', 2, 1, 1),
('2016-12-01 12:00:00', 3, 2, 3),
('2016-12-01 12:15:00', 4, 2, 4),
('2016-12-01 12:30:00', 5, 2, 2),
('2016-12-02 10:30:00', 6, 3, 1),
('2016-12-02 10:45:00', 3, 3, 3),
('2016-12-03 11:00:00', 1, 1, 3),
('2016-12-03 11:15:00', 5, 2, 3);



INSERT INTO visit VALUES
(1, 1, '2016-11-28 08:30:00', 120, 80, 99.0, 75),
(2, 1, '2016-11-28 08:45:00', 110, 70, 97.1, 65),
(3, 2, '2016-12-01 12:00:00', 91, 65, 98.2, 70),
(4, 2, '2016-12-01 12:15:00', 100, 80, 99.3, 74),
(5, 2, '2016-12-01 12:30:00', 96, 70, 100.4, 73),
(6, 1, '2016-12-02 10:30:00', 125, 87, 97.5, 67),
(7, 2, '2016-12-02 10:45:00', 130, 85, 98.6, 69),
(8, 1, '2016-12-03 11:00:00', 140, 90, 98.7, 70),
(9, 2, '2016-12-03 11:15:00', 121, 82, 99.8, 60);

INSERT INTO symptom VALUES
('Headache'), 
('Discharge'), 
('Back Pain'), 
('Cough'), 
('Fatigue'), 
('Night Sweats'),
('No symptoms');

INSERT INTO visit_symptom VALUES
(1, '7'),
(2, '3'),
(2, '5'),
(3, '1'),
(4, '6'),
(5, '2'),
(5, '5'),
(5, '4'),
(6, '7'),
(7, '5'),
(8, '2'),
(8, '1'),
(9, '5');

INSERT INTO lab_test VALUES
('WBC'), 
('LDL'), 
('Flu test'), 
('Hepatitis A'),
('Hepatitis B'),
('Hepatitis C');

INSERT INTO visit_lab_test VALUES
(1, 1, 0, '2016-11-30'),
(1, 2, 0, '2016-11-30'),
(1, 3, 0, '2016-12-03'),
(2, 4, 0, '2016-12-03'),
(2, 5, 0, '2016-12-03'),
(2, 6, 0, '2016-12-03'),
(3, 7, 1, '2016-12-03'),
(3, 8, 1, '2016-12-04'),
(3, 9, 1, '2016-12-04'),
(4, 1, 1, '2016-11-30'),
(5, 2, 0, '2016-11-30'),
(5, 3, 0, '2016-12-03'),
(6, 4, 0, '2016-12-03'),
(6, 5, 0, '2016-12-03');


INSERT INTO diagnosis VALUES
('Wellness Exam'),
('Diabetes'),
('Back pain'), 
('Pain in joint'), 
('Asthma'), 
('Vaginal Discharge'), 
('Pharyngitis');

INSERT INTO visit_has_diagnosis VALUES
(1, 1, 1, 1),
(1, 7, 0, 0),
(2, 2, 1, 1),
(3, 3, 1, 1),
(4, 5, 1, 1),
(4, 7, 0, 1),
(5, 4, 1, 0),
(6, 6, 1, 1),
(7, 1, 1, 1), 
(7, 7, 0, 0),
(8, 5, 1, 1),
(9, 3, 1, 1),
(9, 2, 0, 0);


