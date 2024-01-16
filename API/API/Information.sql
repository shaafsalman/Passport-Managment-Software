CREATE TABLE Applications (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CNIC NVARCHAR(255),
    FirstName NVARCHAR(255),
    LastName NVARCHAR(255),
    Email NVARCHAR(255),
    PhoneNumber NVARCHAR(255),
    HomeAddress NVARCHAR(255),
    DOB DATE,
    PageCounts INT,
    Gender NVARCHAR(255),
    Type NVARCHAR(255),
    Duration INT
);
