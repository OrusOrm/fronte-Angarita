create database ABUABU

USE ABUABU

CREATE TABLE Usuarios(
UserID Int identity primary key,
Nombre Varchar(25),
Email Varchar(30),
Direccion Varchar(20)
);

INSERT INTO Usuarios (Nombre, Email, Direccion) VALUES ('Juan Perez', 'juan@email.com', '123 Calle Principal');
INSERT INTO Usuarios (Nombre, Email, Direccion) VALUES ('Maria Rodriguez', 'maria@email.com', '456 Avenida Secundaria');
INSERT INTO Usuarios (Nombre, Email, Direccion) VALUES ('Carlos González', 'carlos@email.com', '23444');
INSERT INTO Usuarios (Nombre, Email, Direccion) VALUES ('Eduardo Fernández Pérez', 'eduardo@email.com', '789 Calle Larga');


CREATE TABLE Productos(
ProductoID Int identity Primary key,
Nombre varchar(25),
Link Varchar(70),
Precio INT,
Stock int
);

SELECT * FROM Productos;

-- Inserción 1
INSERT INTO Productos (Nombre, Link, Precio, Stock)
VALUES ('Camiseta Roja', 'https://www.ejemplo.com/camiseta-roja', 20, 50);

-- Inserción 2
INSERT INTO Productos (Nombre, Link, Precio, Stock)
VALUES ('Zapatillas Deportivas', 'https://www.ejemplo.com/zapatillas', 80, 30);

-- Inserción 3
INSERT INTO Productos (Nombre, Link, Precio, Stock)
VALUES ('Cafetera Express', 'https://www.ejemplo.com/cafetera', 120, 10);

-- Inserción 4
INSERT INTO Productos (Nombre, Link, Precio, Stock)
VALUES ('Mouse Inalámbrico', 'https://www.ejemplo.com/mouse', 15, 100);

-- Inserción 5
INSERT INTO Productos (Nombre, Link, Precio, Stock)
VALUES ('Libro "La Aventura"', 'https://www.ejemplo.com/libro', 10, 200);

SELECT * FROM Compras;


CREATE TABLE Compras(
ComprasID int primary key, 
fk_UserID Int,
fk_ProductoID Int,
FechaCompra datetime default GETDATE(),
FOREIGN KEY (fk_UserID) REFERENCES Usuarios(UserID),
FOREIGN KEY (fk_ProductoID) REFERENCES Productos(ProductoID)
);

select * from Compras;

-- Inserción 1: Un usuario compra un producto en una fecha específica
INSERT INTO Compras (ComprasID, fk_UserID, fk_ProductoID, FechaCompra)
VALUES (1, 1, 1, '2023-09-01 10:30:00');

-- Inserción 2: Otro usuario compra otro producto en una fecha diferente
INSERT INTO Compras (ComprasID, fk_UserID, fk_ProductoID, FechaCompra)
VALUES (2, 2, 2, '2023-09-02 14:15:00');

-- Inserción 3: Un usuario compra el mismo producto nuevamente
INSERT INTO Compras (ComprasID, fk_UserID, fk_ProductoID, FechaCompra)
VALUES (3, 1, 1, '2023-09-03 09:45:00');

-- Inserción 4: Otro usuario compra un tercer producto
INSERT INTO Compras (ComprasID, fk_UserID, fk_ProductoID, FechaCompra)
VALUES (4, 3, 3, '2023-09-04 17:20:00');
use ABUABU
--Procedimientos almacenados de la tabla compras

CREATE PROCEDURE Registrar_C
    @ComprasID Int,
    @fk_ProductoID INT,
    @fk_UserID INT,
    @FechaCompra DATETIME
AS
BEGIN
    INSERT INTO Compras (ComprasID,fk_ProductoID, fk_UserID, FechaCompra)
    VALUES (@ComprasID,@fk_ProductoID, @fk_UserID, @FechaCompra)
END




CREATE PROCEDURE Actualizar_C
    @ComprasID INT,
    @fk_ProductoID INT,
    @fk_UserID INT,
    @FechaCompra DATETIME
AS
BEGIN
    UPDATE Compras
    SET fk_ProductoID = @fk_ProductoID, fk_UserID = @fk_UserID, FechaCompra = @FechaCompra
    WHERE ComprasID = @ComprasID
END


CREATE PROCEDURE Eliminar_C
    @ComprasID INT
AS
BEGIN
    DELETE FROM Compras
    WHERE ComprasID = @ComprasID
END


CREATE PROCEDURE Listar_C
AS
BEGIN
    SELECT ComprasID,fk_UserID, fk_ProductoID, FechaCompra
    FROM Compras
END


CREATE PROCEDURE Consultar_C
    @ComprasID INT
AS
BEGIN
    SELECT ComprasID, fk_ProductoID AS ProductoID, fk_UserID AS UserID, FechaCompra
    FROM Compras
    WHERE ComprasID = @ComprasID
END



--Procedimientos almacenados de usuarios

CREATE PROCEDURE Registrar_Us
    @Nombre NVARCHAR(25),
    @Email NVARCHAR(30),
    @Direccion NVARCHAR(20)
AS
BEGIN
    INSERT INTO Usuarios (Nombre, Email, Direccion)
    VALUES (@Nombre, @Email, @Direccion)
END


CREATE PROCEDURE Actualizar_Us
    @UserID INT,
    @Nombre NVARCHAR(25),
    @Email NVARCHAR(30),
    @Direccion NVARCHAR(20)
AS
BEGIN
    UPDATE Usuarios
    SET Nombre = @Nombre, Email = @Email, Direccion = @Direccion
    WHERE UserID = @UserID
END


CREATE PROCEDURE Eliminar_Us
    @UserID INT
AS
BEGIN
    DELETE FROM Usuarios
    WHERE UserID = @UserID
END


CREATE PROCEDURE Listar_Us
AS
BEGIN
    SELECT UserID, Nombre, Email, Direccion
    FROM Usuarios
END


CREATE PROCEDURE Consultar_P
    @ProductoID INT
AS
BEGIN
    SELECT ProductoID, Nombre, Link, Precio, Stock
    FROM Productos
    WHERE ProductoID = @ProductoID
END



CREATE PROCEDURE Actualizar_P
    @ProductoID INT,
    @Nombre NVARCHAR(25),
    @Link NVARCHAR(70),
    @Precio INT,
	@Stock int
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre, Link = @Link, Precio = @Precio, Stock= @Stock
    WHERE ProductoID = @ProductoID
END

create PROCEDURE Registrar_P
    @Nombre varchar(25),
    @Link Varchar(70),
    @Precio INT,
	@Stock int

AS
BEGIN
    INSERT INTO Productos (Nombre, Link, Precio,Stock)
    VALUES (@Nombre, @Link, @Precio,@Stock)
END






