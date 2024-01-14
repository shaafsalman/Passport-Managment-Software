CREATE TABLE Applicants (
    ID INT  not null,
	CNIC INT PRIMARY KEY,
    [First Name] VARCHAR(50) NOT NULL,
    [Last Name] VARCHAR(50) NOT NULL,
    [Date of Birth] DATE NOT NULL,
    Gender VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Phone VARCHAR(50) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Nationality VARCHAR(50) NOT NULL,
    Occupation VARCHAR(50) NOT NULL,
    [Passport Number] VARCHAR(50)
);
CREATE TABLE Children (
    ID INT PRIMARY KEY NOT NULL,
    [CNIC of Father] INT NOT NULL,
    [CNIC of Mother] INT NOT NULL,
    [First Name] VARCHAR(50) NOT NULL,
    [Last Name] VARCHAR(50) NOT NULL,
    [Date of Birth] DATE NOT NULL,
    Gender VARCHAR(50) NOT NULL,
    [Place of Birth] VARCHAR(50) NOT NULL,
    Nationality VARCHAR(50) NOT NULL,
    FOREIGN KEY ([CNIC of Father]) REFERENCES Applicants(CNIC),
    FOREIGN KEY ([CNIC of Mother]) REFERENCES Applicants(CNIC)
);
CREATE TABLE Officers (
    
	Admin_ID INT NOT NULL PRIMARY KEY,
    [First Name] VARCHAR(50) NOT NULL,
    [Last Name] VARCHAR(50) NOT NULL,
	OfficerType VARCHAR(50) not null
);


CREATE TABLE Applications
(
    ID INT PRIMARY KEY NOT NULL,
    [Applicant ID] INT NOT NULL,
    [Application Date] DATE NOT NULL,
    [Application Status] VARCHAR(50) NOT NULL,
    [Appointment Date] DATE,
    FOREIGN KEY ([Applicant ID]) REFERENCES Applicants(ID),
);

CREATE TABLE Appointments (
    ID INT PRIMARY KEY NOT NULL,
    [Application ID] INT NOT NULL,
    [Serving Admin ID] INT NOT NULL,
    [Appointment Date] DATE NOT NULL,
    FOREIGN KEY ([Serving Admin ID]) REFERENCES Officers(Admin_ID),
    FOREIGN KEY ([Application ID]) REFERENCES applications(ID)

);

CREATE TABLE Logins
(
    EntityID INT  NOT NULL,
    Username VARCHAR(50) Primary Key NOT NULL ,
    Password VARCHAR(50) NOT NULL,
    Type VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Logins_Applicants FOREIGN KEY (EntityID) REFERENCES applicants(ID),
    CONSTRAINT FK_Logins_Officers FOREIGN KEY (EntityID) REFERENCES officers(Admin_ID),
);

CREATE TABLE Login (
    ID INT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    UserType VARCHAR(50) NOT NULL,
    UserID INT NOT NULL,
);
CREATE TABLE Passport (
    ID INT PRIMARY KEY not null,
    ApplicantID INT NOT NULL,
    [First Name] VARCHAR(50) NOT NULL,
    [Last Name] VARCHAR(50) NOT NULL,
    [Date of Birth] DATE NOT NULL,
    Gender VARCHAR(50) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    Phone VARCHAR(50) NOT NULL,
    Address VARCHAR(50) NOT NULL,
    Nationality VARCHAR(50) NOT NULL,
    Occupation VARCHAR(50) NOT NULL,
    [Passport Number] VARCHAR(50) NOT NULL,
    [Issue Date] DATE NOT NULL,
    [Expiry Date] DATE NOT NULL,
    [Pages Count] INT NOT NULL,
    [Type] VARCHAR(50) NOT NULL,
    [Father's First Name] VARCHAR(50),
    [Father's Last Name] VARCHAR(50),
    [Father's Date of Birth] DATE,
    [Mother's First Name] VARCHAR(50),
    [Mother's Last Name] VARCHAR(50),
    [Mother's Date of Birth] DATE
);

INSERT INTO Applicants 
VALUES 
(1,1, 'Shaaf', 'Salman', '2002-09-27', 'Male', 'shaaf.salman@gmail.com', '0312-1234567', '123 Main Street, Lahore', 'Pakistan', 'Engineer', 'PK1234567'),
(2,2, 'Farhan', 'Jaffri', '2002-06-21', 'Male', 'farhan.jaffri@gmail.com', '0345-1234567', '456 Second Street, Karachi', 'Pakistan', 'YouTuber', 'PK2345678'),
(3,3, 'Abdul', 'Hadi', '2002-01-14', 'Male', 'abdul.hadi@gmail.com', '0300-1234567', '789 Third Street, Lahore', 'Pakistan', 'Lawyer', 'PK3456789'),
(4,4, 'Haider', 'Khan', '2002-10-15', 'Male', 'haider.khan@gmail.com', '0321-1234567', '147 Fourth Street, Lahore', 'Pakistan', 'SHO', NULL),
(5,5, 'Jawad', 'Shahid', '2001-10-07', 'Male', 'jawad.shahid@gmail.com', '0333-1234567', '258 Fifth Street, Islamabad', 'Pakistan', 'Businessman', NULL),
(6,6, 'Laiba', 'Habib', '2002-11-26', 'Female', 'laiba.habib@gmail.com', '0314-1234567', '369 Sixth Street, Lahore', 'Pakistan', 'Freelancer', NULL),
(7,7, 'Rumaisa', 'Qadeer', '2002-07-08', 'Female', 'rumaisa.qadeer@gmail.com', '0301-1234567', '789 Seventh Street, Islamabad', 'Pakistan', 'Graphic Designer', NULL),
(8,8, 'Zoya', 'Arif', '2002-07-21', 'Female', 'zoya.arif@gmail.com', '0342-1234567', '147 Eighth Street, Lahore', 'Pakistan', 'Doctor', NULL),
(9,9, 'Sadia', 'Saleem', '2002-11-22', 'Female', 'sadia.saleem@gmail.com', '0331-1234567', '258 Ninth Street, Lahore', 'Pakistan', 'Lawyer', NULL);

INSERT INTO Applications 
VALUES 
(1, 1, '2023-01-01', 'Pending', NULL),
(2, 2, '2023-02-15', 'Approved', '2023-03-01'),
(3, 3, '2023-03-01', 'Rejected', NULL),
(4, 4, '2023-04-10', 'Pending', NULL),
(5, 5, '2023-05-20', 'Approved', '2023-06-05');

INSERT INTO Officers 
VALUES 
(1, 'Ali', 'Khan', 'Admin'),
(2, 'Sana', 'Ahmed', 'Officer'),
(3, 'Ahmed', 'Hussain', 'Admin'),
(4, 'Fatima', 'Akhtar', 'Officer'),
(5, 'Usman', 'Ali', 'Admin');

INSERT INTO Appointments 
VALUES 
(1, 1,1, '2023-01-01'),
(2, 2,2, '2023-02-15'),
(3, 3,3, '2023-03-01'),
(4, 4,4, '2023-04-10'),
(5, 5,5, '2023-05-20');

INSERT INTO Login
values
(1, 'shaafsalman', '1122','Applicant',1),
(2, 'farhanjaffri', '1122','Applicant',2),
(3, 'abdulhadi', '1122','Applicant',3),
(5, 'laibahabib', '1122','Applicant',6),
(6, 'AliKhan','1122', 'Admin',1),
(7, 'SanaAhmed','1122', 'Officer',2);

INSERT INTO Passport
VALUES
(1, 1, 'Shaaf', 'Salman', '2002-09-27', 'Male', 'shaaf.salman@gmail.com', '0312-1234567', '123 Main Street, Lahore', 'Pakistan', 'Engineer', 'PK1234567', 36, '2022-01-01', '2027-01-01'),