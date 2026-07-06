-- Create Database
CREATE DATABASE CinnamonPOS;
GO

USE CinnamonPOS;
GO

-- Create Sales Table
CREATE TABLE Sales
(
    SaleID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    ProductType NVARCHAR(100) NOT NULL,
    Quantity DECIMAL(10,2) NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    SaleDate DATE NOT NULL
);
GO