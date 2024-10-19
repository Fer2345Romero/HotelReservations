CREATE DATABASE HotelReservations;

USE HotelReservations;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
    ContactInformation VARCHAR(255),
    Address VARCHAR(255)
);

CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomType VARCHAR(255) NOT NULL,
    PricePerNight DECIMAL(10, 2) NOT NULL,
    IsAvailable BIT DEFAULT 1
);

CREATE TABLE Reservations (
    ReservationID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    RoomID INT FOREIGN KEY REFERENCES Rooms(RoomID),
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalCost DECIMAL(10, 2)
);


--PROCEDIMIENTO PARA BUSCAR POR NOMBRE DE CLIENTE
CREATE PROCEDURE SearchReservationsByCustomerName
    @CustomerName VARCHAR(255)
AS
BEGIN
    SELECT 
        r.ReservationID,
        c.Name AS CustomerName,
        rm.RoomType,
        r.CheckInDate,
        r.CheckOutDate,
        r.TotalCost
    FROM 
        Reservations r
    INNER JOIN 
        Customers c ON r.CustomerID = c.CustomerID
    INNER JOIN 
        Rooms rm ON r.RoomID = rm.RoomID
    WHERE 
        c.Name LIKE '%' + @CustomerName + '%';
END;




--PROCEDIMIENTO PARA BUSCAR POR HABITACIÓN EN LAS RESERVACIONES

CREATE PROCEDURE SearchReservationsByRoomType
    @RoomType VARCHAR(255)
AS
BEGIN
    SELECT 
        r.ReservationID,
        c.Name AS CustomerName,
        rm.RoomType,
        r.CheckInDate,
        r.CheckOutDate,
        r.TotalCost
    FROM 
        Reservations r
    INNER JOIN 
        Customers c ON r.CustomerID = c.CustomerID
    INNER JOIN 
        Rooms rm ON r.RoomID = rm.RoomID
    WHERE 
        rm.RoomType LIKE '%' + @RoomType + '%';
END;


----prueba del procedimiento
--nombre
EXEC SearchReservationsByCustomerName @CustomerName = 'Ivania';
--habitación
EXEC SearchReservationsByRoomType @RoomType = 'Individual';


---PROCEDIMEINTO PARA BUSCAR RESERVACIONES POR RANGO DE FECHAS.
ALTER PROCEDURE sp_SearchDateTime
    @startDate DATETIME,
    @endDate DATETIME
AS
BEGIN
    SELECT 
        r.ReservationID,
        c.Name AS CustomerName,  -- Obtener el nombre del cliente
        ro.RoomType AS RoomType,  -- Obtener el tipo de habitación
        r.CheckInDate,
        r.CheckOutDate,
        r.TotalCost
    FROM Reservations r
    INNER JOIN Customers c ON r.CustomerID = c.CustomerID  -- Unir con la tabla de clientes
    INNER JOIN Rooms ro ON r.RoomID = ro.RoomID  -- Unir con la tabla de habitaciones
    WHERE r.CheckInDate BETWEEN @startDate AND @endDate;
END




---INSERTAR DATOS  EN LA TABLA CLIENTES 
INSERT INTO Customers (Name, ContactInformation, Address)
VALUES
('David Romero', 'david.rom@gmail.com', '123 San Miguel'),
('Jane Smith', 'jane.smith@gmail.com', '456 Oak St'),
('Carlos Pérez', 'carlos.perez@gmail.com', '789 Pine St'),
('Lucía Gómez', 'lucia.gomez@gmail.com', '321 Maple St'),
('David Johnson', 'david.johnson@gmail.com', '654 Elm St'),
('Laura Martínez', 'laura.martinez@gmail.com', '987 Birch St'),
('Miguel Hernández', 'miguel.hernandez@gmail.com', '246 Cedar St'),
('Emily Davis', 'emily.davis@gmail.com', '135 Willow St'),
('José García', 'jose.garcia@gmail.com', '357 Aspen St'),
('Ana López', 'ana.lopez@gmail.com', '579 Palm St');


---INSERTAR DATOS EN LA TABLA HABITACIONES
INSERT INTO Rooms (RoomType, PricePerNight)
VALUES
('Single', 100.00),
('Double', 150.00),
('Suite', 250.00),
('Single', 100.00),
('Double', 150.00),
('Suite', 250.00),
('Single', 100.00),
('Double', 150.00),
('Suite', 250.00),
('Presidential Suite', 500.00);

---INSERTAR DATOS EN LA TABLA RESERVACIONES
INSERT INTO Reservations (CustomerID, RoomID, CheckInDate, CheckOutDate, TotalCost)
VALUES
(1, 1, '2024-11-01', '2024-11-05', 400.00),
(2, 2, '2024-11-03', '2024-11-07', 600.00),
(3, 3, '2024-11-02', '2024-11-06', 1000.00),
(4, 4, '2024-11-10', '2024-11-12', 200.00),
(5, 5, '2024-11-11', '2024-11-15', 600.00),
(6, 6, '2024-11-12', '2024-11-16', 1000.00),
(7, 7, '2024-11-13', '2024-11-18', 500.00),
(8, 8, '2024-11-14', '2024-11-19', 750.00),
(9, 9, '2024-11-15', '2024-11-20', 1250.00),
(10, 10, '2024-11-16', '2024-11-22', 3000.00);