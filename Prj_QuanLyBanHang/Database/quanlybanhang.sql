CREATE DATABASE QuanLyBanHang;
USE QuanLyBanHang;

-- Product Category Table
CREATE TABLE ProductCategories (
    CategoryName VARCHAR(50) PRIMARY KEY
);

INSERT INTO ProductCategories (CategoryName) VALUES 
('Food'), ('Electronics'), ('Clothing'), ('Furniture'), ('Beauty'), 
('Toys'), ('Books'), ('Home Appliances'), ('Sports'), ('Automotive'),
('Health'), ('Stationery'), ('Garden'), ('Pets'), ('Music Instruments');

-- Payment Method Table
CREATE TABLE PaymentMethods (
    MethodName VARCHAR(50) PRIMARY KEY
);

INSERT INTO PaymentMethods (MethodName) VALUES 
('Cash'), ('Card'), ('Other');

-- Products Table
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    CategoryName VARCHAR(50) REFERENCES ProductCategories(CategoryName) ON UPDATE CASCADE,
    Price DECIMAL(10, 2) CHECK (Price >= 0) NOT NULL,
    Brand VARCHAR(50),
    ManufacturingDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    Ingredients VARCHAR(255),
    StockQuantity INT CHECK (StockQuantity >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
	CONSTRAINT CK_ExpiryDate_Products CHECK (ExpiryDate > ManufacturingDate)
);

-- Receipts Table
CREATE TABLE Receipts (
    ReceiptID INT IDENTITY(1,1) PRIMARY KEY,
    TotalPrice DECIMAL(15, 2) CHECK (TotalPrice >= 0) NOT NULL,
    Tax DECIMAL(5, 2),
    PaymentMethod VARCHAR(50) REFERENCES PaymentMethods(MethodName) ON UPDATE CASCADE,
    TransactionDate DATE NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Sales Table
CREATE TABLE Sales (
    SalesID INT IDENTITY(1,1) PRIMARY KEY,
    TotalIncome DECIMAL(15, 2) CHECK (TotalIncome >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Receipts_Products Table
CREATE TABLE Receipts_Products (
    ReceiptID INT REFERENCES Receipts(ReceiptID) ON DELETE CASCADE,
    ProductID INT REFERENCES Products(ProductID) ON DELETE CASCADE,
    Price DECIMAL(10, 2) CHECK (Price >= 0) NOT NULL,
    Quantity INT CHECK (Quantity >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (ReceiptID, ProductID)
);

-- Sales_Receipts Table
CREATE TABLE Sales_Receipts (
    SalesID INT REFERENCES Sales(SalesID) ON DELETE CASCADE,
    ReceiptID INT REFERENCES Receipts(ReceiptID) ON DELETE CASCADE,
    Amount DECIMAL(10, 2) CHECK (Amount >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (SalesID, ReceiptID)
);

-- Modification Log Table
CREATE TABLE ModificationLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,   
    TransactionDetails TEXT,       
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Triggers for Updating Timestamp
GO
CREATE TRIGGER trg_UpdateTimestamp_Products
ON Products
AFTER UPDATE
AS
BEGIN
    UPDATE Products
    SET UpdatedAt = GETDATE()
    WHERE ProductID IN (SELECT ProductID FROM inserted);
END;

GO
CREATE TRIGGER trg_UpdateTimestamp_Receipts
ON Receipts
AFTER UPDATE
AS
BEGIN
    UPDATE Receipts
    SET UpdatedAt = GETDATE()
    WHERE ReceiptID IN (SELECT ReceiptID FROM inserted);
END;

GO
CREATE TRIGGER trg_UpdateTimestamp_Receipts_Products
ON Receipts_Products
AFTER UPDATE
AS
BEGIN
    UPDATE Receipts_Products
    SET UpdatedAt = GETDATE()
    WHERE ReceiptID IN (SELECT ReceiptID FROM inserted) AND ProductID IN (SELECT ProductID FROM inserted);
END;

GO
CREATE TRIGGER trg_UpdateTimestamp_Sales_Receipts
ON Sales_Receipts
AFTER UPDATE
AS
BEGIN
    UPDATE Sales_Receipts
    SET UpdatedAt = GETDATE()
    WHERE SalesID IN (SELECT SalesID FROM inserted) AND ReceiptID IN (SELECT ReceiptID FROM inserted);
END;

-- Stored procedure

-- Create a Product
GO
CREATE PROCEDURE sp_CreateProduct
    @ProductName VARCHAR(100),
    @CategoryName VARCHAR(50),
    @Price DECIMAL(10, 2),
    @Brand VARCHAR(50),
    @ManufacturingDate DATE,
    @ExpiryDate DATE,
    @Ingredients VARCHAR(255),
    @StockQuantity INT
AS
BEGIN
    INSERT INTO Products (ProductName, CategoryName, Price, Brand, ManufacturingDate, ExpiryDate, Ingredients, StockQuantity, CreatedAt, UpdatedAt)
    VALUES (@ProductName, @CategoryName, @Price, @Brand, @ManufacturingDate, @ExpiryDate, @Ingredients, @StockQuantity, GETDATE(), GETDATE());
END;

GO
-- Get Product by ID
CREATE PROCEDURE sp_GetProductByID
    @ProductID INT
AS
BEGIN
    SELECT * FROM Products WHERE ProductID = @ProductID;
END;

GO
-- Update Product
CREATE PROCEDURE sp_UpdateProduct
    @ProductID INT,
    @ProductName VARCHAR(100),
    @CategoryName VARCHAR(50),
    @Price DECIMAL(10, 2),
    @Brand VARCHAR(50),
    @ManufacturingDate DATE,
    @ExpiryDate DATE,
    @Ingredients VARCHAR(255),
    @StockQuantity INT
AS
BEGIN
    UPDATE Products
    SET ProductName = @ProductName,
        CategoryName = @CategoryName,
        Price = @Price,
        Brand = @Brand,
        ManufacturingDate = @ManufacturingDate,
        ExpiryDate = @ExpiryDate,
        Ingredients = @Ingredients,
        StockQuantity = @StockQuantity,
        UpdatedAt = GETDATE()
    WHERE ProductID = @ProductID;
END;

GO
-- Delete Product
CREATE PROCEDURE sp_DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Products WHERE ProductID = @ProductID;
END;

GO
-- Create a Receipt
CREATE PROCEDURE sp_CreateReceipt
    @TotalPrice DECIMAL(15, 2),
    @Tax DECIMAL(5, 2),
    @PaymentMethod VARCHAR(50),
    @TransactionDate DATE
AS
BEGIN
    INSERT INTO Receipts (TotalPrice, Tax, PaymentMethod, TransactionDate, CreatedAt, UpdatedAt)
    VALUES (@TotalPrice, @Tax, @PaymentMethod, @TransactionDate, GETDATE(), GETDATE());
END;

GO
-- Get Receipt by ID
CREATE PROCEDURE sp_GetReceiptByID
    @ReceiptID INT
AS
BEGIN
    SELECT * FROM Receipts WHERE ReceiptID = @ReceiptID;
END;

GO
-- Update Receipt
CREATE PROCEDURE sp_UpdateReceipt
    @ReceiptID INT,
    @TotalPrice DECIMAL(15, 2),
    @Tax DECIMAL(5, 2),
    @PaymentMethod VARCHAR(50),
    @TransactionDate DATE
AS
BEGIN
    UPDATE Receipts
    SET TotalPrice = @TotalPrice,
        Tax = @Tax,
        PaymentMethod = @PaymentMethod,
        TransactionDate = @TransactionDate,
        UpdatedAt = GETDATE()
    WHERE ReceiptID = @ReceiptID;
END;

GO
-- Delete Receipt
CREATE PROCEDURE sp_DeleteReceipt
    @ReceiptID INT
AS
BEGIN
    DELETE FROM Receipts WHERE ReceiptID = @ReceiptID;
END;

GO
-- Create Sales
CREATE PROCEDURE sp_CreateSale
    @TotalIncome DECIMAL(15, 2)
AS
BEGIN
    INSERT INTO Sales (TotalIncome, CreatedAt, UpdatedAt)
    VALUES (@TotalIncome, GETDATE(), GETDATE());
END;

GO
-- Get Sale by ID
CREATE PROCEDURE sp_GetSaleByID
    @SalesID INT
AS
BEGIN
    SELECT * FROM Sales WHERE SalesID = @SalesID;
END;

GO
-- Update Sale
CREATE PROCEDURE sp_UpdateSale
    @SalesID INT,
    @TotalIncome DECIMAL(15, 2)
AS
BEGIN
    UPDATE Sales
    SET TotalIncome = @TotalIncome,
        UpdatedAt = GETDATE()
    WHERE SalesID = @SalesID;
END;

GO
-- Delete Sale
CREATE PROCEDURE sp_DeleteSale
    @SalesID INT
AS
BEGIN
    DELETE FROM Sales WHERE SalesID = @SalesID;
END;

GO
-- Add Products to Receipt (Receipts_Products)
CREATE PROCEDURE sp_AddProductToReceipt
    @ReceiptID INT,
    @ProductID INT,
    @Price DECIMAL(10, 2),
    @Quantity INT
AS
BEGIN
    INSERT INTO Receipts_Products (ReceiptID, ProductID, Price, Quantity, CreatedAt, UpdatedAt)
    VALUES (@ReceiptID, @ProductID, @Price, @Quantity, GETDATE(), GETDATE());
END;

GO
-- Get Products from Receipt
CREATE PROCEDURE sp_GetProductsFromReceipt
    @ReceiptID INT
AS
BEGIN
    SELECT p.ProductID, p.ProductName, rp.Price, rp.Quantity
    FROM Receipts_Products rp
    JOIN Products p ON rp.ProductID = p.ProductID
    WHERE rp.ReceiptID = @ReceiptID;
END;

GO
-- Add Receipt to Sale (Sales_Receipts)
CREATE PROCEDURE sp_AddReceiptToSale
    @SalesID INT,
    @ReceiptID INT,
    @Amount DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Sales_Receipts (SalesID, ReceiptID, Amount, CreatedAt, UpdatedAt)
    VALUES (@SalesID, @ReceiptID, @Amount, GETDATE(), GETDATE());
END;

GO
-- Get Receipts from Sale
CREATE PROCEDURE sp_GetReceiptsFromSale
    @SalesID INT
AS
BEGIN
    SELECT r.ReceiptID, r.TotalPrice, sr.Amount
    FROM Sales_Receipts sr
    JOIN Receipts r ON sr.ReceiptID = r.ReceiptID
    WHERE sr.SalesID = @SalesID;
END;
