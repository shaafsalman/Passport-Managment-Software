CREATE TABLE Login 
(
    UserID INT PRIMARY KEY,
    username VARCHAR(50),
    Password VARCHAR(255),
    Type VARCHAR(20)
);

CREATE TABLE Applicant 
(
    ApplicantID INT PRIMARY KEY,
    Name VARCHAR(50),
    Address VARCHAR(100),
    Phone VARCHAR(20),
    Email VARCHAR(50),
    DateOfBirth DATE,
    Gender VARCHAR(10),
    IsChild BIT,
    AdultGuardianID INT,
    FatherID INT,
    MotherID INT,
    FOREIGN KEY (AdultGuardianID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (FatherID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (MotherID) REFERENCES Applicant(ApplicantID)
);

CREATE TABLE Officer 
(
    OfficerID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50)
);


CREATE TABLE PassportType 
(
    PassportTypeID varchar(50) PRIMARY KEY,
    ApplicantID INT,
	Type VARCHAR(50),
    ValidityPeriod INT,
	Pages INT,
    FOREIGN KEY (ApplicantID) REFERENCES Applicant(ApplicantID),
);

CREATE TABLE PassportApplication (
    ApplicationID INT PRIMARY KEY,
    ApplicantID INT,
    PassportTypeID varchar(50),
    ApplicationDate DATE,
    Status VARCHAR(20),
    FOREIGN KEY (ApplicantID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (PassportTypeID) REFERENCES PassportType(PassportTypeID)
);


CREATE TABLE Appointment (
    AppointmentID INT PRIMARY KEY,
    ApplicantID INT,
    OfficerID INT,
    AppointmentDate DATE,
    AppointmentTime TIME,
    Status VARCHAR(20),
    FOREIGN KEY (ApplicantID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (OfficerID) REFERENCES Officer(OfficerID)
);

CREATE TABLE Child (
    ChildID INT PRIMARY KEY,
    Name VARCHAR(50),
    DateOfBirth DATE,
    Gender VARCHAR(10),
    AdultGuardianID INT,
    FatherID INT,
    MotherID INT,
    FOREIGN KEY (AdultGuardianID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (FatherID) REFERENCES Applicant(ApplicantID),
    FOREIGN KEY (MotherID) REFERENCES Applicant(ApplicantID)
);


INSERT INTO Login (UserID, username, Password, Type)
VALUES
(1, 'shaaf', '1122', 'applicant'),
(2, 'farhan', '1122', 'applicant'),
(3, 'hadi', '1122', 'applicant'),
(4, 'laiba', '1122', 'applicant'),
(5, 'officer@gmail.com', 'officer123', 'officer');

INSERT INTO Applicant (ApplicantID, Name, Address, Phone, Email, DateOfBirth, Gender, IsChild, AdultGuardianID, FatherID, MotherID)
VALUES
(1, 'Shaaf Salman', 'House No. 123, Street No. 5, Lahore', '0345-1234567', 'shaaf@gmail.com', '1998-05-15', 'Male', 0, NULL, NULL, NULL),
(2, 'Farhan Jaffri', 'House No. 456, Street No. 8, Karachi', '0321-2345678', 'farhan@gmail.com', '2000-12-30', 'Male', 0, NULL, NULL, NULL),
(3, 'Abdul Hadi', 'House No. 789, Street No. 12, Lahore', '0333-3456789', 'abdul@gmail.com', '1995-08-08', 'Male', 0, NULL, NULL, NULL),
(4, 'Laiba Habib', 'House No. 234, Street No. 3, Islamabad', '0312-3456789', 'laiba@gmail.com', '2010-03-21', 'Female', 1, 1, NULL, 2);

INSERT INTO Officer (OfficerID, Name, Email)
VALUES
(1, 'Ali', 'ali@gmail.com'),
(2, 'Ahmed', 'Ahmed@gmail.com');

INSERT INTO PassportType (PassportTypeID, ApplicantID, Type, ValidityPeriod, Pages)
VALUES
(1, 1, 'Regular', 5,36),
(2, 2, 'Diplomatic', 10,36),
(3, 3, 'Official', 5,36);

INSERT INTO PassportApplication (ApplicationID, ApplicantID, PassportTypeID, ApplicationDate, Status)
VALUES
(1, 1, 1, '2022-01-01', 'Pending'),
(2, 2, 2, '2022-02-15', 'Approved'),
(3, 3, 3, '2022-03-20', 'Rejected');

INSERT INTO Appointment (AppointmentID, ApplicantID, OfficerID, AppointmentDate, AppointmentTime, Status)
VALUES
(1, 1, 1, '2022-05-10', '10:00:00', 'Pending'),
(2, 2, 2, '2022-06-20', '14:00:00', 'Approved');

INSERT INTO Child (ChildID, Name, DateOfBirth, Gender, AdultGuardianID, FatherID, MotherID)
VALUES
(1, 'Ali Salman', '2015-02-03', 'Male', 1, NULL, NULL),
(2, 'Zara Salman', '2018-11-05', 'Female', 1, NULL, NULL),
(3, 'Sarah Jaffri', '2022-01-02', 'Female', 2, NULL, NULL),
(4, 'Ahmed Hadi', '2020-09-08', 'Male', 3, NULL, NULL);


select * from login;