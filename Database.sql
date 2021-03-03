CREATE TABLE Brands (
	Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Name] nvarchar(20) NULL
);

CREATE TABLE Colors (
	Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
	[Name] nvarchar(20) NULL
);

CREATE TABLE Cars (
    Id int PRIMARY KEY NOT NULL IDENTITY(1,1),
    BrandId int NOT NULL FOREIGN KEY REFERENCES Brands(Id),
    ColorId int NOT NULL FOREIGN KEY REFERENCES Colors(Id),
    DailyPrice int NULL,
    ModelYear int NULL,
    [Name] nvarchar(20) NULL,
    [Description] nvarchar(20) NULL,
);

CREATE TABLE CarImages (
	Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	CarId INT NOT NULL FOREIGN KEY REFERENCES Cars(Id),
	ImagePath NVARCHAR(120) NOT NULL,
	[Date] DATE NULL
);

CREATE TABLE Users (
	Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(20) NULL,
	LastName nvarchar(20) NULL,
	Email nvarchar(20) NULL,
	[Password] nvarchar(20) NULL
);

CREATE TABLE Customers (
	Id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	UserId int NOT NULL FOREIGN KEY REFERENCES Users(Id),
	CompanyName nvarchar(20) NULL
);

CREATE TABLE Rentals (
	Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CarId int NOT NULL FOREIGN KEY REFERENCES Cars(Id),
	CustomerId int NOT NULL FOREIGN KEY REFERENCES Customers(Id),
	RentDate Date NULL,
	ReturnDate Date NULL
);


