CREATE TABLE [Users](
    ID INT PRIMARY KEY NOT NULL,
    [Login] VARCHAR(MAX) NOT NULL,
    [Password] VARCHAR(MAX) NOT NULL,
    [Role] VARCHAR(MAX) NOT NULL
);
-- Таблица партнеров
CREATE TABLE Partners (
    PartnerID INT PRIMARY KEY NOT NULL,
    PartnerType VARCHAR(MAX) NOT NULL,
    CompanyName VARCHAR(MAX) NOT NULL,
    LegalAddress VARCHAR(MAX) NOT NULL,
    INN VARCHAR(12) NOT NULL,
    DirectorFullName VARCHAR(MAX) NOT NULL,
    ContactPhone VARCHAR(20) NOT NULL,
    ContactEmail VARCHAR(MAX),
    Logo VARCHAR(MAX) DEFAULT 'https://sun9-10.userapi.com/impg/IOxWhTf5vHdaErwvUHz6LpVBtdbQXH_eUBHG-w/JrxHi27cfr8.jpg?size=320x320&quality=95&sign=cbbcb855a0aa5040958e0957f92f477b&type=album',
    Rating INT DEFAULT 1 CHECK (Rating >= 1 AND Rating <= 5),
    RubExchangeRate DECIMAL (10,4) DEFAULT 1.0
);

-- Таблица менеджеров
CREATE TABLE Managers (
    ManagerID INT PRIMARY KEY NOT NULL,
    FullName VARCHAR(255) NOT NULL
);

-- Таблица Заявок
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY NOT NULL,
    PartnerID INT NOT NULL,
    ManagerID INT NOT NULL,
    OrderDate DATE NOT NULL,
    OrderStatus VARCHAR(50) NOT NULL,
    PrepaymentAmount DECIMAL(15,2),
    PrepaymentDate DATETIME,
    TotalAmount DECIMAL(15,2),
    DeliveryRequired BIT DEFAULT 0,
    DeliveryAddress VARCHAR(255),
    FOREIGN KEY (PartnerID) REFERENCES Partners(PartnerID),
    FOREIGN KEY (ManagerID) REFERENCES Managers(ManagerID)
);

-- Таблица продукции
CREATE TABLE Products (
    ProductID INT PRIMARY KEY NOT NULL,
    Article VARCHAR(50) NOT NULL UNIQUE,
    ProductType VARCHAR(50) NOT NULL,
    ProductName VARCHAR(255) NOT NULL,
    [Description] VARCHAR(MAX) NOT NULL,
    [Image] VARCHAR(MAX) DEFAULT 'https://sun9-10.userapi.com/impg/IOxWhTf5vHdaErwvUHz6LpVBtdbQXH_eUBHG-w/JrxHi27cfr8.jpg?size=320x320&quality=95&sign=cbbcb855a0aa5040958e0957f92f477b&type=album',
    MinPriceForPartner DECIMAL(15,2) NOT NULL,
    PackageLength DECIMAL(10,2) NOT NULL,
    PackageWidth DECIMAL(10,2) NOT NULL,
    PackageHeight DECIMAL(10,2) NOT NULL,
    WeightWithoutPackage DECIMAL(10,2) NOT NULL,
    WeightWithPackage DECIMAL(10,2) NOT NULL,
    QualityCertificate VARCHAR(MAX) NOT NULL,
    StandardNumber VARCHAR(50) NOT NULL,
    ProductionTime TIME NOT NULL,
    ProductionCost DECIMAL(15,2),
    WorkshopNumber INT NOT NULL,
    ProductionWorkers INT NOT NULL
);

-- Таблица элементов заявок (связь заявки и продукции)
CREATE TABLE OrderItems (
    OrderItemID INT PRIMARY KEY NOT NULL,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    PricePerUnit DECIMAL(15,2) NOT NULL,
    ProductionDate DATE NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Таблица Сотрудников
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY NOT NULL,
    FullName VARCHAR(MAX) NOT NULL,
    BirthDate DATE NOT NULL,
    PassportData VARCHAR(MAX) NOT NULL,
    BankAccount VARCHAR(MAX) NOT NULL,
    FamilyStatus VARCHAR(MAX) NOT NULL,
    HealthInfo VARCHAR(MAX) NOT NULL
);

-- Таблица Кадров (допуск к оборудованию)
CREATE TABLE EmployeeSkills (
    EmployeeSkillID INT PRIMARY KEY NOT NULL,
    EmployeeID INT NOT NULL,
    EquipmentName VARCHAR(MAX) NOT NULL,
    SkillLevel VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Таблица доступа (карты и перемещения)
CREATE TABLE AccessLogs (
    AccessLogID INT PRIMARY KEY NOT NULL,
    EmployeeID INT NOT NULL,
    CardID VARCHAR(50) NOT NULL,
    AccessTime DATETIME NOT NULL DEFAULT GETDATE(),
    [Location] VARCHAR(MAX) NOT NULL,
    Direction VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

-- Таблица Поставщиков
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY NOT NULL,
    SupplierType VARCHAR(MAX) NOT NULL,
    SupplierName VARCHAR(MAX) NOT NULL,
    INN VARCHAR(12) NOT NULL UNIQUE
);

-- Таблица материалов (сырья)
CREATE TABLE Materials (
    MaterialID INT PRIMARY KEY NOT NULL,
    MaterialType VARCHAR(MAX) NOT NULL,
    MaterialName VARCHAR(MAX) NOT NULL,
    SupplierID INT NOT NULL,
    QuantityPerPackage INT NOT NULL,
    UnitOfMeasure VARCHAR(MAX) NOT NULL,
    [Description] VARCHAR(MAX) NOT NULL,
    [Image] VARCHAR(MAX) NOT NULL DEFAULT 'https://sun9-10.userapi.com/impg/IOxWhTf5vHdaErwvUHz6LpVBtdbQXH_eUBHG-w/JrxHi27cfr8.jpg?size=320x320&quality=95&sign=cbbcb855a0aa5040958e0957f92f477b&type=album',
    Cost DECIMAL(15,2) NOT NULL,
    QuantityInStock INT NOT NULL DEFAULT 0,
    MinimumQuantity INT NOT NULL DEFAULT 0,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);

-- Таблица складов
CREATE TABLE Warehouses (
    WarehouseID INT PRIMARY KEY NOT NULL,
    WarehouseName VARCHAR(MAX) NOT NULL,
    WarehouseAddress VARCHAR(MAX) NOT NULL
);

-- Таблица запасов на складах (связь материалов и складов)
CREATE TABLE WarehouseStock (
    WarehouseStockID INT PRIMARY KEY NOT NULL,
    WarehouseID INT NOT NULL,
    MaterialID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID),
    FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID)
);

-- Таблица мест продаж партнера
CREATE TABLE PartnerSalesLocations (
    SalesLocationID INT PRIMARY KEY NOT NULL,
    PartnerID INT NOT NULL,
    LocationDescription VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (PartnerID) REFERENCES Partners(PartnerID)
);

-- Таблица истории продаж партнеров
CREATE TABLE SalesHistory (
    SalesHistoryID INT PRIMARY KEY NOT NULL,
    PartnerID INT NOT NULL,
    SaleDate DATE NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    SaleAmount DECIMAL(15,2) NOT NULL,
    FOREIGN KEY (PartnerID) REFERENCES Partners(PartnerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Таблица истории изменений рейтинга партнера
CREATE TABLE PartnerRatingHistory (
    RatingHistoryID INT PRIMARY KEY NOT NULL,
    PartnerID INT NOT NULL,
    ManagerID INT NOT NULL,
    RatingChangeDate DATETIME NOT NULL DEFAULT GETDATE(),
    OldRating DECIMAL(3,2) NOT NULL,
    NewRating DECIMAL(3,2) NOT NULL,
    Reason VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (PartnerID) REFERENCES Partners(PartnerID),
    FOREIGN KEY (ManagerID) REFERENCES Managers(ManagerID)
);

-- Таблица истории поставок от поставщика
CREATE TABLE SupplyHistory (
    SupplyHistoryID INT PRIMARY KEY NOT NULL,
    SupplierID INT NOT NULL,
    MaterialID INT NOT NULL,
    SupplyDate DATETIME NOT NULL DEFAULT GETDATE(),
    Quantity INT NOT NULL,
    SupplyCost DECIMAL(15,2) NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
    FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID)
);

-- Таблица истории изменений количества материалов на складе
CREATE TABLE MaterialStockHistory (
    StockHistoryID INT PRIMARY KEY NOT NULL,
    MaterialID INT NOT NULL,
    ChangeDate DATETIME NOT NULL DEFAULT GETDATE(),
    QuantityChange INT NOT NULL,
    NewQuantity INT NOT NULL,
    Reason VARCHAR(MAX),
    FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID)
);

-- Таблица готовой продукции на складе
CREATE TABLE ProductWarehouseStock (
    ProductWarehouseStockID INT PRIMARY KEY NOT NULL,
    WarehouseID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0,
    FOREIGN KEY (WarehouseID) REFERENCES Warehouses(WarehouseID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Таблица необходимых материалов для производства продукции
CREATE TABLE ProductMaterials (
    ProductMaterialID INT PRIMARY KEY NOT NULL,
    ProductID INT NOT NULL,
    MaterialID INT NOT NULL,
    MaterialQuantity INT NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (MaterialID) REFERENCES Materials(MaterialID)
);

-- Таблица истории изменения минимальной стоимости продукции
CREATE TABLE ProductMinPriceHistory (
    PriceHistoryID INT PRIMARY KEY NOT NULL,
    ProductID INT NOT NULL,
    ChangeDate DATETIME NOT NULL DEFAULT GETDATE(),
    OldPrice DECIMAL(15,2) NOT NULL,
    NewPrice DECIMAL(15,2) NOT NULL,
    Reason VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);