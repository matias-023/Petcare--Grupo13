﻿/**
DROP DATABASE PETCARE
*/

CREATE DATABASE PETCARE

GO

USE PETCARE

GO

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
	CONSTRAINT CK_Usuario_fechaNacimiento CHECK ((datediff(YY, fechaNacimiento, getdate()) >= 18) AND (datediff(YY, fechaNacimiento, getdate()) <= 100))
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
	nombre VARCHAR(150) NOT NULL,
	idMarca INT NOT NULL,
	idCategoria INT NOT NULL,
	stock_min INT NOT NULL,
	stock INT NOT NULL,
	precio DECIMAL(10,2) NOT NULL, 
	precioVenta DECIMAL(10,2) NOT NULL,
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
	tipoDocumento VARCHAR(50),
	numeroDocumento varchar(500),
	documentoCliente varchar(500),
	nombreCliente varchar(500),
	montoPago DECIMAL (10,2) NOT NULL,
	montoCambio DECIMAL (10,2) DEFAULT 0,
	montoTotal DECIMAL (10,2) NOT NULL,
	fechaRegistro DATETIME CONSTRAINT DF_Venta_fechaRegistro DEFAULT getdate(),
	CONSTRAINT PK_Venta_id PRIMARY KEY (idVenta),
	CONSTRAINT FK_Venta_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario),
	CONSTRAINT CK_Venta_montoPago CHECK (montoPago >= montoTotal),
	CONSTRAINT CK_Venta_montoCambio CHECK (montoCambio >= 0),
	CONSTRAINT CK_Venta_montoTotal CHECK (montoTotal >= 0),
	CONSTRAINT CK_Venta_tipoDocumento CHECK (tipoDocumento in ('Boleta', 'Factura')),
	CONSTRAINT UQ_venta_numeroDocumento UNIQUE (numeroDocumento)
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

--Se insertan los distintos roles
INSERT INTO ROL(descripcion)
VALUES('ADMINISTRADOR')
go
INSERT INTO ROL(descripcion)
VALUES('REABASTECEDOR')
go
INSERT INTO ROL (descripcion)
VALUES ('CAJERO')
go

--se insertan los distintos usuarios
INSERT INTO USUARIO(documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)
VALUES('10101010', 'ADMIN', 'admin@gmail.com', '123', '2004-05-10', 'Hombre', 1, '3794111111')
go
INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)
VALUES ('10101111', 'REABASTECEDOR', 'reabastecedor@gmail.com', '123', '2004-05-10', 'Hombre', 2, '3794222222')
go
INSERT INTO USUARIO (documento, nombreCompleto, correo, clave, fechaNacimiento, sexo, idRol, telefono)
VALUES ('20202020', 'CAJERO', 'cajero@gmail.com', '123','2000-05-10', 'Mujer', 3, '3794343434')
go

INSERT INTO PERMISO (idRol, nombreMenu)
VALUES (1, 'menuUsuario'),
--(1, 'menuReabastecedor'),
--(1, 'menuVentas'),
--(1, 'menuClientes'),
(1, 'menuReportes'),
(1, 'menuAcercaDe'),
(1, 'menuBackup'),
(2, 'menuReabastecedor'),
(2, 'menuAcercaDe'),
(3, 'menuVentas'),
(3, 'menuClientes'),
(3, 'menuReportes'),
(3, 'menuAcercaDe')
go


--codigo para buscar permisos seg�n un usuario, implementado en el codigo de la aplicaci�n
SELECT p.idRol, p.nombreMenu FROM PERMISO p
inner join ROL r on r.idRol = p.idRol
inner join USUARIO u on u.idRol = r.idRol
WHERE u.idUsuario = 4

--codigo para listar usuarios, implementado dentro del codigo de la aplicacion
select U.idUsuario, U.documento, U.nombreCompleto, U.correo, U.clave, U.estado, U.telefono, R.idRol, R.descripcion from USUARIO u
inner join ROL r on r.idRol = U.idRol
go

--Proc Almacenado para registrar usuarios
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

		set @idUsuarioResultado = SCOPE_IDENTITY() --Almacena el ultimo Id registrado
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

--Proc Almacenado para editar usuarios	
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

--restricción para numeros de documento de usuarios.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Dni
CHECK (documento LIKE '%[0-9]%' AND documento NOT LIKE '%[^0-9]%' AND LEN(documento) >= 7)
go

--restriccion para nombres completos de usuarios.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Nombre
CHECK (nombreCompleto LIKE '%[A-Za-zÑñÁÉÍÓÚáéíóú ]%' and nombreCompleto NOT LIKE '%[^A-Za-zÑñÁÉÍÓÚáéíóú ]%')
go

--restriccion para correos validos de usuarios.
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Correo
CHECK (
    correo LIKE '%_@__%.__%' 
    AND correo NOT LIKE '%[^A-Za-z0-9@._-]%' 
    AND CHARINDEX(' ', correo) = 0
);

--restriccion para numeros de telefono validos de usuarios
ALTER TABLE USUARIO
ADD CONSTRAINT CK_Usuario_Telefono
CHECK (telefono LIKE '%[0-9]%' AND telefono NOT LIKE '%[^0-9]%' AND LEN(telefono) >= 8)
go

--Procedimiento almacenado para registrar categorias de productos.
CREATE PROC SP_REGISTRARCATEGORIA(
@descripcion varchar(100),
@estado bit,
@resultado int output,
@mensaje varchar(150) output
)
as
begin
	set @resultado = 0
	set @mensaje = ''

	if not exists(select * from CATEGORIA where descripcion = @descripcion)
	begin 
		insert into CATEGORIA (descripcion, estado)
		VALUES (@descripcion, @estado)
		set @resultado = SCOPE_IDENTITY() --Almacena el ultimo Id registrado
		set @mensaje = 'Categoría registrada con éxito!'
	end 
	else 
		set @mensaje = 'Ya existe una categoría registrada con esa descripción.'
end
go

--Procedimiento almacenado para editar categorias de productos.
CREATE PROC SP_EDITARCATEGORIA(
@idCategoria int,
@descripcion varchar(100),
@estado bit,
@respuesta int output,
@mensaje varchar(150) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists (select * from CATEGORIA
	WHERE descripcion = @descripcion and idCategoria != @idCategoria)
	begin 
		update CATEGORIA set
		descripcion = @descripcion,
		estado = @estado
		WHERE idCategoria = @idCategoria

		set @respuesta = 1
		set @mensaje = 'Categoría: ' + @descripcion + ', modificada con éxito!'

	end 
	else 
		set @mensaje = 'Ya existe una categoría registrada con esa descripción.'
end
go

--restriccion para descripciones de categoría validos.
ALTER TABLE CATEGORIA
ADD CONSTRAINT CK_Categoria_Descripcion
CHECK (descripcion LIKE '%[A-Za-zÑñÁÉÍÓÚáéíóú ]%' and descripcion NOT LIKE '%[^A-Za-zÑñÁÉÍÓÚáéíóú ]%')
go

--Procedimiento almacenado para registrar marcas de productos.
CREATE PROC SP_REGISTRARMARCA(
@descripcion varchar(100),
@estado bit,
@resultado int output,
@mensaje varchar(150) output
)
as
begin
	set @resultado = 0
	set @mensaje = ''

	if not exists(select * from MARCA where descripcion = @descripcion)
	begin 
		insert into MARCA (descripcion, estado)
		VALUES (@descripcion, @estado)
		set @resultado = SCOPE_IDENTITY() --Almacena el ultimo Id registrado
		set @mensaje = 'Marca registrada con éxito!'
	end 
	else 
		set @mensaje = 'Ya existe una Marca registrada con esa descripción.'
end
go

--Procedimiento almacenado para editar marcas de productos.
CREATE PROC SP_EDITARMARCA(
@idMarca int,
@descripcion varchar(100),
@estado bit,
@respuesta int output,
@mensaje varchar(150) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists (select * from MARCA
	WHERE descripcion = @descripcion and idMarca != @idMarca)
	begin 
		update MARCA set
		descripcion = @descripcion,
		estado = @estado
		WHERE idMarca = @idMarca

		set @respuesta = 1
		set @mensaje = 'Marca: ' + @descripcion + ', modificada con éxito!'

	end 
	else 
		set @mensaje = 'Ya existe una marca registrada con esa descripción.'
end
go

--Procedimiento almacenado para registrar clientes.
CREATE PROC sp_RegistrarCliente(
@documento varchar(50),
@nombreCompleto varchar(150),
@correo varchar(150),
@telefono varchar(50),
@estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 0
	DECLARE @IDPERSONA INT
	if not exists(select * from CLIENTE where documento = @documento or correo = @correo or telefono = @telefono)
	begin
		insert into CLIENTE (documento, nombreCompleto, correo, telefono, estado) 
		VALUES(@documento, @nombreCompleto, @correo, @telefono, @estado)

		set @Resultado = SCOPE_IDENTITY()
		set @Mensaje = 'Cliente registrado con éxito!'
	end
	else
	begin
		if exists(select * from CLIENTE where documento = @documento)
			set @Mensaje = 'Ya existe un cliente registrado con ese documento.'
		else if exists(select * from CLIENTE where correo = @correo)
			set @Mensaje = 'Ya existe un cliente registrado con ese correo.'
		else if exists(select * from CLIENTE where telefono = @telefono)
			set @Mensaje = 'Ya existe un cliente registrado con ese teléfono.'
		end
end
go

--Procedimiento almacenado para modificar clientes.
create PROC sp_ModificarCliente(
@idCliente int,
@documento varchar(50),
@nombreCompleto varchar(150),
@correo varchar(150),
@telefono varchar(50),
@estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
	SET @Resultado = 0
	DECLARE @IDPERSONA INT
	if not exists(select * from CLIENTE
	WHERE (documento = @documento or telefono = @telefono or correo = @correo) and idCliente != @idCliente)
	begin
		UPDATE CLIENTE SET
		documento = @documento,
		nombreCompleto = @nombreCompleto,
		correo = @correo,
		telefono = @telefono,
		estado = @estado
		WHERE idCliente = @idCliente

		set @resultado = 1;
		set @mensaje = 'Cliente: ' + @nombreCompleto + ', modificado con éxito!'
	end
	else
	begin
		if exists(select * from CLIENTE where documento = @documento and idCliente != @idCliente)
			set @mensaje = 'Ya existe un cliente registrado con ese documento.'
		else if exists(select * from CLIENTE where correo = @correo and idCliente != @idCliente)
			set @mensaje = 'Ya existe un cliente registrado con ese correo.'
		else if exists(select * from CLIENTE where telefono = @telefono and idCliente != @idCliente)
			set @mensaje = 'Ya existe un cliente registrado con ese teléfono.'
		end
end
go

--restricción para numeros de documento de clientes.
ALTER TABLE CLIENTE
ADD CONSTRAINT CK_Cliente_Dni
CHECK (documento LIKE '%[0-9]%' AND documento NOT LIKE '%[^0-9]%' AND LEN(documento) >= 7)
go

--restriccion para nombres completos de clientes.
ALTER TABLE CLIENTE
ADD CONSTRAINT CK_Cliente_Nombre
CHECK (nombreCompleto LIKE '%[A-Za-zÑñÁÉÍÓÚáéíóú ]%' and nombreCompleto NOT LIKE '%[^A-Za-zÑñÁÉÍÓÚáéíóú ]%')
go

--restriccion para correos validos de clientes.
ALTER TABLE CLIENTE
ADD CONSTRAINT CK_Cliente_Correo
CHECK (
    correo LIKE '%_@__%.__%' 
    AND correo NOT LIKE '%[^A-Za-z0-9@._-]%' 
    AND CHARINDEX(' ', correo) = 0
);
go
--restriccion para numeros de telefono validos de clientes.
ALTER TABLE CLIENTE
ADD CONSTRAINT CK_Cliente_Telefono
CHECK (telefono LIKE '%[0-9]%' AND telefono NOT LIKE '%[^0-9]%' AND LEN(telefono) >= 8)
go

--Procedimiento almacenado para registrar productos.
CREATE PROC SP_REGISTRARPRODUCTO(
@codigo varchar(50),
@nombre varchar(150),
@idMarca int,
@idCategoria int,
@stock_min int,
@stock int,
@precio decimal(10,2),
@precioVenta decimal(10,2),
@estado bit,
@idProductoResultado int output,
@mensaje varchar(150) output
)
as
begin
	set @idProductoResultado = 0
	set @mensaje = ''

	if not exists(select * from PRODUCTO where codigo = @codigo)
	begin 
		insert into PRODUCTO (codigo, nombre, idMarca, idCategoria, stock_min, stock, precio, precioVenta, estado)
		VALUES (@codigo, @nombre, @idMarca, @idCategoria, @stock_min, @stock, @precio, @precioVenta, @estado)

		set @idProductoResultado = SCOPE_IDENTITY() --Almacena el ultimo Id registrado
		set @mensaje = 'Producto registrado con éxito!'

	end 
	else 
		set @mensaje = 'Ya existe un producto registrado con ese código.'
end
go

--Procedimiento almacenado para modificar productos.
CREATE PROC SP_EDITARPRODUCTO(
@idProducto int,
@codigo varchar(50),
@nombre varchar(150),
@idMarca int,
@idCategoria int,
@stock_min int,
@stock int,
@precio decimal(10,2),
@precioVenta decimal(10,2),
@estado bit,
@respuesta bit output,
@mensaje varchar(150) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from PRODUCTO
	WHERE (codigo = @codigo) and idProducto != @idProducto)
	begin 
		update PRODUCTO set
		codigo = @codigo,
		nombre = @nombre,
		idMarca = @idMarca,
		idCategoria = @idCategoria,
		stock_min = @stock_min,
		stock = @stock,
		precio = @precio,
		precioVenta = @precioVenta,
		estado = @estado
		WHERE idProducto = @idProducto

		set @respuesta = 1
		set @mensaje = 'Producto modificado con éxito!'

	end 
	else 
		set @mensaje = 'Ya existe un producto registrado con ese código.'
end
go

--Restriccion para códigos de productos validos.
ALTER TABLE PRODUCTO
ADD CONSTRAINT CK_Producto_Codigo
CHECK (codigo LIKE '%[0-9]%' AND codigo NOT LIKE '%[^0-9]%')
go

--Procesos para registrar una venta
--Se crea el Datatable del detalle de ventas.
CREATE TYPE [dbo].[EDetalle_Venta] AS TABLE(
	[idProducto] int null,
	[precioVenta] decimal (18,2) NULL,
	[cantidad] int NULL,
	[subTotal] decimal (18,2) NULL
)

GO

--Proc almacenado para registrar ventas.
CREATE PROCEDURE usp_RegistrarVenta(
	@idUsuario int,
	@tipoDocumento varchar (500),
	@numeroDocumento varchar(500),
	@documentoCliente varchar(500),
	@nombreCliente varchar(500),
	@montoPago decimal (10,2),
	@montoCambio decimal (10,2),
	@montoTotal decimal (10,2),
	@DetalleVenta [EDetalle_Venta] READONLY,
	@Resultado bit output,
	@Mensaje varchar (500) output
) 
as 
begin
	begin try
		declare @idVenta int = 0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into VENTA(idUsuario, tipoDocumento, numeroDocumento, documentoCliente, nombreCliente, montoPago, montoCambio, montoTotal)
		VALUES(@idUsuario, @tipoDocumento, @numeroDocumento, @documentoCliente, @nombreCliente, @montoPago, @montoCambio, @montoTotal)

		SET @idVenta = SCOPE_IDENTITY()

		INSERT INTO DETALLE_VENTA (idVenta, idProducto, precioVenta, cantidad, subTotal)
		SELECT @idVenta, idProducto, precioVenta, cantidad, subTotal from @DetalleVenta

		COMMIT TRANSACTION registro

	END TRY 
	BEGIN CATCH
		SET @Resultado = 0
		SET @Mensaje = ERROR_MESSAGE()
		ROLLBACK TRANSACTION registro
	END CATCH
END
go

--inserciones a la tabla Marca
INSERT INTO MARCA (descripcion)
VALUES 
('Purina'),
('Whiskas'),
('Pro Plan'),
('Pedigree'),
('Royal Canin'),
('Eukanuba'),
('Hill''s Science Diet'),
('NutraGold'),
('VitalCan'),
('Dog Chow'),
('Cat Chow'),
('Kongo'),
('Agility Gold'),
('Excellent'),
('Old Prince'),
('Balance'),
('Raza'),
('Vitality'),
('Felix'),
('Sergeant''s')
go

--inserciones a la tabla Categoria
INSERT INTO CATEGORIA (descripcion, estado)
VALUES 
('Alimentos', 1),
('Accesorios', 1),
('Juguetes', 1),
('Ropa para Mascotas', 1),
('Medicamentos', 1),
('Camas y Muebles', 1),
('Transporte', 1),
('Higiene y Cuidado', 1),
('Collares y Correas', 1),
('Jaulas y Terrarios', 1),
('Filtros y Purificadores', 1),
('Arena y Lechos', 1);
GO

--inserciones a la tabla Producto
INSERT INTO PRODUCTO (codigo, nombre, idMarca, idCategoria, stock_min, stock, precio, precioVenta, estado)
VALUES
('1000', 'Purina Dog Chow Adultos 20kg', 1, 1, 10, 50, 3500.00, 4500.00, 1),
('1001', 'Whiskas Alimento Gatos 10kg', 2, 1, 8, 40, 2500.00, 3200.00, 1),
('1002', 'Pro Plan OptiStart Cachorros 15kg', 3, 1, 5, 30, 4000.00, 5500.00, 1),
('1003', 'Collar Cuero Ajustable Mediano', 4, 9, 3, 15, 150.00, 250.00, 1),
('1004', 'Arena Sanitaria para Gatos 10kg', 5, 12, 4, 20, 500.00, 750.00, 1),
('1005', 'Juguete Mordedor para Perros', 6, 3, 5, 30, 100.00, 150.00, 1),
('1006', 'Cama Almohadón Grande', 7, 6, 2, 10, 1200.00, 1800.00, 1),
('1007', 'Shampoo para Perros y Gatos 500ml', 8, 8, 5, 25, 400.00, 600.00, 1),
('1008', 'Transportadora Plástico Mediana', 9, 7, 3, 80, 2200.00, 3500.00, 1),
('1009', 'Eukanuba Adultos Raza Mediana 15kg', 10, 1, 6, 25, 4300.00, 5900.00, 1),
('1010', 'Royal Canin Gatos Persianos 10kg', 11, 1, 4, 20, 4100.00, 5200.00, 1),
('1011', 'Collar con Correa para Perros', 4, 9, 2, 12, 180.00, 350.00, 1),
('1012', 'Rascador para Gatos Mediano', 5, 2, 2, 7, 750.00, 1200.00, 1),
('1013', 'Pelota de Goma para Perros', 6, 3, 5, 40, 80.00, 120.00, 1),
('1014', 'Cama Cueva para Gatos', 7, 6, 3, 12, 1300.00, 1950.00, 1),
('1015', 'Cepillo para Perros y Gatos', 8, 8, 6, 25, 250.00, 400.00, 1),
('1016', 'Transportadora Plástico Grande', 9, 7, 2, 8, 2800.00, 4300.00, 1),
('1017', 'Nutrience Original Perros 20kg', 12, 1, 10, 35, 3300.00, 4500.00, 1),
('1018', 'Equilibrio Adultos Razas Pequeñas 15kg', 13, 1, 5, 25, 3600.00, 4900.00, 1),
('1019', 'Arena Silica para Gatos 10kg', 5, 12, 4, 20, 700.00, 1000.00, 1),
('1020', 'Juguete Peluche para Gatos', 6, 3, 5, 50, 90.00, 150.00, 1),
('1021', 'Cama Ortopédica para Perros', 7, 6, 2, 6, 2200.00, 3300.00, 1),
('1022', 'Shampoo Hipoalergénico 500ml', 8, 8, 5, 20, 500.00, 750.00, 1),
('1023', 'Caja Transportadora de Metal', 9, 7, 2, 10, 2900.00, 4600.00, 1)
go

INSERT INTO CLIENTE (documento, nombreCompleto, correo, telefono, estado) VALUES
('40404040', 'Maximiliano', 'maxi@gmail.com', '3794888877', 1),
('12345678', 'Juan Pérez', 'juan.perez@gmail.com', '3112345678', 1),
('87654321', 'Ana Gómez', 'ana.gomez@hotmail.com', '3123456789', 1),
('23456789', 'Carlos Ruiz', 'carlos.ruiz@yahoo.com', '3134567890', 1),
('34567890', 'María López', 'maria.lopez@outlook.com', '3145678901', 1),
('45678901', 'Laura Martínez', 'laura.martinez@gmail.com', '3156789012', 1),
('56789012', 'Pedro Sánchez', 'pedro.sanchez@gmail.com', '3167890123', 1),
('67890123', 'Sofía Hernández', 'sofia.hernandez@yahoo.com', '3178901234', 1),
('78901234', 'Andrés Torres', 'andres.torres@outlook.com', '3189012345', 1),
('89012345', 'Lucía Morales', 'lucia.morales@hotmail.com', '3190123456', 1),
('90123456', 'Diego Castillo', 'diego.castillo@gmail.com', '3201234567', 1)
go

--Proc almacenado para obtener el reporte de las ventas.
CREATE PROC sp_ReporteVentas(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10),
@rol INT,
@idUsuario INT
)
AS
BEGIN
SET DATEFORMAT dmy;
SELECT 
v.idVenta,
CONVERT (CHAR (10), v.fechaRegistro,103)[fechaRegistro],
CONVERT(CHAR(8), v.fechaRegistro, 108) AS [horaRegistro],
v.tipoDocumento,
v.numeroDocumento,
u.documento[documentoUsuario],
u.nombreCompleto[usuarioRegistro],
v.documentoCliente,
v.nombreCliente,
v.montoTotal
FROM VENTA v
INNER JOIN USUARIO u on u.idUSuario = v.idUsuario

WHERE CONVERT(date,v.fechaRegistro) BETWEEN @fechainicio AND @fechafin
AND (@rol = 1 OR v.idUsuario = @idUsuario)

END 
GO

--Ejemplo
EXEC sp_ReporteVentas '26/10/2024', '30/10/2024', 1, 1
go

--Proc almacenado para ver los productos más vendidos.
CREATE PROC SP_ReporteProdMasVendidos(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10)
)
AS
BEGIN
SET DATEFORMAT dmy;

select p.codigo [Código], p.nombre [Nombre], c.descripcion[Categoria], m.descripcion[Marca], p.precioVenta[Precio de Venta],
sum(dv.cantidad) [Cant. Vendida], (p.precioVenta * sum(dv.cantidad)) [Total] from DETALLE_VENTA dv
inner join PRODUCTO p on dv.idProducto = p.idProducto
inner join CATEGORIA c on p.idCategoria = c.idCategoria
inner join MARCA m on p.idMarca = m.idMarca
WHERE CONVERT(date,dv.fechaRegistro) BETWEEN @fechainicio AND @fechafin
group by p.codigo, p.nombre, c.descripcion, m.descripcion, p.precioVenta
order by sum(dv.cantidad) DESC
END
go

EXEC SP_ReporteProdMasVendidos '30/10/2024', '4/11/2024'
go

--Proc almacenado para ver las marcas más vendidas
CREATE PROC SP_ReporteMarcasMasVendidas(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10)
)
AS
BEGIN
SET DATEFORMAT dmy;
select m.descripcion [Nombre Marca], sum(dv.cantidad) [Cant. Vendida] from detalle_venta dv
inner join PRODUCTO p on dv.idProducto = p.idProducto
inner join MARCA m on p.idMarca = m.idMarca
WHERE CONVERT(date,dv.fechaRegistro) BETWEEN @fechainicio AND @fechafin
group by m.descripcion
order by [Cant. Vendida] DESC
END
go

EXEC SP_ReporteMarcasMasVendidas '30/10/2024', '4/11/2024'
go

--Proc almacenado para ver las categorias más vendidas
CREATE PROC SP_ReporteCatMasVendidas(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10)
)
AS
BEGIN
SET DATEFORMAT dmy;
select c.descripcion [Nombre Categoria], sum(dv.cantidad) [Cant. Vendida] from detalle_venta dv
inner join PRODUCTO p on dv.idProducto = p.idProducto
inner join CATEGORIA c on p.idCategoria = c.idCategoria
WHERE CONVERT(date,dv.fechaRegistro) BETWEEN @fechainicio AND @fechafin
group by c.descripcion
order by [Cant. Vendida] DESC
END
go

EXEC SP_ReporteCatMasVendidas '30/10/2024', '4/11/2024'
go

--Proc almacenado para ver los cajeros con más ventas.
CREATE PROC SP_ReporteCajeros(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10)
)
AS
BEGIN
SET DATEFORMAT dmy;
select u.documento [Documento], u.nombreCompleto [Nombre Completo], count(*) [Cant. de Ventas], sum(dv.cantidad) [Productos Vendidos] from VENTA v
inner join USUARIO u on v.idUsuario = u.idUSuario
inner join DETALLE_VENTA dv on dv.idVenta = v.idVenta
WHERE CONVERT(date,dv.fechaRegistro) BETWEEN @fechainicio AND @fechafin
group by v.idUsuario, u.documento, u.nombreCompleto
order by [Cant. de Ventas] DESC
END 
GO

EXEC SP_ReporteCajeros '30/10/2024', '4/11/2024'
go

--Procedimiento almacenado para ver los productos que no se han vendido.
CREATE PROC SP_ReporteProductosSinVentas(
@fechainicio VARCHAR(10),
@fechafin VARCHAR (10)
)
AS
BEGIN
SET DATEFORMAT dmy;
select p.codigo [Código], p.nombre [Nombre], c.descripcion[Categoria], m.descripcion[Marca], p.precioVenta[Precio de Venta] from producto p
inner join CATEGORIA c on p.idCategoria = c.idCategoria
inner join MARCA m on p.idMarca = m.idMarca
where
	not exists (
		SELECT 1 FROM DETALLE_VENTA dv
		WHERE dv.idProducto = p.idProducto AND CONVERT(date,dv.fechaRegistro) BETWEEN @fechainicio AND @fechafin
		)
END 
GO