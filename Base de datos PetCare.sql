CREATE DATABASE PETCARE

GO

USE PETCARE

GO

CREATE TABLE MEDIOS_PAGO(
	id_mediodepago INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR (50) NOT NULL,
	incremento DECIMAL(5,2) NOT NULL CHECK (incremento >= 0),
	fechaRegistro DATETIME DEFAULT getdate()
)
go

CREATE TABLE ROL(
	idRol INT PRIMARY KEY IDENTITY,
	descripcion varchar(50) NOT NULL UNIQUE,
	fechaRegistro datetime default getdate()
)
go

CREATE TABLE PERMISO(
	idPermiso int primary key IDENTITY,
	idRol INT REFERENCES ROL(idRol),
	nombreMenu VARCHAR(100) NOT NULL,
	fechaRegistro DATETIME DEFAULT getdate()
)
go


CREATE TABLE CLIENTE(
	idCliente INT PRIMARY KEY IDENTITY,
	nombreCompleto VARCHAR(50) NOT NULL,
	fechaRegistro DATETIME DEFAULT getdate()
)
go


CREATE TABLE USUARIO(
	idUSuario INT PRIMARY KEY IDENTITY,
	documento VARCHAR(50) NOT NULL UNIQUE,
	nombreCompleto VARCHAR(50) NOT NULL,
	correo VARCHAR(50) NOT NULL UNIQUE,
	clave VARCHAR(50) NOT NULL,
	idRol int REFERENCES ROL(idRol),
	telefono VARCHAR(25) NOT NULL UNIQUE,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME DEFAULT getdate()
)
go

CREATE TABLE CATEGORIA(
	idCategoria INT PRIMARY KEY IDENTITY,
	descripcion VARCHAR(100) NOT NULL UNIQUE,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME DEFAULT getdate()
)
go


CREATE TABLE PRODUCTO(
	idProducto INT PRIMARY KEY IDENTITY,
	codigo VARCHAR(50) NOT NULL UNIQUE,
	nombre VARCHAR(50) NOT NULL UNIQUE,
	descripcion VARCHAR(50) NOT NULL,
	idCategoria INT REFERENCES CATEGORIA(idCategoria),
	stock_min INT NOT NULL DEFAULT 0 CHECK (stock_min >= 0),
	stock INT NOT NULL DEFAULT 0 CHECK (stock >= 0),
	precio DECIMAL(10,2) DEFAULT 0 CHECK (precio >= 0), 
	precioVenta DECIMAL(10,2) DEFAULT 0 CHECK (precioVenta >= 0),
	estado BIT DEFAULT 1,
	marca VARCHAR(150) NOT NULL,
	fechaRegistro DATETIME DEFAULT getdate()
)
go



CREATE TABLE VENTA(
	idVenta INT PRIMARY KEY IDENTITY,
	idUsuario INT REFERENCES USUARIO(idUsuario),
	id_mediodepago INT REFERENCES MEDIOS_PAGO (id_mediodepago),
	nombreCliente VARCHAR(50) NOT NULL,
	montoPago DECIMAL (10,2) NOT NULL CHECK (montoPago >= 0),
	montoCambio DECIMAL (10,2) DEFAULT 0 CHECK (montoCambio >= 0),
	montoTotal DECIMAL (10,2) NOT NULL CHECK (montoTotal >= 0),
	fechaRegistro DATETIME DEFAULT getdate()
)
go


CREATE TABLE DETALLE_VENTA(
	idDetalleVenta INT PRIMARY KEY IDENTITY,
	idVenta INT REFERENCES VENTA(idVenta),
	idProducto INT REFERENCES PRODUCTO(idProducto),
	precioVenta DECIMAL(10,2) NOT NULL CHECK (precioVenta >= 0),
	cantidad INT NOT NULL CHECK (cantidad >= 0),
	subTotal DECIMAL (10,2) NOT NULL CHECK (subTotal >= 0),
	fechaRegistro DATETIME DEFAULT getdate()
)
go

INSERT INTO ROL(descripcion)

VALUES('ADMINISTRADOR')

go


INSERT INTO ROL(descripcion)

VALUES('REABASTECEDOR')

go

INSERT INTO USUARIO(documento, nombreCompleto, correo, clave, idRol, telefono)

VALUES('101010', 'ADMIN', 'admin@gmail.com', '123', 1, '3794111111')

go

SELECT * FROM ROL
go

SELECT * FROM USUARIO
go

/*
INSERT INTO USUARIO(documento, nombreCompleto, correo, clave, idRol, telefono)

VALUES('101010', 'ADMIN', 'admin@gmail.com', '123', 2, '3794111111') */



/* cambios 6/9 */
INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, idRol, telefono)
VALUES ('101011', 'REABASTECEDOR', 'reabastecedor@gmail.com', '123', '2', '3794222222')
go

INSERT INTO ROL (descripcion)
VALUES ('CAJERO')
go

INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, idRol, telefono)
VALUES ('202020', 'CAJERO', 'cajero@gmail.com', '123', '3', '3794343434')
go

INSERT INTO PERMISO (idRol, nombreMenu)
VALUES (1, 'menuUsuario'),
(1, 'menuReabastecedor'),
(1, 'menuVentas'),
(1, 'menuClientes'),
(1, 'menuReportes'),
(1, 'menuAcercaDe'),
(1, 'menuBackup'),
(2, 'menuReabastecedor'),
(2, 'menuBackup'),
(3, 'menuVentas'),
(3, 'menuClientes'),
(3, 'menuReportes'),
(3, 'menuBackup')
go

SELECT * FROM PERMISO
go

--codigo para buscar permisos seg�n un usuario, implementado en el codigo de la aplicaci�n
SELECT p.idRol, p.nombreMenu FROM PERMISO p
inner join ROL r on r.idRol = p.idRol
inner join USUARIO u on u.idRol = r.idRol
WHERE u.idUsuario = 4

/* cambios 8/9 */

CREATE TABLE PROVEEDOR(
	idProveedor INT PRIMARY KEY IDENTITY,
	documento VARCHAR(50),
	razonSocial VARCHAR(50),
	correo VARCHAR(100),
	telefono VARCHAR(50),
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME DEFAULT getdate()

)
go

CREATE TABLE COMPRA(
	idCompra INT PRIMARY KEY IDENTITY,
	idUsuario INT REFERENCES USUARIO (idUsuario),
	idProveedor INT REFERENCES PROVEEDOR(idProveedor),
	tipoDocumento VARCHAR(50),
	numeroDocumento VARCHAR(100),
	montoTotal DECIMAL(10,2),
	fechaRegistro DATETIME DEFAULT getdate()
)
go

CREATE TABLE DETALLE_COMPRA(
	idDetalleCompra INT PRIMARY KEY IDENTITY,
	idCompra INT REFERENCES COMPRA(idCompra),
	idProducto INT REFERENCES PRODUCTO(idProducto),
	precioCompra DECIMAL(10,2) DEFAULT 0,
	precioVenta DECIMAL(10,2) DEFAULT 0,
	cantidad INT,
	montoTotal DECIMAL(10,2),
	fechaRegistro DATETIME DEFAULT getdate()
)
go

INSERT INTO PERMISO (idRol, nombreMenu)
VALUES (1, 'menuCompras'),
(1, 'menuProveedores')
go

INSERT INTO PERMISO (idRol, nombreMenu)
VALUES(2, 'menuCompras'),
(2, 'menuProveedores')
go