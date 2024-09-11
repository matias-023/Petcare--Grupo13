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

INSERT INTO ROL (descripcion)
VALUES ('CAJERO')
go

INSERT INTO USUARIO(documento, nombreCompleto, correo, clave, idRol, telefono)

VALUES('10101010', 'ADMIN', 'admin@gmail.com', '123', 1, '3794111111')

go


/* cambios 6/9 */
INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, idRol, telefono)
VALUES ('1010111', 'REABASTECEDOR', 'reabastecedor@gmail.com', '123', '2', '3794222222')
go

INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, idRol, telefono)
VALUES ('20202020', 'CAJERO', 'cajero@gmail.com', '123', '3', '3794343434')
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

/* cambios 9/9 */

select U.idUsuario, U.documento, U.nombreCompleto, U.correo, U.clave, U.estado, U.telefono, R.idRol, R.descripcion from USUARIO u
inner join ROL r on r.idRol = U.idRol
go

CREATE PROC SP_REGISTRARUSUARIO(
@documento varchar(50),
@nombreCompleto varchar(50),
@correo varchar(50),
@clave varchar(50),
@telefono varchar(25),
@idRol int,
@estado bit,
@idUsuarioResultado int output,
@mensaje varchar(150) output
)
as
begin
	set @idUsuarioResultado = 0
	set @mensaje = ''

	if not exists(select * from USUARIO where documento = @documento or correo = @correo or telefono = @telefono)
	begin 
		insert into USUARIO (documento, nombreCompleto, correo, clave, telefono, idRol, estado)
		VALUES (@documento, @nombreCompleto, @correo, @clave, @telefono, @idRol, @estado)

		set @idUsuarioResultado = SCOPE_IDENTITY()
		set @mensaje = 'Usuario registrado con éxito!'

	end 
	else 
		begin
		if exists(select * from USUARIO where documento = @documento)
			set @mensaje = 'Ya existe un usuario registrado con ese documento.'
		else if exists(select * from USUARIO where correo = @correo)
			set @mensaje = 'Ya existe un usuario registrado con ese correo.'
		else if exists(select * from USUARIO where telefono = @telefono)
			set @mensaje = 'Ya existe un usuario registrado con ese teléfono.'
		end
end
go


/*cambios 11/9 */

CREATE PROC SP_EDITARUSUARIO(
@idUsuario int,
@documento varchar(50),
@nombreCompleto varchar(50),
@correo varchar(50),
@clave varchar(50),
@telefono varchar(25),
@idRol int,
@estado bit,
@respuesta bit output,
@mensaje varchar(150) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from USUARIO
	WHERE (documento = @documento or telefono = @telefono or correo = @correo) and idUSuario != @idUsuario)
	begin 
		update USUARIO set
		documento = @documento,
		nombreCompleto = @nombreCompleto,
		correo = @correo,
		clave = @clave,
		telefono = @telefono,
		idRol = @idRol,
		estado = @estado
		WHERE idUSuario = @idUsuario

		set @respuesta = 1
		set @mensaje = 'Usuario: ' + @nombreCompleto + ', modificado con éxito!'

	end 
	else 
		begin
		if exists(select * from USUARIO where documento = @documento and idUSuario != @idUsuario)
			set @mensaje = 'Ya existe un usuario registrado con ese documento.'
		else if exists(select * from USUARIO where correo = @correo and idUSuario != @idUsuario)
			set @mensaje = 'Ya existe un usuario registrado con ese correo.'
		else if exists(select * from USUARIO where telefono = @telefono and idUSuario != @idUsuario)
			set @mensaje = 'Ya existe un usuario registrado con ese teléfono.'
		end
end
go

select * from usuario
go

--restricción para numeros de documento.

ALTER TABLE USUARIO
ADD CONSTRAINT CK_DniValido
CHECK (documento LIKE '%[0-9]%' AND documento NOT LIKE '%[^0-9]%' AND LEN(documento) >= 6)
go

--restriccion para nombres completos.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_NombreValido
CHECK (nombreCompleto LIKE '%[A-Za-zÑñÁÉÍÓÚáéíóú ]%' and nombreCompleto NOT LIKE '%[^A-Za-zÑñÁÉÍÓÚáéíóú ]%')
go

--restriccion para correos validos.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_CorreoValido
CHECK (
    correo LIKE '%_@__%.__%' 
    AND correo NOT LIKE '%[^A-Za-z0-9@._-]%' 
    AND CHARINDEX(' ', correo) = 0
);

--restriccion para numeros de telefono validos
ALTER TABLE USUARIO
ADD CONSTRAINT CK_TelefonoValido
CHECK (telefono LIKE '%[0-9]%' AND telefono NOT LIKE '%[^0-9]%' AND LEN(telefono) >= 8)
go

SELECT * FROM USUARIO