--create database DBSistemaVenta;
--use DBSistemaVenta;

create table ROL (
	idRol int primary key identity,
	descripcion nvarchar(60),
	fechaRegistro datetime default getdate(),
);

create table PERMISO (
	idPermiso int primary key identity,
	idRol int references ROL(idRol),
	nombreMenu nvarchar(100),
	fechaRegistro datetime default getdate(),
);

create table PROVEEDOR (
	idProveedor int primary key identity,
	documento nvarchar(50),
	razonSocial nvarchar(50),
	correo nvarchar(50),
	telefono nvarchar(50),
	estado bit not null default 0,
	fechaRegistro datetime default getdate(),
);

create table CLIENTE (
	idCliente int primary key identity,
	documento nvarchar(50),
	nombreCompleto nvarchar(50),
	correo nvarchar(50),
	telefono nvarchar(50),
	estado bit not null default 0,
	fechaRegistro datetime default getdate(),
);

create table USUARIO (
	idUsuario int primary key identity,
	documento nvarchar(50),
	nombreCompleto nvarchar(50),
	correo nvarchar(50),
	clave nvarchar(50),
	idRol int references ROL(idRol),
	estado bit not null default 0,
	fechaRegistro datetime default getdate(),
);

create table CATEGORIA (
	idCategoria int primary key identity,
	descripcion nvarchar(100),
	estado bit not null default 0,
	fechaRegistro datetime default getdate(),
);

create table PRODUCTO (
	idProducto int primary key identity,
	codigo nvarchar(50),
	nombre nvarchar(50),
	descripcion nvarchar(50),
	idCategoria int references CATEGORIA(idCategoria),
	stock int not null default 0,
	precioCompra decimal(10,2) default 0,
	precioVenta decimal(10,2) default 0,
	estado bit not null default 0,
	fechaRegistro datetime default getdate(),
);

create table COMPRA (
	idCompra int primary key identity,
	idUsuario int references USUARIO(idUsuario),
	idProveedor int references PROVEEDOR(idProveedor),
	tipoDocumento nvarchar(50),
	numeroDocumento nvarchar(50),
	montoTotal decimal (10,2),
	fechaRegistro datetime default getdate(),
);

create table DETALLECOMPRA (
	idDetalleCompra int primary key identity,
	idCompra int references COMPRA(idCompra),
	idProducto int references PRODUCTO(idProducto),
	precioCompra decimal(10,2) default 0,
	precioVenta decimal(10,2) default 0,
	cantidad int,
	montoTotal decimal(10,2),
	fechaRegistro datetime default getdate(),
);

create table VENTA (
	idVenta int primary key identity,
	idUsuario int references USUARIO(idUsuario),
	tipoDocumento nvarchar(50),
	numeroDocumento nvarchar(50),
	documentoCliente nvarchar(50),
	nombreCliente nvarchar(100),
	montoPago decimal(10,2),
	montoCambio decimal (10,2),
	montoTotal decimal (10,2),
	fechaRegistro datetime default getdate(),
);

create table DETALLEVENTA (
	idDetalleVenta int primary key identity,
	idVenta int references VENTA(idVenta),
	idProducto int references PRODUCTO(idProducto),
	precioVenta decimal(10,2) default 0,
	cantidad int,
	subTotal decimal(10,2),
	fechaRegistro datetime default getdate(),
);