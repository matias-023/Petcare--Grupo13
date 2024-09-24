CREATE DATABASE PETCARE

GO

USE PETCARE

GO

CREATE TABLE MEDIOS_PAGO(
	id_mediodepago INT IDENTITY,
	descripcion VARCHAR (50) NOT NULL,
	incremento DECIMAL(5,2) NOT NULL CHECK (incremento >= 0),
	fechaRegistro DATETIME CONSTRAINT DF_MediosPago_fechaRegistro DEFAULT getdate() not null,
	CONSTRAINT PK_MediosPago_id PRIMARY KEY (id_mediodepago),
	CONSTRAINT CK_MedioPago_incremento CHECK (incremento >= 0),
	CONSTRAINT UQ_MedioPago_descripcion UNIQUE (descripcion)
)
go

CREATE TABLE ROL(
	idRol INT IDENTITY,
	descripcion varchar(50) NOT NULL,
	fechaRegistro datetime CONSTRAINT DF_Rol_fechaRegistro DEFAULT getdate() not null,
	CONSTRAINT PK_Rol_id PRIMARY KEY (idRol),
	CONSTRAINT UQ_Rol_descripcion UNIQUE (descripcion)
)
go

CREATE TABLE PERMISO(
	idPermiso int IDENTITY,
	idRol INT not null,
	nombreMenu VARCHAR(100) NOT NULL,
	fechaRegistro DATETIME CONSTRAINT DF_Permiso_fechaRegistro DEFAULT getdate() not null,
	CONSTRAINT PK_Permiso_id PRIMARY KEY (idPermiso),
	CONSTRAINT FK_Permiso_Rol FOREIGN KEY (idRol) REFERENCES Rol(idRol)
)
go


CREATE TABLE CLIENTE(
	idCliente INT IDENTITY,
	documento varchar(50) not null,
	nombreCompleto VARCHAR(150) NOT NULL,
	correo varchar(150) not null,
	telefono varchar(50),
	estado bit,
	fechaRegistro DATETIME CONSTRAINT DF_Cliente_fechaRegistro DEFAULT getdate() not null,
	CONSTRAINT PK_Cliente_id PRIMARY KEY (idCliente),
	CONSTRAINT UQ_Cliente_documento UNIQUE (documento),
	CONSTRAINT UQ_Cliente_correo UNIQUE (correo),
	CONSTRAINT UQ_Cliente_telefono UNIQUE (telefono)
)
go


CREATE TABLE USUARIO(
	idUSuario INT IDENTITY,
	documento VARCHAR(50) NOT NULL,
	nombreCompleto VARCHAR(150) NOT NULL,
	correo VARCHAR(50) NOT NULL,
	clave VARCHAR(50) NOT NULL,
	fechaNacimiento DATE not null,
	sexo VARCHAR(25) not null,
	idRol int REFERENCES ROL(idRol) NOT NULL,
	telefono VARCHAR(25) NOT NULL,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME CONSTRAINT DF_Usuario_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Usuario_id PRIMARY KEY (idUsuario),
	CONSTRAINT UQ_Usuario_documento UNIQUE (documento),
	CONSTRAINT UQ_Usuario_correo UNIQUE (correo),
	CONSTRAINT UQ_Usuario_telefono UNIQUE (telefono),
	CONSTRAINT CK_Usuario_sexo CHECK (sexo IN ('Hombre', 'Mujer')),
	CONSTRAINT CK_Usuario_fechaNacimiento CHECK (datediff(YY, fechaNacimiento, getdate()) >= 18)
)
go

CREATE TABLE CATEGORIA(
	idCategoria INT IDENTITY,
	descripcion VARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME CONSTRAINT DF_Categoria_fechaRegistro DEFAULT getdate()
	CONSTRAINT PK_Categoria_id PRIMARY KEY (idCategoria),
	CONSTRAINT UQ_Categoria_descripcion UNIQUE (descripcion)
)
go

CREATE TABLE MARCA(
	idMarca INT IDENTITY,
	descripcion VARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME CONSTRAINT DF_Marca_fechaRegistro DEFAULT getdate()
	CONSTRAINT PK_Marca_id PRIMARY KEY (idMarca),
	CONSTRAINT UQ_Marca_descripcion UNIQUE (descripcion)
)
go


CREATE TABLE PRODUCTO(
	idProducto INT IDENTITY,
	codigo VARCHAR(50) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	idMarca INT NOT NULL,
	idCategoria INT NOT NULL,
	stock_min INT NOT NULL DEFAULT 0,
	stock INT NOT NULL DEFAULT 0,
	precio DECIMAL(10,2) DEFAULT 0, 
	precioVenta DECIMAL(10,2) DEFAULT 0,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME CONSTRAINT DF_Producto_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Producto_id PRIMARY KEY (idProducto),
	CONSTRAINT UQ_Producto_codigo UNIQUE (codigo),
	CONSTRAINT FK_Producto_marca FOREIGN KEY (idMarca) REFERENCES marca(idMarca),
	CONSTRAINT FK_Producto_categoria FOREIGN KEY (idCategoria) REFERENCES categoria(idCategoria),
	CONSTRAINT CK_Producto_stock_min CHECK (stock_min >= 0),
	CONSTRAINT CK_Producto_stock CHECK (stock >= 0),
	CONSTRAINT CK_Producto_precio CHECK (precio >= 0),
	CONSTRAINT CK_Producto_precioVenta CHECK (precioVenta >= 0)
)
go


CREATE TABLE VENTA(
	idVenta INT IDENTITY,
	idUsuario INT not null,
	id_mediodepago INT not null,
	id_cliente INT not null,
	montoPago DECIMAL (10,2) NOT NULL,
	montoCambio DECIMAL (10,2) DEFAULT 0,
	montoTotal DECIMAL (10,2) NOT NULL,
	fechaRegistro DATETIME CONSTRAINT DF_Venta_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Venta_id PRIMARY KEY (idVenta),
	CONSTRAINT FK_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
	CONSTRAINT FK_Venta_MedioPago FOREIGN KEY (id_mediodepago) REFERENCES medios_pago (id_mediodepago),
	CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES cliente (idCliente),
	CONSTRAINT CK_Venta_montoPago CHECK (montoPago >= 0),
	CONSTRAINT CK_Venta_montoCambio CHECK (montoCambio >= 0),
	CONSTRAINT CK_Venta_montoTotal CHECK (montoTotal >= 0),
)
go


CREATE TABLE DETALLE_VENTA(
	idDetalleVenta INT IDENTITY,
	idVenta INT,
	idProducto INT,
	precioVenta DECIMAL(10,2) NOT NULL,
	cantidad INT NOT NULL,
	subTotal DECIMAL (10,2) NOT NULL,
	fechaRegistro DATETIME CONSTRAINT DF_DetalleVenta_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_DetalleVenta_id PRIMARY KEY (idDetalleVenta),
	CONSTRAINT FK_DetalleVenta_Venta FOREIGN KEY (idVenta) REFERENCES VENTA(idVenta),
	CONSTRAINT FK_DetalleVenta_Producto FOREIGN KEY (idProducto) REFERENCES PRODUCTO(idProducto),
	CONSTRAINT CK_DetalleVenta_precioVenta CHECK (precioVenta >= 0),
	CONSTRAINT CK_DetalleVenta_cantidad CHECK (cantidad > 0),
	CONSTRAINT CK_DetalleVenta_subTotal CHECK (subTotal >= 0)
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

INSERT INTO USUARIO(documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)

VALUES('10101010', 'ADMIN', 'admin@gmail.com', '123', '2004-05-10', 'Hombre', 1, '3794111111')

go

/* cambios 6/9 */
INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)
VALUES ('1010111', 'REABASTECEDOR', 'reabastecedor@gmail.com', '123', '2004-05-10', 'Hombre', 2, '3794222222')
go

INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)
VALUES ('20202020', 'CAJERO', 'cajero@gmail.com', '123','2000-05-10', 'Mujer', 3, '3794343434')
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
	idProveedor INT IDENTITY,
	documento VARCHAR(50) not null,
	razonSocial VARCHAR(100) not null,
	correo VARCHAR(100),
	telefono VARCHAR(50) not null,
	estado BIT DEFAULT 1,
	fechaRegistro DATETIME CONSTRAINT DF_Proveedor_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Proveedor_id PRIMARY KEY (idProveedor),
	CONSTRAINT UQ_Proveedor_documento UNIQUE (documento),
	CONSTRAINT UQ_Proveedor_correo UNIQUE (correo),
	CONSTRAINT UQ_Proveedor_telefono UNIQUE (telefono)
)
go

CREATE TABLE COMPRA(
	idCompra INT IDENTITY,
	idUsuario INT,
	idProveedor INT,
	tipoDocumento VARCHAR(50),
	numeroDocumento VARCHAR(100),
	montoTotal DECIMAL(10,2),
	fechaRegistro DATETIME CONSTRAINT DF_Compra_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Compra_id PRIMARY KEY (idCompra),
	CONSTRAINT FK_Compra_Usuario FOREIGN KEY (idUsuario) REFERENCES USUARIO (idUsuario),
	CONSTRAINT FK_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES PROVEEDOR(idProveedor),
	CONSTRAINT CK_Compra_montoTotal CHECK (montoTotal >= 0)
)
go

CREATE TABLE DETALLE_COMPRA(
	idDetalleCompra INT IDENTITY,
	idCompra INT,
	idProducto INT,
	precioCompra DECIMAL(10,2) DEFAULT 0,
	precioVenta DECIMAL(10,2) DEFAULT 0,
	cantidad INT,
	montoTotal DECIMAL(10,2),
	fechaRegistro DATETIME CONSTRAINT DF_DetalleCompra_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_DetalleCompra_id PRIMARY KEY (idDetalleCompra),
	CONSTRAINT FK_DetalleCompra_Compra FOREIGN KEY (idCompra) REFERENCES COMPRA(idCompra),
	CONSTRAINT FK_DetalleCompra_Producto FOREIGN KEY (idProducto) REFERENCES PRODUCTO(idProducto),
	CONSTRAINT CK_DetalleCompra_montoTotal CHECK (montoTotal >= 0),
	CONSTRAINT CK_DetalleCompra_cantidad CHECK (cantidad > 0)
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

SELECT * FROM PERMISO
/* cambios 9/9 */

select U.idUsuario, U.documento, U.nombreCompleto, U.correo, U.clave, U.estado, U.telefono, R.idRol, R.descripcion from USUARIO u
inner join ROL r on r.idRol = U.idRol
go

CREATE PROC SP_REGISTRARUSUARIO(
@documento varchar(50),
@nombreCompleto varchar(150),
@correo varchar(50),
@clave varchar(50),
@fechaNacimiento date,
@sexo varchar(25),
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
		insert into USUARIO (documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, telefono, idRol, estado)
		VALUES (@documento, @nombreCompleto, @correo, @clave, @fechaNacimiento, @sexo, @telefono, @idRol, @estado)

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
@nombreCompleto varchar(150),
@correo varchar(50),
@clave varchar(50),
@fechaNacimiento date,
@sexo varchar(25),
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
		fechaNacimiento = @fechaNacimiento,
		sexo = @sexo,
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
ADD CONSTRAINT CK_Usuario_Dni
CHECK (documento LIKE '%[0-9]%' AND documento NOT LIKE '%[^0-9]%' AND LEN(documento) >= 6)
go

--restriccion para nombres completos.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Nombre
CHECK (nombreCompleto LIKE '%[A-Za-zÑñÁÉÍÓÚáéíóú ]%' and nombreCompleto NOT LIKE '%[^A-Za-zÑñÁÉÍÓÚáéíóú ]%')
go

--restriccion para correos validos.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Correo
CHECK (
    correo LIKE '%_@__%.__%' 
    AND correo NOT LIKE '%[^A-Za-z0-9@._-]%' 
    AND CHARINDEX(' ', correo) = 0
);

--restriccion para numeros de telefono validos
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Telefono
CHECK (telefono LIKE '%[0-9]%' AND telefono NOT LIKE '%[^0-9]%' AND LEN(telefono) >= 8)
go

SELECT * FROM USUARIO