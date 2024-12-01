create DATABASE QuanLyBanHang;
USE QuanLyBanHang;


-- Bảng nhân viên
CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    UserRole NVARCHAR(20) NOT NULL CHECK (UserRole IN ('Admin', 'Employee')),
    Username NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE()
);



-- Bảng danh mục sản phẩm
CREATE TABLE ProductCategories (
    CategoryName VARCHAR(50) PRIMARY KEY
);

INSERT INTO ProductCategories (CategoryName) VALUES 
('Food'), ('Electronics'), ('Clothing'), ('Furniture'), ('Beauty'), 
('Toys'), ('Books'), ('Home Appliances'), ('Sports'), ('Automotive'),
('Health'), ('Stationery'), ('Garden'), ('Pets'), ('Music Instruments');


-- Bảng sản phẩm
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    CategoryName VARCHAR(50) REFERENCES ProductCategories(CategoryName) ON UPDATE CASCADE,
    Price DECIMAL(10, 2) CHECK (Price >= 0) NOT NULL,
    Brand VARCHAR(50),
    ManufacturingDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    Ingredients VARCHAR(MAX),
    StockQuantity INT CHECK (StockQuantity >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
	CONSTRAINT CK_ExpiryDate_Products CHECK (ExpiryDate > ManufacturingDate)
);

-- Bảng hóa đơn
CREATE TABLE Receipts (
    ReceiptID INT IDENTITY(1,1) PRIMARY KEY,
    TotalPrice DECIMAL(15, 2) CHECK (TotalPrice >= 0) NOT NULL,
    Tax DECIMAL(5, 2),
    PaymentMethod NVARCHAR(20) NOT NULL CHECK (PaymentMethod IN ('Cash', 'Card', 'Other')),
    TransactionDate DATE NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Bảng doanh thu
CREATE TABLE Sales (
    SalesID INT IDENTITY(1,1) PRIMARY KEY,
    TotalIncome DECIMAL(15, 2) CHECK (TotalIncome >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Bảng hóa đơn sản phẩm (liên kết giữa hóa đơn và sản phẩm)
CREATE TABLE Receipts_Products (
    ReceiptID INT REFERENCES Receipts(ReceiptID) ON DELETE CASCADE,
    ProductID INT REFERENCES Products(ProductID) ON DELETE CASCADE,
    Price DECIMAL(10, 2) CHECK (Price >= 0) NOT NULL,
    Quantity INT CHECK (Quantity >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (ReceiptID, ProductID)
);

-- Bảng doanh thu hóa đơn (liên kết giữa doanh thu và hóa đơn)
CREATE TABLE Sales_Receipts (
    SalesID INT REFERENCES Sales(SalesID) ON DELETE CASCADE,
    ReceiptID INT REFERENCES Receipts(ReceiptID) ON DELETE CASCADE,
    Amount DECIMAL(10, 2) CHECK (Amount >= 0) NOT NULL,
    UpdatedAt DATETIME DEFAULT GETDATE(),
    CreatedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (SalesID, ReceiptID)
);

-- Bảng nhật ký thay đổi
CREATE TABLE ModificationLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,   
    TransactionDetails TEXT,       
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- Trigger cập nhật thời gian cho bảng Employees khi cập nhật
go
CREATE TRIGGER trg_UpdateTimestamp_Employees
ON Employees
AFTER UPDATE
AS
BEGIN
    UPDATE Employees
    SET UpdatedAt = GETDATE()
    WHERE EmployeeID IN (SELECT EmployeeID FROM inserted);
END;
GO


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

-- Thủ tục tạo sản phẩm

GO
-- Tạo thủ tục lưu trữ để thêm sản phẩm mới vào bảng Products
CREATE PROCEDURE sp_CreateProduct
    @ProductName VARCHAR(100), -- Tên sản phẩm
    @CategoryName VARCHAR(50), -- Tên danh mục
    @Price DECIMAL(10, 2), -- Giá sản phẩm
    @Brand VARCHAR(50), -- Thương hiệu
    @ManufacturingDate DATE, -- Ngày sản xuất
    @ExpiryDate DATE, -- Ngày hết hạn
    @Ingredients VARCHAR(255), -- Thành phần
    @StockQuantity INT -- Số lượng tồn kho
AS
BEGIN
    -- Thêm thông tin sản phẩm vào bảng Products
    INSERT INTO Products (ProductName, CategoryName, Price, Brand, ManufacturingDate, ExpiryDate, Ingredients, StockQuantity, CreatedAt, UpdatedAt)
    VALUES (@ProductName, @CategoryName, @Price, @Brand, @ManufacturingDate, @ExpiryDate, @Ingredients, @StockQuantity, GETDATE(), GETDATE());
END;

GO
-- Tạo thủ tục lưu trữ để lấy thông tin sản phẩm theo ProductID
CREATE PROCEDURE sp_GetProductByID
    @ProductID INT -- ID sản phẩm
AS
BEGIN
    -- Lấy thông tin sản phẩm từ bảng Products theo ProductID
    SELECT * FROM Products WHERE ProductID = @ProductID;
END;

GO
-- Tạo thủ tục lưu trữ để cập nhật thông tin sản phẩm theo ProductID
CREATE PROCEDURE sp_UpdateProduct
    @ProductID INT, -- ID sản phẩm
    @ProductName VARCHAR(100), -- Tên sản phẩm
    @CategoryName VARCHAR(50), -- Tên danh mục
    @Price DECIMAL(10, 2), -- Giá sản phẩm
    @Brand VARCHAR(50), -- Thương hiệu
    @ManufacturingDate DATE, -- Ngày sản xuất
    @ExpiryDate DATE, -- Ngày hết hạn
    @Ingredients VARCHAR(255), -- Thành phần
    @StockQuantity INT -- Số lượng tồn kho
AS
BEGIN
    -- Cập nhật thông tin sản phẩm trong bảng Products
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
-- Tạo thủ tục lưu trữ để xóa sản phẩm theo ProductID
CREATE PROCEDURE sp_DeleteProduct
    @ProductID INT -- ID sản phẩm
AS
BEGIN
    -- Xóa sản phẩm khỏi bảng Products theo ProductID
    DELETE FROM Products WHERE ProductID = @ProductID;
END;

GO

-- Tạo thủ tục lưu trữ để lấy thông tin biên lai theo ReceiptID
CREATE PROCEDURE sp_GetReceiptByID
    @ReceiptID INT -- ID biên lai
AS
BEGIN
    -- Lấy thông tin biên lai từ bảng Receipts theo ReceiptID
    SELECT * FROM Receipts WHERE ReceiptID = @ReceiptID;
END;
GO

-- Tạo thủ tục lưu trữ để lấy thông tin bán hàng theo SalesID
CREATE PROCEDURE sp_GetSaleByID
    @SalesID INT -- ID bán hàng
AS
BEGIN
    -- Lấy thông tin bán hàng từ bảng Sales theo SalesID
    SELECT * FROM Sales WHERE SalesID = @SalesID;
END;

GO
-- Tạo thủ tục lưu trữ để lấy thông tin sản phẩm từ biên lai
CREATE PROCEDURE sp_GetProductsFromReceipt
    @ReceiptID INT -- ID biên lai
AS
BEGIN
    -- Lấy thông tin sản phẩm từ bảng Receipts_Products kết hợp với bảng Products
    SELECT p.ProductID, p.ProductName, rp.Price, rp.Quantity
    FROM Receipts_Products rp
    JOIN Products p ON rp.ProductID = p.ProductID
    WHERE rp.ReceiptID = @ReceiptID;
END;

GO
-- Tạo thủ tục lưu trữ để lấy thông tin biên lai từ bán hàng
CREATE PROCEDURE sp_GetReceiptsFromSale
    @SalesID INT -- ID bán hàng
AS
BEGIN
    -- Lấy thông tin biên lai từ bảng Sales_Receipts kết hợp với bảng Receipts
    SELECT r.ReceiptID, r.TotalPrice, sr.Amount
    FROM Sales_Receipts sr
    JOIN Receipts r ON sr.ReceiptID = r.ReceiptID
    WHERE sr.SalesID = @SalesID;
END;
go
-- Tạo thủ tục lưu trữ để thay đổi vai trò người dùng
CREATE PROCEDURE sp_ChangeUserRole
    @EmployeeID INT, -- ID nhân viên
    @UserRole NVARCHAR(10) -- Vai trò người dùng (Admin hoặc Employee)
AS
BEGIN
    -- Kiểm tra nếu vai trò không hợp lệ
    IF @UserRole NOT IN ('Admin', 'Employee')
    BEGIN
        RAISERROR ('Invalid role. Only "Admin" or "Employee" are allowed.', 16, 1);
        RETURN;
    END

    -- Cập nhật vai trò người dùng trong bảng Employees
    UPDATE Employees
    SET UserRole = @UserRole
    WHERE EmployeeID = @EmployeeID;

    -- Kiểm tra nếu không tìm thấy EmployeeID
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('EmployeeID not found.', 16, 1);
    END
END;
GO

-- Tạo thủ tục lưu trữ để cập nhật thông tin nhân viên
CREATE PROCEDURE sp_UpdateEmployee
    @EmployeeID INT, -- ID nhân viên
    @Username NVARCHAR(255) = NULL, -- Tên đăng nhập
    @Password NVARCHAR(255) = NULL, -- Mật khẩu
    @UserRole NVARCHAR(10) = NULL -- Vai trò người dùng
AS
BEGIN
    -- Kiểm tra nếu vai trò không hợp lệ
    IF @UserRole IS NOT NULL AND @UserRole NOT IN ('Admin', 'Employee')
    BEGIN
        RAISERROR ('Invalid role. Only "Admin" or "Employee" are allowed.', 16, 1);
        RETURN;
    END

    -- Cập nhật thông tin nhân viên trong bảng Employees
    UPDATE Employees
    SET 
        Username = ISNULL(@Username, Username),
        Password = ISNULL(@Password, Password),
        UserRole = ISNULL(@UserRole, UserRole)
    WHERE EmployeeID = @EmployeeID;

    -- Kiểm tra nếu không tìm thấy EmployeeID
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('EmployeeID not found.', 16, 1);
    END
END;
GO

-- Tạo thủ tục lưu trữ để xóa nhân viên
CREATE PROCEDURE sp_DeleteEmployee
    @EmployeeID INT -- ID nhân viên
AS
BEGIN
    -- Xóa nhân viên khỏi bảng Employees theo EmployeeID
    DELETE FROM Employees
    WHERE EmployeeID = @EmployeeID;

    -- Kiểm tra nếu không tìm thấy EmployeeID
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR ('EmployeeID not found.', 16, 1);
    END
END;
GO
--Tạo thủ tuc lưu trữ để thêm nhân viên
CREATE PROCEDURE sp_CreateEmployeeUser
    @UserRole NVARCHAR(20),
    @Username NVARCHAR(255),
    @Password NVARCHAR(255)
AS
BEGIN
    -- Validate UserRole to ensure it's either 'Admin' or 'Employee'
    IF @UserRole NOT IN ('Admin', 'Employee')
    BEGIN
        RAISERROR('Invalid UserRole. It must be either "Admin" or "Employee".', 16, 1);
        RETURN;
    END

    -- Insert new user into Employees table
    INSERT INTO Employees (UserRole, Username, Password, CreatedAt, UpdatedAt)
    VALUES (@UserRole, @Username, @Password, GETDATE(), GETDATE());

    -- Optionally, return the newly inserted EmployeeID
    SELECT SCOPE_IDENTITY() AS NewEmployeeID;
END;

-- Mock datas (BULK INSERT IS NOT WORKING)
-- Manual Insert

INSERT INTO Products (ProductName, CategoryName, Price, Brand, ManufacturingDate, ExpiryDate, Ingredients, StockQuantity, UpdatedAt, CreatedAt) VALUES
('Cinnamon Raisin Bread', 'Food', 3.79, 'Microsoft', '2024-11-20', '2025-11-20', 'Cinnamon, Raisins, Wheat flour, Sugar', 50, '2024-10-27', '2024-03-03'),
('Smartphone', 'Electronics', 699.99, 'Apple', '2024-08-01', '2025-08-01', 'Display, Battery, Processor, Camera', 120, '2024-11-01', '2024-03-01'),
('Jeans', 'Clothing', 49.99, 'Levis', '2023-05-15', '2024-05-15', 'Cotton, Polyester', 200, '2024-09-05', '2024-03-15'),
('Office Chair', 'Furniture', 149.99, 'Ikea', '2023-12-01', '2025-12-01', 'Wood, Fabric, Steel', 75, '2024-09-01', '2024-02-15'),
('Shampoo', 'Beauty', 5.99, 'Pantene', '2024-06-01', '2025-06-01', 'Water, Shampoo, Conditioner', 300, '2024-10-01', '2024-03-05'),
('Toy Car', 'Toys', 15.99, 'Hot Wheels', '2024-07-01', '2025-07-01', 'Plastic, Rubber', 100, '2024-09-10', '2024-03-10'),
('Laptop', 'Electronics', 1200.00, 'Dell', '2023-09-01', '2024-09-01', 'Intel i7, 16GB RAM, SSD', 80, '2024-11-02', '2024-02-20'),
('Table', 'Furniture', 80.00, 'Ikea', '2023-06-15', '2025-06-15', 'Wood, Steel', 150, '2024-11-05', '2024-03-05'),
('Washing Machine', 'Home Appliances', 499.99, 'Samsung', '2024-05-01', '2025-05-01', 'Plastic, Steel', 60, '2024-11-10', '2024-03-10'),
('Vitamin C', 'Health', 12.99, 'Nature Made', '2024-07-15', '2025-07-15', 'Vitamin C, Gelatin', 400, '2024-11-12', '2024-03-15'),
('Treadmill', 'Sports', 799.99, 'NordicTrack', '2024-06-01', '2025-06-01', 'Steel, Rubber, Plastic', 50, '2024-11-20', '2024-03-20');

-- Receipts Table
INSERT INTO Receipts (TotalPrice, Tax, PaymentMethod, TransactionDate, UpdatedAt, CreatedAt) VALUES
(200.00, 20.00, 'Card', '2024-11-01', '2024-11-01', '2024-11-01'),
(1200.50, 120.05, 'Cash', '2024-10-15', '2024-10-15', '2024-10-15'),
(300.99, 30.10, 'Card', '2024-10-20', '2024-10-20', '2024-10-20'),
(1500.00, 150.00, 'Card', '2024-11-10', '2024-11-10', '2024-11-10'),
(650.50, 65.05, 'Cash', '2024-11-05', '2024-11-05', '2024-11-05');

-- Sales Table
INSERT INTO Sales (TotalIncome, UpdatedAt, CreatedAt) VALUES
(1500.00, '2024-11-01', '2024-10-01'),
(2500.00, '2024-10-15', '2024-09-15'),
(3500.00, '2024-10-20', '2024-09-20'),
(5000.00, '2024-11-10', '2024-10-05'),
(2000.00, '2024-11-02', '2024-09-02');

-- Receipts_Products Table
INSERT INTO Receipts_Products (ReceiptID, ProductID, Price, Quantity, UpdatedAt, CreatedAt) VALUES
(1, 1, 3.79, 2, '2024-11-01', '2024-11-01'),
(2, 2, 699.99, 1, '2024-10-15', '2024-10-15'),
(3, 3, 49.99, 4, '2024-10-20', '2024-10-20'),
(1, 4, 149.99, 1, '2024-11-01', '2024-11-01'),
(2, 5, 5.99, 5, '2024-10-15', '2024-10-15'),
(4, 6, 15.99, 3, '2024-11-10', '2024-11-10'),
(3, 7, 1200.00, 1, '2024-10-20', '2024-10-20'),
(5, 8, 80.00, 2, '2024-11-05', '2024-11-05'),
(4, 9, 499.99, 1, '2024-11-10', '2024-11-10'),
(5, 10, 12.99, 6, '2024-11-12', '2024-11-12');

-- Sales_Receipts Table
INSERT INTO Sales_Receipts (SalesID, ReceiptID, Amount, UpdatedAt, CreatedAt) VALUES
(1, 1, 200.00, '2024-11-01', '2024-11-01'),
(2, 2, 1200.50, '2024-10-15', '2024-10-15'),
(3, 3, 300.99, '2024-10-20', '2024-10-20'),
(4, 4, 1500.00, '2024-11-10', '2024-11-10'),
(5, 5, 650.50, '2024-11-05', '2024-11-05');




 